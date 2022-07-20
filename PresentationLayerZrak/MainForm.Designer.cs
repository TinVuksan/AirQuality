
namespace PresentationLayerZrak
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_NavBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_navLogovi = new System.Windows.Forms.Button();
            this.btn_navIspis = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.btn_navPočetna = new System.Windows.Forms.Button();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_naslov = new System.Windows.Forms.Label();
            this.panel_DesktopPanel = new System.Windows.Forms.Panel();
            this.pocetna_Tekst = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_NavBar.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel_DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_NavBar
            // 
            this.panel_NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_NavBar.Controls.Add(this.label1);
            this.panel_NavBar.Controls.Add(this.btn_navLogovi);
            this.panel_NavBar.Controls.Add(this.btn_navIspis);
            this.panel_NavBar.Controls.Add(this.panel_Logo);
            this.panel_NavBar.Controls.Add(this.btn_navPočetna);
            this.panel_NavBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_NavBar.Location = new System.Drawing.Point(0, 0);
            this.panel_NavBar.Name = "panel_NavBar";
            this.panel_NavBar.Size = new System.Drawing.Size(200, 769);
            this.panel_NavBar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 727);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tin Vukšan, PIN-2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_navLogovi
            // 
            this.btn_navLogovi.FlatAppearance.BorderSize = 0;
            this.btn_navLogovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navLogovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_navLogovi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_navLogovi.Image = global::PresentationLayerZrak.Properties.Resources.HomeFinal;
            this.btn_navLogovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navLogovi.Location = new System.Drawing.Point(0, 83);
            this.btn_navLogovi.Name = "btn_navLogovi";
            this.btn_navLogovi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_navLogovi.Size = new System.Drawing.Size(200, 108);
            this.btn_navLogovi.TabIndex = 17;
            this.btn_navLogovi.Text = "  Početna";
            this.btn_navLogovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_navLogovi.UseVisualStyleBackColor = true;
            this.btn_navLogovi.Click += new System.EventHandler(this.btn_navLogovi_Click);
            // 
            // btn_navIspis
            // 
            this.btn_navIspis.FlatAppearance.BorderSize = 0;
            this.btn_navIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_navIspis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_navIspis.Image = global::PresentationLayerZrak.Properties.Resources.Ispisdobro;
            this.btn_navIspis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navIspis.Location = new System.Drawing.Point(0, 189);
            this.btn_navIspis.Name = "btn_navIspis";
            this.btn_navIspis.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_navIspis.Size = new System.Drawing.Size(200, 112);
            this.btn_navIspis.TabIndex = 16;
            this.btn_navIspis.Text = "  Ispis";
            this.btn_navIspis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_navIspis.UseVisualStyleBackColor = true;
            this.btn_navIspis.Click += new System.EventHandler(this.btn_navIspis_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Logo.Controls.Add(this.lbl_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(200, 83);
            this.panel_Logo.TabIndex = 15;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Logo.Location = new System.Drawing.Point(54, 25);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(84, 31);
            this.lbl_Logo.TabIndex = 0;
            this.lbl_Logo.Text = "PIN-2";
            // 
            // btn_navPočetna
            // 
            this.btn_navPočetna.FlatAppearance.BorderSize = 0;
            this.btn_navPočetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navPočetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_navPočetna.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_navPočetna.Image = global::PresentationLayerZrak.Properties.Resources.logovi;
            this.btn_navPočetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navPočetna.Location = new System.Drawing.Point(0, 301);
            this.btn_navPočetna.Name = "btn_navPočetna";
            this.btn_navPočetna.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_navPočetna.Size = new System.Drawing.Size(200, 112);
            this.btn_navPočetna.TabIndex = 14;
            this.btn_navPočetna.Text = "  Logovi";
            this.btn_navPočetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_navPočetna.UseVisualStyleBackColor = true;
            this.btn_navPočetna.Click += new System.EventHandler(this.btn_Statistika_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Title.Controls.Add(this.btn_Minimize);
            this.panel_Title.Controls.Add(this.btn_Maximize);
            this.panel_Title.Controls.Add(this.btn_Exit);
            this.panel_Title.Controls.Add(this.lbl_naslov);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(200, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1182, 83);
            this.panel_Title.TabIndex = 16;
            this.panel_Title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Title_Paint);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.Location = new System.Drawing.Point(1068, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 15;
            this.btn_Minimize.Text = "O";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Maximize.Location = new System.Drawing.Point(1104, 12);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 14;
            this.btn_Maximize.Text = "O";
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.Location = new System.Drawing.Point(1140, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "O";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_naslov
            // 
            this.lbl_naslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_naslov.AutoSize = true;
            this.lbl_naslov.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naslov.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_naslov.Location = new System.Drawing.Point(455, 9);
            this.lbl_naslov.Name = "lbl_naslov";
            this.lbl_naslov.Size = new System.Drawing.Size(344, 64);
            this.lbl_naslov.TabIndex = 12;
            this.lbl_naslov.Text = "Kvaliteta zraka";
            this.lbl_naslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_naslov.Click += new System.EventHandler(this.lbl_naslov_Click);
            // 
            // panel_DesktopPanel
            // 
            this.panel_DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.panel_DesktopPanel.Controls.Add(this.pocetna_Tekst);
            this.panel_DesktopPanel.Controls.Add(this.pictureBox1);
            this.panel_DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DesktopPanel.ForeColor = System.Drawing.Color.Transparent;
            this.panel_DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.panel_DesktopPanel.Name = "panel_DesktopPanel";
            this.panel_DesktopPanel.Size = new System.Drawing.Size(1382, 769);
            this.panel_DesktopPanel.TabIndex = 17;
            // 
            // pocetna_Tekst
            // 
            this.pocetna_Tekst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pocetna_Tekst.AutoSize = true;
            this.pocetna_Tekst.BackColor = System.Drawing.Color.Transparent;
            this.pocetna_Tekst.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocetna_Tekst.ForeColor = System.Drawing.Color.Black;
            this.pocetna_Tekst.Location = new System.Drawing.Point(465, 189);
            this.pocetna_Tekst.Name = "pocetna_Tekst";
            this.pocetna_Tekst.Size = new System.Drawing.Size(697, 120);
            this.pocetna_Tekst.TabIndex = 0;
            this.pocetna_Tekst.Text = "Provjera kvalitete zraka na \r\npodručju Republike Hrvatske";
            this.pocetna_Tekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::PresentationLayerZrak.Properties.Resources.Green_Leaf_PNG_Photo;
            this.pictureBox1.Location = new System.Drawing.Point(545, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1382, 769);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_NavBar);
            this.Controls.Add(this.panel_DesktopPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kvaliteta zraka";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_NavBar.ResumeLayout(false);
            this.panel_NavBar.PerformLayout();
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_DesktopPanel.ResumeLayout(false);
            this.panel_DesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_navPočetna;
        private System.Windows.Forms.Panel panel_NavBar;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_navLogovi;
        private System.Windows.Forms.Button btn_navIspis;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Panel panel_DesktopPanel;
        private System.Windows.Forms.Label lbl_naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pocetna_Tekst;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

