namespace Afetzede
{
    partial class CadirEkleme
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
            txtCadirEkle = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            btnGeridon = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCadirEkle
            // 
            txtCadirEkle.Location = new Point(298, 43);
            txtCadirEkle.Name = "txtCadirEkle";
            txtCadirEkle.Size = new Size(51, 23);
            txtCadirEkle.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 45, 114);
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(262, 16);
            label1.TabIndex = 7;
            label1.Text = "Eklenecek Ya da Silincek Çadır Numarası";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.FromArgb(0, 45, 114);
            btnEkle.Location = new Point(25, 129);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(117, 55);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGeridon
            // 
            btnGeridon.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeridon.ForeColor = Color.FromArgb(0, 45, 114);
            btnGeridon.Location = new Point(298, 129);
            btnGeridon.Name = "btnGeridon";
            btnGeridon.Size = new Size(117, 55);
            btnGeridon.TabIndex = 15;
            btnGeridon.Text = "Geri Dön";
            btnGeridon.UseVisualStyleBackColor = true;
            btnGeridon.Click += btnGeridon_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 45, 114);
            button1.Location = new Point(162, 129);
            button1.Name = "button1";
            button1.Size = new Size(117, 55);
            button1.TabIndex = 16;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadirEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(448, 234);
            Controls.Add(button1);
            Controls.Add(btnGeridon);
            Controls.Add(btnEkle);
            Controls.Add(txtCadirEkle);
            Controls.Add(label1);
            Name = "CadirEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadirEkleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCadirEkle;
        private Label label1;
        private Button btnEkle;
        private Button btnGeridon;
        private Button button1;
    }
}