using DataAccessLayerZrak;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayerZrak
{
    public partial class Statistika : Form
    {
        public Statistika()
        {

            InitializeComponent();
            _postajeBindingSource.DataSource = _tvarRepository.GetImenaPostaja();


        }
        private TvarRepository _tvarRepository = new TvarRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private LogRepository _logRepository = new LogRepository();
        private BindingSource _postajeBindingSource = new BindingSource();
        private BindingSource _tvariBindingSource = new BindingSource();

        private void Statistika_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _tableBindingSource;
            _tableBindingSource.DataSource = _logRepository.GetSveLogove();
            select_Grad.DataSource = _postajeBindingSource;
            select_Tvar.DataSource = _tvariBindingSource;

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Mjesec",
                Labels = new[] { "Siječanj", "Veljača", "Ožujak", "Travanj", "Svibanj", "Lipanj", "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac" }
                
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Vrijednost",
                LabelFormatter = value => value.ToString("N")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;


        }





        private void btn_Load_Click(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _logRepository.LogoviPoGradovima(select_Grad.Text, select_Tvar.Text);

            btn_IspisTxt.Enabled = true;

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in _tableBindingSource.DataSource as List<Log>
                         select new { Year = o.Vrijeme.Substring(6, 4) }).Distinct();



            foreach (var year in years)
            {
                List<decimal> values = new List<decimal>();
                for (int month = 1; month <= 12; month++)
                {
                    decimal value = 0;
                    var data = from o in _tableBindingSource.DataSource as List<Log>
                               where (o.Vrijeme.Substring(6, 4).Equals(year.Year) && Convert.ToInt32(o.Vrijeme.Substring(3, 2)).Equals(month))
                               //orderby Convert.ToInt32(o.Vrijeme.Substring(3,2)) ascending
                               select new { o.Vrijednost , V =Convert.ToInt32( o.Vrijeme.Substring(3,2))};

                    if (data.FirstOrDefault() != null)
                    {
                        value = data.FirstOrDefault().Vrijednost;
                        values.Add(value);
                    }
                    else
                    {
                        values.Add(0);
                    }

                
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<decimal>(values) });
            }
            cartesianChart1.Series = series;

        }

        private void lbl_SelectGrad_Click(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void select_Grad_TextChanged(object sender, EventArgs e)
        {
            _tvariBindingSource.DataSource = _tvarRepository.IspisTvari(select_Grad.Text);
        }

        private void btn_IspisTxt_Click(object sender, EventArgs e)
        {

            string grad = select_Grad.Text;
            string tvar = select_Tvar.Text;
            //This line of code creates a text file for the data export.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\izvješće_štetne_tvari.txt");
            try
            {
                string sLine = $"Izvješće o količini polutanta \"{tvar}\" u mjestu \"{grad}\" \n \n \n";

                //This for loop loops through each row in the table
                for (int r = 0; r <= dataGridView1.Rows.Count - 2; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " || ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                MessageBox.Show("Izvješće zapisano!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }
    }
}
