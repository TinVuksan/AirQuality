using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace DataAccessLayerZrak
{
   public class TvarRepository
    {
        string connectionString = "Server=193.198.57.183;Database=STUDENTI_PIN;User Id=pin;Password=Vsmti1234!;";
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
           enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public List<Postaja> GetSvePostaje()
        {
            var postaje = new List<Postaja>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Vuksan_Postaje";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        postaje.Add(new Postaja()
                        {
                            Id = (int)reader["id"],
                            ImePostaje = (string)reader["postaja"],

                        });
                    }
                }
            }
            return postaje;
        }

        public List<Tvar> GetSveTvari()
        {
            var tvari = new List<Tvar>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Vuksan_tvari";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tvari.Add(new Tvar()
                        {
                            Id = (int)reader["id"],
                            ImeTvari = (string)reader["tvar"],

                        });
                    }
                }
            }
            return tvari;
        }

        public List<PostajaTvar> PostajeTvari()
        {
            var postajetvari = new List<PostajaTvar>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Vuksan_PostajeTvari";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        postajetvari.Add(new PostajaTvar()
                        {
                            Id_postaje = (int)reader["Id_postaje"],
                            Id_tvari = (int)reader["Id_tvari"],
                            Ime_postaje = (string)reader["ime_postaje"]


                        });
                    }
                }
            }
            return postajetvari;
        }



        public List<String> IspisTvari(string odabraniGrad)
        {
            var postajetvari = PostajeTvari();
            var tvari = GetSveTvari();
            List<String> idTvari = new List<String>();
            List<String> imenaTvari = new List<String>();

            foreach (var postajatvar in postajetvari)
            {
                idTvari = postajetvari.Where(x => x.Ime_postaje == odabraniGrad).Select(x => x.Id_tvari.ToString()).ToList();
            }

            for (int x = 0; x < idTvari.Count();x++)
            {
                if(Convert.ToInt32(idTvari[x]) == 0)
                {
                    System.Windows.MessageBox.Show("Za ovu postaju ne postoje podaci!", "Greška", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                }
                for(int y = 0; y<tvari.Count();y++)
                {
                    if(idTvari[x] == tvari[y].Id.ToString())
                    {
                        imenaTvari.Add(tvari[y].ImeTvari);
                    }
                }
            }
            

            return imenaTvari;
        }

        public List<string>GetImenaPostaja()
        {
            var postaje = GetSvePostaje();
            List<String> imena = new List<String>();
            imena = postaje.Select(x => x.ImePostaje).OrderBy(x=> x).ToList();

            return imena;
        }

        public List<Ispis> Ispis(string postaja, string tvar, string odDatum, string doDatum)
        {
           
            var postaje = GetSvePostaje();
            var tvari = GetSveTvari();
            for(int x=0; x<postaje.Count();x++)
            {
                if(postaje[x].ImePostaje == postaja)
                {
                    string pp = postaje[x].Id.ToString();
                    postaja = pp;
                    string imePostaje = postaje[x].ImePostaje;
                }
            }

            for (int y = 0; y < tvari.Count(); y++)
            {
                
                if (tvari[y].ImeTvari == tvar)
                {
                    string tt = tvari[y].Id.ToString();
                    tvar = tt;
                }
            }


            
            List<Ispis> tvariREST = new List<Ispis>();
            string url = $"http://iszz.azo.hr/iskzl/rs/podatak/export/json?tipPodatka=4&postaja={postaja}&polutant={tvar}&vrijemeOd={odDatum}&vrijemeDo={doDatum}";
            string json = CallRestMethod(url);
            JArray jsonA = JArray.Parse(json);
            foreach (JObject item in jsonA)
            {
                try
                {
                    tvariREST.Add(new Ispis
                    {
                     
                        Vrijednost = (decimal)item.GetValue("vrijednost"),
                        MjernaJedinica = (string)item.GetValue("mjernaJedinica"),
                        Vrijeme = UnixTimeStampToDateTime((long)item.GetValue("vrijeme")),
                        
                    }) ;

                    using (DbConnection connection = new SqlConnection(connectionString))
                    using (DbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"IF NOT EXISTS (SELECT 1 FROM Vuksan_Log WHERE Vuksan_Log.Vrijednost = {(decimal)item.GetValue("vrijednost")} AND Vuksan_Log.Postaja = {postaja} AND Vuksan_Log.Tvar = {tvar}) BEGIN INSERT INTO Vuksan_Log (Vrijednost, MjernaJedinica, Datum, Postaja, Tvar) VALUES('{(decimal)item.GetValue("vrijednost")}', '{(string)item.GetValue("mjernaJedinica")}', '{UnixTimeStampToDateTime((long)item.GetValue("vrijeme"))}', '{postaja}', '{tvar}') END";
                        connection.Open();
                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    throw (exception);

                }
            }

            return tvariREST;

        }

        public static string UnixTimeStampToDateTime(long unixTimeStamp)
        {
            unixTimeStamp = unixTimeStamp / 1000;
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();   
            return dateTime.ToString("dd.MM.yyyy");
        }


    }


}
