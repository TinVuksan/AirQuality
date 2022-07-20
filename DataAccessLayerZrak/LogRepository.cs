using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerZrak
{

    public class LogRepository
    {
        string connectionString = "Server=193.198.57.183;Database=STUDENTI_PIN;User Id=pin;Password=Vsmti1234!;";
        public List<Log> GetSveLogove()
        {
            var tvarRepository = new TvarRepository();
            var postaje = tvarRepository.GetSvePostaje();

            string DajPostaju(int idPostaje) {
                string imePostaje = "";
                for (int x = 0; x < postaje.Count(); x++)
                {
                    if (postaje[x].Id == idPostaje)
                    {
                        imePostaje = postaje[x].ImePostaje;
                        
                        
                    }

                    
                }
                return imePostaje;
            }

            var tvari = tvarRepository.GetSveTvari();
            string DajTvar (int idTvari)
            {
                string imeTvari = "";
                for(int x = 0; x < tvari.Count(); x++)
                {
                    if(tvari[x].Id == idTvari)
                    {
                        imeTvari = tvari[x].ImeTvari;
                    }
                }
                return imeTvari;
            }

            var logovi = new List<Log>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Vuksan_Log";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logovi.Add(new Log()
                        {
                            Vrijednost = (decimal)reader["Vrijednost"],
                            MjernaJedinica = (string)reader["MjernaJedinica"],
                            Vrijeme = (string)reader["Datum"],
                            Postaja = DajPostaju((int)reader["Postaja"]),
                            Tvar = DajTvar((int)reader["Tvar"]),
                        });
                    }
                }
            }
            return logovi;
        }


        public List<Log>LogoviPoGradovima(string grad, string tvar)
        {
            var logovi = GetSveLogove();
            var logPoGradovima = new List<Log>();
            for(var i = 0; i<logovi.Count(); i++)
            {
                if(logovi[i].Postaja == grad && logovi[i].Tvar == tvar)
                {
                    logPoGradovima.Add(logovi[i]);
                    
                }
            }
            logPoGradovima = logPoGradovima.OrderBy(x => DateTime.ParseExact(x.Vrijeme, "dd.MM.yyyy", null)).ToList();
            return logPoGradovima;
        }

        //public List<string>DajPolutante()
        //{

        //    var tvari = new List<string>();
        //    using (DbConnection connection = new SqlConnection(connectionString))
        //    using (DbCommand command = connection.CreateCommand())
        //    {
        //        command.CommandText = "SELECT * FROM Vuksan_tvari";
        //        connection.Open();
        //        using (DbDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                tvari.Add((string)reader["tvar"]);
                            
                        
        //            }
        //        }
        //    }
        //    return tvari;
        //}
    }
}
