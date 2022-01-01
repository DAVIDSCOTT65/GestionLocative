namespace GUIProject.UserC
{
    partial class DetailBailUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.finTxt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.debutTxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dureeTxt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delaisTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exigTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.debutRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.expirRbtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.totalTxt = new System.Windows.Forms.Label();
            this.locationUser1 = new GUIProject.UserC.LocationUser();
            this.groupBox1.SuspendLayout();
            this.locationPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeTxt)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationPanel);
            this.groupBox1.Location = new System.Drawing.Point(27, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 127);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // locationPanel
            // 
            this.locationPanel.Controls.Add(this.locationUser1);
            this.locationPanel.Location = new System.Drawing.Point(6, 16);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(617, 102);
            this.locationPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.finTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.debutTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dureeTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 223);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details du bail";
            // 
            // finTxt
            // 
            this.finTxt.Enabled = false;
            this.finTxt.Location = new System.Drawing.Point(190, 119);
            this.finTxt.Name = "finTxt";
            this.finTxt.Size = new System.Drawing.Size(226, 23);
            this.finTxt.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date fin contrat";
            // 
            // debutTxt
            // 
            this.debutTxt.Location = new System.Drawing.Point(190, 77);
            this.debutTxt.Name = "debutTxt";
            this.debutTxt.Size = new System.Drawing.Size(226, 23);
            this.debutTxt.TabIndex = 24;
            this.debutTxt.ValueChanged += new System.EventHandler(this.debutTxt_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date d\'entrée( Prise d\'effet)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mois";
            // 
            // dureeTxt
            // 
            this.dureeTxt.Location = new System.Drawing.Point(190, 36);
            this.dureeTxt.Name = "dureeTxt";
            this.dureeTxt.Size = new System.Drawing.Size(40, 23);
            this.dureeTxt.TabIndex = 22;
            this.dureeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dureeTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dureeTxt.ValueChanged += new System.EventHandler(this.dureeTxt_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Durée du bail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delaisTxt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.exigTxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(436, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 347);
            this.groupBox3.TabIndex = 122;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paiement du loyer";
            // 
            // delaisTxt
            // 
            this.delaisTxt.Location = new System.Drawing.Point(196, 284);
            this.delaisTxt.Name = "delaisTxt";
            this.delaisTxt.Size = new System.Drawing.Size(31, 23);
            this.delaisTxt.TabIndex = 16;
            this.delaisTxt.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Délais en jour avant un \"Impayé\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "du mois";
            // 
            // exigTxt
            // 
            this.exigTxt.Location = new System.Drawing.Point(82, 246);
            this.exigTxt.Name = "exigTxt";
            this.exigTxt.Size = new System.Drawing.Size(31, 23);
            this.exigTxt.TabIndex = 13;
            this.exigTxt.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Exigible le ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.debutRbtn);
            this.groupBox5.Location = new System.Drawing.Point(6, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loyer payable";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "En fin de mois";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // debutRbtn
            // 
            this.debutRbtn.AutoSize = true;
            this.debutRbtn.Location = new System.Drawing.Point(19, 33);
            this.debutRbtn.Name = "debutRbtn";
            this.debutRbtn.Size = new System.Drawing.Size(139, 21);
            this.debutRbtn.TabIndex = 0;
            this.debutRbtn.TabStop = true;
            this.debutRbtn.Text = "En debut de mois";
            this.debutRbtn.UseVisualStyleBackColor = true;
            this.debutRbtn.CheckedChanged += new System.EventHandler(this.debutRbtn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.expirRbtn);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(6, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Périodicité";
            // 
            // expirRbtn
            // 
            this.expirRbtn.AutoSize = true;
            this.expirRbtn.Location = new System.Drawing.Point(19, 63);
            this.expirRbtn.Name = "expirRbtn";
            this.expirRbtn.Size = new System.Drawing.Size(176, 21);
            this.expirRbtn.TabIndex = 1;
            this.expirRbtn.TabStop = true;
            this.expirRbtn.Text = "A expiration du contrat";
            this.expirRbtn.UseVisualStyleBackColor = true;
            this.expirRbtn.CheckedChanged += new System.EventHandler(this.expirRbtn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mensuelle";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.totalTxt);
            this.groupBox6.Location = new System.Drawing.Point(6, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(424, 118);
            this.groupBox6.TabIndex = 123;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Montant à Payer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Paiement effectuer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.totalTxt.Location = new System.Drawing.Point(132, 37);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(156, 22);
            this.totalTxt.TabIndex = 26;
            this.totalTxt.Text = "Date fin contrat";
            // 
            // locationUser1
            // 
            this.locationUser1.BackColor = System.Drawing.Color.Gainsboro;
            this.locationUser1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationUser1.Font = new System.Drawing.Font("NanumGothic", 9.75F);
            this.locationUser1.Location = new System.Drawing.Point(4, 3);
            this.locationUser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationUser1.Name = "locationUser1";
            this.locationUser1.Size = new System.Drawing.Size(613, 93);
            this.locationUser1.TabIndex = 0;
            this.locationUser1.Load += new System.EventHandler(this.locationUser1_Load);
            this.locationUser1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.locationUser1_MouseClick);
            // 
            // DetailBailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailBailUser";
            this.Size = new System.Drawing.Size(687, 534);
            this.Load += new System.EventHandler(this.DetailBailUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.locationPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeTxt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel locationPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown dureeTxt;
        private System.Windows.Forms.DateTimePicker finTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker debutTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox delaisTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox exigTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton debutRbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton expirRbtn;
        private System.Windows.Forms.RadioButton radioButton1;
        public LocationUser locationUser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label totalTxt;
    }
}
