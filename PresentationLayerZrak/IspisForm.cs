using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayerZrak;

namespace PresentationLayerZrak
{
    public partial class IspisForm : Form
    {
        public IspisForm()
        {
            InitializeComponent();
            _postajeBindingSource.DataSource = _tvarRepository.GetImenaPostaja();
 
        }


        private TvarRepository _tvarRepository = new TvarRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private BindingSource _postajeBindingSource = new BindingSource();
        private BindingSource _tvariBindingSource = new BindingSource();


        private void IspisForm_Load(object sender, EventArgs e)
        {
            dataGridViewTvari.DataSource = _tableBindingSource;
            selectBox_Postaja.DataSource = _postajeBindingSource;
            selectBox_Tvar.DataSource = _tvariBindingSource;
        
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }


        private void selectBox_Postaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Postaja_Click(object sender, EventArgs e)
        {

        }



        private void selectBox_Postaja_TextChanged(object sender, EventArgs e)
        {
            _tvariBindingSource.DataSource = _tvarRepository.IspisTvari(selectBox_Postaja.Text);
        }

        private void txt_testOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ispis_Click(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _tvarRepository.Ispis(selectBox_Postaja.Text, selectBox_Tvar.Text, dateTimePicker1.Text, dateTimePicker2.Text);

        }

    

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void lbl_Tvar_Click(object sender, EventArgs e)
        {

        }

        private void selectBox_Postaja_TextChanged_1(object sender, EventArgs e)
        {
            _tvariBindingSource.DataSource = _tvarRepository.IspisTvari(selectBox_Postaja.Text);
        }

        private void btn_Ispis_Click_1(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _tvarRepository.Ispis(selectBox_Postaja.Text, selectBox_Tvar.Text, dateTimePicker1.Text, dateTimePicker2.Text);
        }

 


    }
}
