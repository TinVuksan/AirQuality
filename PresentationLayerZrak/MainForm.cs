using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayerZrak;

namespace PresentationLayerZrak
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MainForm()
        {
            
            
            InitializeComponent();
            random = new Random();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel_Title.BackColor = color;
                    panel_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.07);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panel_NavBar.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
        
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_DesktopPanel.Controls.Add(childForm);
            this.panel_DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_naslov.Text = childForm.Text;
            
        }

        private void lbl_Postaja_Click(object sender, EventArgs e)
        {

        }

        private void selectBox_Postaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_tvariBindingSource.DataSource = _tvarRepository.Test("Zoljan");
        }

        private void selectBox_Postaja_TextUpdate(object sender, EventArgs e)
        {
            //_tvariBindingSource.DataSource = _tvarRepository.GetImenaTvari("Zoljan");
        }

        //private void selectBox_Postaja_TextChanged(object sender, EventArgs e)
        //{
        //    _tvariBindingSource.DataSource = _tvarRepository.Test(selectBox_Postaja.Text);
        //}

        //private void txt_testOd_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void btn_Ispis_Click(object sender, EventArgs e)
        //{
        //    _tableBindingSource.DataSource = _tvarRepository.Ispis(selectBox_Postaja.Text, selectBox_Tvar.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            
        //}

        private void btn_Statistika_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistika(), sender);
            //Statistika FormStatistika = new Statistika();
            //FormStatistika.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_navIspis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IspisForm(), sender);
        }

        private void lbl_Tvar_Click(object sender, EventArgs e)
        {

        }

        private void btn_navLogovi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainForm(), sender);
        }

        private void panel_Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_naslov_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
