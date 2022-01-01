namespace GUIProject.Forms
{
    partial class LocataireAddFrm2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.civiliteTxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.postnomTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenomTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dobTxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lieuTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.profTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enfantTxt = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailCheck = new System.Windows.Forms.CheckBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.etatTxt = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantTxt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 44);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIProject.Properties.Resources.House_70px1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(966, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 36);
            this.button3.TabIndex = 61;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Civilité";
            // 
            // civiliteTxt
            // 
            this.civiliteTxt.FormattingEnabled = true;
            this.civiliteTxt.Items.AddRange(new object[] {
            "M.",
            "Mme.",
            "Mlle."});
            this.civiliteTxt.Location = new System.Drawing.Point(70, 95);
            this.civiliteTxt.Name = "civiliteTxt";
            this.civiliteTxt.Size = new System.Drawing.Size(82, 25);
            this.civiliteTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(205, 95);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(211, 23);
            this.nomTxt.TabIndex = 9;
            // 
            // postnomTxt
            // 
            this.postnomTxt.Location = new System.Drawing.Point(486, 95);
            this.postnomTxt.Name = "postnomTxt";
            this.postnomTxt.Size = new System.Drawing.Size(211, 23);
            this.postnomTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Postnom";
            // 
            // prenomTxt
            // 
            this.prenomTxt.Location = new System.Drawing.Point(769, 92);
            this.prenomTxt.Name = "prenomTxt";
            this.prenomTxt.Size = new System.Drawing.Size(211, 23);
            this.prenomTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Né(e) le";
            // 
            // dobTxt
            // 
            this.dobTxt.Location = new System.Drawing.Point(70, 144);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(226, 23);
            this.dobTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "à";
            // 
            // lieuTxt
            // 
            this.lieuTxt.Location = new System.Drawing.Point(325, 146);
            this.lieuTxt.Name = "lieuTxt";
            this.lieuTxt.Size = new System.Drawing.Size(655, 23);
            this.lieuTxt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Profession";
            // 
            // profTxt
            // 
            this.profTxt.Location = new System.Drawing.Point(703, 188);
            this.profTxt.Name = "profTxt";
            this.profTxt.Size = new System.Drawing.Size(241, 23);
            this.profTxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nombre enfants";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enfantTxt
            // 
            this.enfantTxt.Location = new System.Drawing.Point(448, 191);
            this.enfantTxt.Name = "enfantTxt";
            this.enfantTxt.Size = new System.Drawing.Size(172, 23);
            this.enfantTxt.TabIndex = 21;
            this.enfantTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailCheck);
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(133, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 116);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // mailCheck
            // 
            this.mailCheck.AutoSize = true;
            this.mailCheck.Location = new System.Drawing.Point(482, 74);
            this.mailCheck.Name = "mailCheck";
            this.mailCheck.Size = new System.Drawing.Size(329, 21);
            this.mailCheck.TabIndex = 24;
            this.mailCheck.Text = "Envoyer les documents sur cette adresse e-mail";
            this.mailCheck.UseVisualStyleBackColor = true;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(90, 72);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(386, 23);
            this.mailTxt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "E-mail";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(90, 32);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(241, 23);
            this.phoneTxt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Téléphone";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIProject.Properties.Resources.iPhone_48px;
            this.pictureBox2.Location = new System.Drawing.Point(41, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.Location = new System.Drawing.Point(876, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 29);
            this.button4.TabIndex = 108;
            this.button4.Text = "Ok";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(768, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 107;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 109;
            this.label11.Text = "Etat civil";
            // 
            // etatTxt
            // 
            this.etatTxt.FormattingEnabled = true;
            this.etatTxt.Items.AddRange(new object[] {
            "Célibataire",
            "Marié(e)"});
            this.etatTxt.Location = new System.Drawing.Point(70, 188);
            this.etatTxt.Name = "etatTxt";
            this.etatTxt.Size = new System.Drawing.Size(226, 25);
            this.etatTxt.TabIndex = 110;
            // 
            // LocataireAddFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 427);
            this.Controls.Add(this.etatTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enfantTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.profTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lieuTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dobTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prenomTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postnomTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.civiliteTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocataireAddFrm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocataireAddFrm2";
            this.Load += new System.EventHandler(this.LocataireAddFrm2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantTxt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox civiliteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.TextBox postnomTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenomTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dobTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lieuTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox profTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown enfantTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox mailCheck;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox etatTxt;
    }
}