
namespace PresentationLayerZrak
{
    partial class IspisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Ispis = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Do = new System.Windows.Forms.Label();
            this.lbl_Od = new System.Windows.Forms.Label();
            this.lbl_Tvar = new System.Windows.Forms.Label();
            this.lbl_Postaja = new System.Windows.Forms.Label();
            this.selectBox_Tvar = new System.Windows.Forms.ComboBox();
            this.selectBox_Postaja = new System.Windows.Forms.ComboBox();
            this.dataGridViewTvari = new System.Windows.Forms.DataGridView();
            this.VrijednostTvari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinicaTvari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeTvari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTvari)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ispis
            // 
            this.btn_Ispis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ispis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Ispis.FlatAppearance.BorderSize = 0;
            this.btn_Ispis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ispis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ispis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Ispis.Location = new System.Drawing.Point(386, 660);
            this.btn_Ispis.Name = "btn_Ispis";
            this.btn_Ispis.Size = new System.Drawing.Size(247, 50);
            this.btn_Ispis.TabIndex = 23;
            this.btn_Ispis.Text = "Ispiši";
            this.btn_Ispis.UseVisualStyleBackColor = false;
            this.btn_Ispis.Click += new System.EventHandler(this.btn_Ispis_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(385, 569);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CustomFormat = "d.M.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 433);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            // 
            // lbl_Do
            // 
            this.lbl_Do.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Do.AutoSize = true;
            this.lbl_Do.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Do.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Do.Location = new System.Drawing.Point(380, 508);
            this.lbl_Do.Name = "lbl_Do";
            this.lbl_Do.Size = new System.Drawing.Size(39, 28);
            this.lbl_Do.TabIndex = 20;
            this.lbl_Do.Text = "Do";
            // 
            // lbl_Od
            // 
            this.lbl_Od.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Od.AutoSize = true;
            this.lbl_Od.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Od.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Od.Location = new System.Drawing.Point(381, 379);
            this.lbl_Od.Name = "lbl_Od";
            this.lbl_Od.Size = new System.Drawing.Size(40, 28);
            this.lbl_Od.TabIndex = 19;
            this.lbl_Od.Text = "Od";
            // 
            // lbl_Tvar
            // 
            this.lbl_Tvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tvar.AutoSize = true;
            this.lbl_Tvar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tvar.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tvar.Location = new System.Drawing.Point(381, 247);
            this.lbl_Tvar.Name = "lbl_Tvar";
            this.lbl_Tvar.Size = new System.Drawing.Size(182, 28);
            this.lbl_Tvar.TabIndex = 18;
            this.lbl_Tvar.Text = "Onečišćujuća tvar";
            // 
            // lbl_Postaja
            // 
            this.lbl_Postaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Postaja.AutoSize = true;
            this.lbl_Postaja.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Postaja.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Postaja.Location = new System.Drawing.Point(380, 108);
            this.lbl_Postaja.Name = "lbl_Postaja";
            this.lbl_Postaja.Size = new System.Drawing.Size(83, 28);
            this.lbl_Postaja.TabIndex = 17;
            this.lbl_Postaja.Text = "Postaja";
            // 
            // selectBox_Tvar
            // 
            this.selectBox_Tvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBox_Tvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectBox_Tvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBox_Tvar.FormattingEnabled = true;
            this.selectBox_Tvar.Location = new System.Drawing.Point(385, 315);
            this.selectBox_Tvar.Name = "selectBox_Tvar";
            this.selectBox_Tvar.Size = new System.Drawing.Size(248, 28);
            this.selectBox_Tvar.TabIndex = 16;
            // 
            // selectBox_Postaja
            // 
            this.selectBox_Postaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBox_Postaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectBox_Postaja.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBox_Postaja.FormattingEnabled = true;
            this.selectBox_Postaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectBox_Postaja.Items.AddRange(new object[] {
            "AMP Kaštijun"});
            this.selectBox_Postaja.Location = new System.Drawing.Point(385, 176);
            this.selectBox_Postaja.Name = "selectBox_Postaja";
            this.selectBox_Postaja.Size = new System.Drawing.Size(248, 28);
            this.selectBox_Postaja.TabIndex = 15;
            this.selectBox_Postaja.SelectedIndexChanged += new System.EventHandler(this.selectBox_Postaja_SelectedIndexChanged);
            this.selectBox_Postaja.TextChanged += new System.EventHandler(this.selectBox_Postaja_TextChanged_1);
            // 
            // dataGridViewTvari
            // 
            this.dataGridViewTvari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTvari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTvari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridViewTvari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTvari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTvari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTvari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrijednostTvari,
            this.MjernaJedinicaTvari,
            this.VrijemeTvari});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTvari.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTvari.GridColor = System.Drawing.Color.Black;
            this.dataGridViewTvari.Location = new System.Drawing.Point(764, 149);
            this.dataGridViewTvari.Name = "dataGridViewTvari";
            this.dataGridViewTvari.ReadOnly = true;
            this.dataGridViewTvari.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTvari.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTvari.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTvari.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTvari.Size = new System.Drawing.Size(508, 561);
            this.dataGridViewTvari.TabIndex = 14;
            // 
            // VrijednostTvari
            // 
            this.VrijednostTvari.DataPropertyName = "Vrijednost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.VrijednostTvari.DefaultCellStyle = dataGridViewCellStyle2;
            this.VrijednostTvari.HeaderText = "Vrijednost";
            this.VrijednostTvari.Name = "VrijednostTvari";
            this.VrijednostTvari.ReadOnly = true;
            // 
            // MjernaJedinicaTvari
            // 
            this.MjernaJedinicaTvari.DataPropertyName = "MjernaJedinica";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.MjernaJedinicaTvari.DefaultCellStyle = dataGridViewCellStyle3;
            this.MjernaJedinicaTvari.HeaderText = "Mjerna jedinica";
            this.MjernaJedinicaTvari.Name = "MjernaJedinicaTvari";
            this.MjernaJedinicaTvari.ReadOnly = true;
            // 
            // VrijemeTvari
            // 
            this.VrijemeTvari.DataPropertyName = "Vrijeme";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.VrijemeTvari.DefaultCellStyle = dataGridViewCellStyle4;
            this.VrijemeTvari.HeaderText = "Vrijeme";
            this.VrijemeTvari.Name = "VrijemeTvari";
            this.VrijemeTvari.ReadOnly = true;
            // 
            // IspisForm
            // 
            this.AcceptButton = this.btn_Ispis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1382, 769);
            this.Controls.Add(this.btn_Ispis);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Do);
            this.Controls.Add(this.lbl_Od);
            this.Controls.Add(this.lbl_Tvar);
            this.Controls.Add(this.lbl_Postaja);
            this.Controls.Add(this.selectBox_Tvar);
            this.Controls.Add(this.selectBox_Postaja);
            this.Controls.Add(this.dataGridViewTvari);
            this.Name = "IspisForm";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.IspisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTvari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ispis;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lbl_Do;
        public System.Windows.Forms.Label lbl_Od;
        public System.Windows.Forms.Label lbl_Tvar;
        public System.Windows.Forms.Label lbl_Postaja;
        public System.Windows.Forms.ComboBox selectBox_Tvar;
        public System.Windows.Forms.ComboBox selectBox_Postaja;
        public System.Windows.Forms.DataGridView dataGridViewTvari;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijednostTvari;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinicaTvari;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeTvari;
    }
}