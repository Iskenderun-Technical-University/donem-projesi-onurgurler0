namespace Afetzede
{
    partial class Listeleme
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
            dataGridView1 = new DataGridView();
            txtTc = new TextBox();
            cmbHasar = new ComboBox();
            label1 = new Label();
            cmbUyruk = new ComboBox();
            label2 = new Label();
            cmbCadir = new ComboBox();
            label3 = new Label();
            txtTel = new TextBox();
            label4 = new Label();
            txtAdsoyad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnGeridon = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(157, 68);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(169, 23);
            txtTc.TabIndex = 18;
            // 
            // cmbHasar
            // 
            cmbHasar.FormattingEnabled = true;
            cmbHasar.Location = new Point(156, 338);
            cmbHasar.Name = "cmbHasar";
            cmbHasar.Size = new Size(169, 23);
            cmbHasar.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 45, 114);
            label1.Location = new Point(13, 76);
            label1.Name = "label1";
            label1.Size = new Size(105, 16);
            label1.TabIndex = 12;
            label1.Text = "Kimlik Numarası";
            // 
            // cmbUyruk
            // 
            cmbUyruk.FormattingEnabled = true;
            cmbUyruk.Location = new Point(156, 284);
            cmbUyruk.Name = "cmbUyruk";
            cmbUyruk.Size = new Size(169, 23);
            cmbUyruk.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 45, 114);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 13;
            label2.Text = "Adı Soyadı";
            // 
            // cmbCadir
            // 
            cmbCadir.FormattingEnabled = true;
            cmbCadir.Location = new Point(156, 230);
            cmbCadir.Name = "cmbCadir";
            cmbCadir.Size = new Size(169, 23);
            cmbCadir.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 45, 114);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 14;
            label3.Text = "Telefon Numarası";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(156, 176);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(169, 23);
            txtTel.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 45, 114);
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 15;
            label4.Text = "Çadır Seçiniz";
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(156, 122);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(169, 23);
            txtAdsoyad.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 45, 114);
            label5.Location = new Point(12, 292);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 16;
            label5.Text = "Uyruk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 45, 114);
            label6.Location = new Point(12, 346);
            label6.Name = "label6";
            label6.Size = new Size(118, 16);
            label6.TabIndex = 17;
            label6.Text = "Ev Hasar Durumu";
            // 
            // btnGeridon
            // 
            btnGeridon.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeridon.ForeColor = Color.FromArgb(0, 45, 114);
            btnGeridon.Location = new Point(238, 396);
            btnGeridon.Name = "btnGeridon";
            btnGeridon.Size = new Size(87, 55);
            btnGeridon.TabIndex = 25;
            btnGeridon.Text = "Geri Dön";
            btnGeridon.UseVisualStyleBackColor = true;
            btnGeridon.Click += btnGeridon_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.FromArgb(0, 45, 114);
            btnGuncelle.Location = new Point(13, 396);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(87, 55);
            btnGuncelle.TabIndex = 24;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.FromArgb(0, 45, 114);
            btnSil.Location = new Point(129, 396);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(87, 55);
            btnSil.TabIndex = 26;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(797, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 28;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 45, 114);
            label7.Location = new Point(658, 21);
            label7.Name = "label7";
            label7.Size = new Size(133, 16);
            label7.TabIndex = 27;
            label7.Text = "Kimlik Numarası Ara";
            // 
            // Listeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(981, 572);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnSil);
            Controls.Add(btnGeridon);
            Controls.Add(btnGuncelle);
            Controls.Add(txtTc);
            Controls.Add(cmbHasar);
            Controls.Add(label1);
            Controls.Add(cmbUyruk);
            Controls.Add(label2);
            Controls.Add(cmbCadir);
            Controls.Add(label3);
            Controls.Add(txtTel);
            Controls.Add(label4);
            Controls.Add(txtAdsoyad);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Name = "Listeleme";
            Text = "Listeleme";
            Load += Listeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTc;
        private ComboBox cmbHasar;
        private Label label1;
        private ComboBox cmbUyruk;
        private Label label2;
        private ComboBox cmbCadir;
        private Label label3;
        private TextBox txtTel;
        private Label label4;
        private TextBox txtAdsoyad;
        private Label label5;
        private Label label6;
        private Button btnGeridon;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox textBox1;
        private Label label7;
    }
}