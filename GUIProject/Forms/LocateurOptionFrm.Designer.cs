namespace GUIProject.Forms
{
    partial class LocateurOptionFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.localLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.nomTxt = new System.Windows.Forms.Label();
            this.adresseLbl = new System.Windows.Forms.Label();
            this.repBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.locationBtn = new System.Windows.Forms.Button();
            this.reprendreRbtn = new System.Windows.Forms.RadioButton();
            this.createRbtn = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(563, 44);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIProject.Properties.Resources.User_Groups_70px1;
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
            this.button3.Location = new System.Drawing.Point(673, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 36);
            this.button3.TabIndex = 61;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idLbl);
            this.groupBox1.Controls.Add(this.localLbl);
            this.groupBox1.Controls.Add(this.adLbl);
            this.groupBox1.Controls.Add(this.nomTxt);
            this.groupBox1.Controls.Add(this.adresseLbl);
            this.groupBox1.Controls.Add(this.repBtn);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.locationBtn);
            this.groupBox1.Controls.Add(this.reprendreRbtn);
            this.groupBox1.Controls.Add(this.createRbtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 339);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'un nouveau Locateur et de son Bail";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.BackColor = System.Drawing.Color.Transparent;
            this.idLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(284, 222);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(48, 17);
            this.idLbl.TabIndex = 112;
            this.idLbl.Text = "locale";
            this.idLbl.Visible = false;
            // 
            // localLbl
            // 
            this.localLbl.AutoSize = true;
            this.localLbl.BackColor = System.Drawing.Color.Transparent;
            this.localLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLbl.Location = new System.Drawing.Point(124, 258);
            this.localLbl.Name = "localLbl";
            this.localLbl.Size = new System.Drawing.Size(48, 17);
            this.localLbl.TabIndex = 111;
            this.localLbl.Text = "locale";
            this.localLbl.Visible = false;
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.BackColor = System.Drawing.Color.Transparent;
            this.adLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLbl.Location = new System.Drawing.Point(123, 234);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(56, 17);
            this.adLbl.TabIndex = 110;
            this.adLbl.Text = "adresse";
            this.adLbl.Visible = false;
            // 
            // nomTxt
            // 
            this.nomTxt.AutoSize = true;
            this.nomTxt.BackColor = System.Drawing.Color.Transparent;
            this.nomTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTxt.Location = new System.Drawing.Point(123, 210);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(66, 17);
            this.nomTxt.TabIndex = 109;
            this.nomTxt.Text = "locataire";
            this.nomTxt.Visible = false;
            // 
            // adresseLbl
            // 
            this.adresseLbl.AutoSize = true;
            this.adresseLbl.BackColor = System.Drawing.Color.Transparent;
            this.adresseLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adresseLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLbl.Location = new System.Drawing.Point(116, 132);
            this.adresseLbl.Name = "adresseLbl";
            this.adresseLbl.Size = new System.Drawing.Size(56, 17);
            this.adresseLbl.TabIndex = 108;
            this.adresseLbl.Text = "Adresse";
            // 
            // repBtn
            // 
            this.repBtn.BackColor = System.Drawing.Color.Ivory;
            this.repBtn.Location = new System.Drawing.Point(60, 282);
            this.repBtn.Name = "repBtn";
            this.repBtn.Size = new System.Drawing.Size(59, 29);
            this.repBtn.TabIndex = 107;
            this.repBtn.Text = "...";
            this.repBtn.UseVisualStyleBackColor = false;
            this.repBtn.Click += new System.EventHandler(this.repBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIProject.Properties.Resources.User_Groups_70px1;
            this.pictureBox2.Location = new System.Drawing.Point(60, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // locationBtn
            // 
            this.locationBtn.BackColor = System.Drawing.Color.White;
            this.locationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBtn.FlatAppearance.BorderSize = 0;
            this.locationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBtn.Image = global::GUIProject.Properties.Resources.House_70px;
            this.locationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationBtn.Location = new System.Drawing.Point(45, 93);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(469, 65);
            this.locationBtn.TabIndex = 2;
            this.locationBtn.Text = "            Veuillez selectionner une location";
            this.locationBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.locationBtn.UseVisualStyleBackColor = false;
            this.locationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reprendreRbtn
            // 
            this.reprendreRbtn.AutoSize = true;
            this.reprendreRbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reprendreRbtn.Location = new System.Drawing.Point(26, 183);
            this.reprendreRbtn.Name = "reprendreRbtn";
            this.reprendreRbtn.Size = new System.Drawing.Size(294, 21);
            this.reprendreRbtn.TabIndex = 1;
            this.reprendreRbtn.TabStop = true;
            this.reprendreRbtn.Text = "Reprendre les informations d\'un autre bail";
            this.reprendreRbtn.UseVisualStyleBackColor = true;
            // 
            // createRbtn
            // 
            this.createRbtn.AutoSize = true;
            this.createRbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRbtn.Location = new System.Drawing.Point(26, 59);
            this.createRbtn.Name = "createRbtn";
            this.createRbtn.Size = new System.Drawing.Size(153, 21);
            this.createRbtn.TabIndex = 0;
            this.createRbtn.TabStop = true;
            this.createRbtn.Text = "Créer un bail vierge";
            this.createRbtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(437, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 107;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LocateurOptionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("NanumGothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LocateurOptionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocateurOptionFrm";
            this.Load += new System.EventHandler(this.LocateurOptionFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.RadioButton reprendreRbtn;
        private System.Windows.Forms.RadioButton createRbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button repBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label adresseLbl;
        public System.Windows.Forms.Label localLbl;
        public System.Windows.Forms.Label adLbl;
        public System.Windows.Forms.Label nomTxt;
        public System.Windows.Forms.Label idLbl;
    }
}