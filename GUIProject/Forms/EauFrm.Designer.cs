namespace GUIProject.Forms
{
    partial class EauFrm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.totalTxt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.prixTxt = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qteTxt = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finMask = new System.Windows.Forms.MaskedTextBox();
            this.debutMask = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTxt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qteTxt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 44);
            this.panel1.TabIndex = 129;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(356, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 36);
            this.button1.TabIndex = 99;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIProject.Properties.Resources.Plumbing_48px;
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
            this.button3.Location = new System.Drawing.Point(503, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 36);
            this.button3.TabIndex = 61;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.Location = new System.Drawing.Point(133, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 29);
            this.button4.TabIndex = 132;
            this.button4.Text = "Enregistrer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalTxt
            // 
            this.totalTxt.DecimalPlaces = 2;
            this.totalTxt.Enabled = false;
            this.totalTxt.Location = new System.Drawing.Point(294, 225);
            this.totalTxt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(68, 21);
            this.totalTxt.TabIndex = 131;
            this.totalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTxt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 130;
            this.label2.Text = "Prix /m cube";
            // 
            // prixTxt
            // 
            this.prixTxt.DecimalPlaces = 2;
            this.prixTxt.Location = new System.Drawing.Point(86, 31);
            this.prixTxt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.prixTxt.Name = "prixTxt";
            this.prixTxt.Size = new System.Drawing.Size(96, 21);
            this.prixTxt.TabIndex = 134;
            this.prixTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prixTxt.ValueChanged += new System.EventHandler(this.prixTxt_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.qteTxt);
            this.groupBox2.Controls.Add(this.prixTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 75);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcul cubage";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 137;
            this.label6.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 136;
            this.label5.Text = "3";
            // 
            // qteTxt
            // 
            this.qteTxt.DecimalPlaces = 2;
            this.qteTxt.Location = new System.Drawing.Point(210, 34);
            this.qteTxt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.qteTxt.Name = "qteTxt";
            this.qteTxt.Size = new System.Drawing.Size(126, 21);
            this.qteTxt.TabIndex = 135;
            this.qteTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qteTxt.ValueChanged += new System.EventHandler(this.qteTxt_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finMask);
            this.groupBox1.Controls.Add(this.debutMask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 63);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Période(Mois)";
            // 
            // finMask
            // 
            this.finMask.Enabled = false;
            this.finMask.Location = new System.Drawing.Point(210, 26);
            this.finMask.Mask = "00/00/0000";
            this.finMask.Name = "finMask";
            this.finMask.Size = new System.Drawing.Size(86, 21);
            this.finMask.TabIndex = 131;
            this.finMask.ValidatingType = typeof(System.DateTime);
            // 
            // debutMask
            // 
            this.debutMask.Enabled = false;
            this.debutMask.Location = new System.Drawing.Point(84, 26);
            this.debutMask.Mask = "00/00/0000";
            this.debutMask.Name = "debutMask";
            this.debutMask.Size = new System.Drawing.Size(86, 21);
            this.debutMask.TabIndex = 130;
            this.debutMask.ValidatingType = typeof(System.DateTime);
            this.debutMask.TextChanged += new System.EventHandler(this.debutMask_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 127;
            this.label3.Text = "au";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 124;
            this.label1.Text = "Du";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 139;
            this.label7.Text = "$";
            this.label7.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EauFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 257);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EauFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EauFrm";
            this.Load += new System.EventHandler(this.EauFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTxt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qteTxt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown totalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prixTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown qteTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.MaskedTextBox finMask;
        public System.Windows.Forms.MaskedTextBox debutMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}