namespace Afetzede
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            button4 = new Button();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(57, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 165);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 45, 114);
            label4.Location = new Point(725, 133);
            label4.Name = "label4";
            label4.Size = new Size(35, 16);
            label4.TabIndex = 7;
            label4.Text = "Çıkış";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.BackgroundImage = Properties.Resources.png_transparent_computer_icons_abmeldung_exit_logo_abmeldung_login_thumbnail;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.ForeColor = Color.FromArgb(0, 45, 114);
            button4.Location = new Point(671, 13);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(135, 100);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 45, 114);
            label3.Location = new Point(449, 133);
            label3.Name = "label3";
            label3.Size = new Size(157, 16);
            label3.TabIndex = 5;
            label3.Text = "Çadır Sayısı Güncelleme";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.BackgroundImage = Properties.Resources.çadır;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ForeColor = Color.FromArgb(0, 45, 114);
            button3.Location = new Point(458, 13);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(135, 100);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 45, 114);
            label2.Location = new Point(248, 133);
            label2.Name = "label2";
            label2.Size = new Size(132, 16);
            label2.TabIndex = 3;
            label2.Text = "Afetzede Listeleme";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.BackgroundImage = Properties.Resources.listing;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.ForeColor = Color.FromArgb(0, 45, 114);
            button2.Location = new Point(245, 13);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(135, 100);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 45, 114);
            label1.Location = new Point(45, 133);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 1;
            label1.Text = "Afetzede Kayıt";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImage = Properties.Resources.add_person_2646097_960_720;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = Color.FromArgb(0, 45, 114);
            button1.Location = new Point(32, 13);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(135, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.AFAD_Logo_Turkce_Yatay;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(981, 572);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perşembe Pazarı Çadırkent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label4;
        private Button button4;
        private Label label3;
        private Button button3;
        private Label label2;
        private Button button2;
    }
}