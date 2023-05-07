namespace Afetzede
{
    partial class AfetzedeEkleme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTc = new TextBox();
            txtAdsoyad = new TextBox();
            txtTel = new TextBox();
            cmbCadir = new ComboBox();
            cmbUyruk = new ComboBox();
            cmbHasar = new ComboBox();
            panel1 = new Panel();
            btnGeridon = new Button();
            btnTemizle = new Button();
            btnEkle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 45, 114);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 16);
            label1.TabIndex = 0;
            label1.Text = "Kimlik Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 45, 114);
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 45, 114);
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 2;
            label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 45, 114);
            label4.Location = new Point(21, 183);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 3;
            label4.Text = "Çadır Seçiniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 45, 114);
            label5.Location = new Point(21, 237);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 4;
            label5.Text = "Uyruk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 45, 114);
            label6.Location = new Point(21, 291);
            label6.Name = "label6";
            label6.Size = new Size(118, 16);
            label6.TabIndex = 5;
            label6.Text = "Ev Hasar Durumu";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(165, 13);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(259, 23);
            txtTc.TabIndex = 6;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(165, 67);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(259, 23);
            txtAdsoyad.TabIndex = 7;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(165, 121);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(259, 23);
            txtTel.TabIndex = 8;
            // 
            // cmbCadir
            // 
            cmbCadir.FormattingEnabled = true;
            cmbCadir.Location = new Point(165, 175);
            cmbCadir.Name = "cmbCadir";
            cmbCadir.Size = new Size(259, 23);
            cmbCadir.TabIndex = 9;
            // 
            // cmbUyruk
            // 
            cmbUyruk.FormattingEnabled = true;
            cmbUyruk.Location = new Point(165, 229);
            cmbUyruk.Name = "cmbUyruk";
            cmbUyruk.Size = new Size(259, 23);
            cmbUyruk.TabIndex = 10;
            // 
            // cmbHasar
            // 
            cmbHasar.FormattingEnabled = true;
            cmbHasar.Location = new Point(165, 283);
            cmbHasar.Name = "cmbHasar";
            cmbHasar.Size = new Size(259, 23);
            cmbHasar.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGeridon);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(txtTc);
            panel1.Controls.Add(cmbHasar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbUyruk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbCadir);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAdsoyad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 436);
            panel1.TabIndex = 12;
            // 
            // btnGeridon
            // 
            btnGeridon.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeridon.ForeColor = Color.FromArgb(0, 45, 114);
            btnGeridon.Location = new Point(307, 349);
            btnGeridon.Name = "btnGeridon";
            btnGeridon.Size = new Size(117, 55);
            btnGeridon.TabIndex = 14;
            btnGeridon.Text = "Geri Dön";
            btnGeridon.UseVisualStyleBackColor = true;
            btnGeridon.Click += button3_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTemizle.ForeColor = Color.FromArgb(0, 45, 114);
            btnTemizle.Location = new Point(165, 349);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(117, 55);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.FromArgb(0, 45, 114);
            btnEkle.Location = new Point(22, 349);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(117, 55);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // AfetzedeEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(529, 521);
            Controls.Add(panel1);
            Name = "AfetzedeEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Afetzede Ekleme";
            Load += AfetzedeEkleme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTc;
        private TextBox txtAdsoyad;
        private TextBox txtTel;
        private ComboBox cmbCadir;
        private ComboBox cmbUyruk;
        private ComboBox cmbHasar;
        private Panel panel1;
        private Button btnTemizle;
        private Button btnEkle;
        private Button btnGeridon;
    }
}