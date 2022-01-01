namespace GUIProject.UserC
{
    partial class LocataireAddUser
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
            this.locatairePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.locataireInfo1 = new GUIProject.UserC.LocataireInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addresseTxt = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.locatairePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // locatairePanel
            // 
            this.locatairePanel.AutoScroll = true;
            this.locatairePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locatairePanel.Controls.Add(this.locataireInfo1);
            this.locatairePanel.Location = new System.Drawing.Point(9, 20);
            this.locatairePanel.Name = "locatairePanel";
            this.locatairePanel.Size = new System.Drawing.Size(424, 405);
            this.locatairePanel.TabIndex = 0;
            // 
            // locataireInfo1
            // 
            this.locataireInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.locataireInfo1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locataireInfo1.Location = new System.Drawing.Point(4, 4);
            this.locataireInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.locataireInfo1.Name = "locataireInfo1";
            this.locataireInfo1.Size = new System.Drawing.Size(410, 72);
            this.locataireInfo1.TabIndex = 0;
            this.locataireInfo1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(439, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 26);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse de correspondance";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addresseTxt);
            this.panel2.Location = new System.Drawing.Point(439, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 380);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addresseTxt
            // 
            this.addresseTxt.Enabled = false;
            this.addresseTxt.Location = new System.Drawing.Point(3, 28);
            this.addresseTxt.Name = "addresseTxt";
            this.addresseTxt.Size = new System.Drawing.Size(237, 142);
            this.addresseTxt.TabIndex = 0;
            this.addresseTxt.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(41, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 109;
            this.button2.Text = "Ajouter un locataire";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(208, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 110;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.Location = new System.Drawing.Point(318, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 29);
            this.button3.TabIndex = 111;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // LocataireAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.locatairePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocataireAddUser";
            this.Size = new System.Drawing.Size(687, 534);
            this.Load += new System.EventHandler(this.LocataireAddUser_Load);
            this.locatairePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel locatairePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RichTextBox addresseTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public LocataireInfo locataireInfo1;
    }
}
