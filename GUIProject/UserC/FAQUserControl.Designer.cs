namespace GUIProject.UserC
{
    partial class FAQUserControl
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.answerLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(60, 5);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(453, 44);
            this.questionLbl.TabIndex = 104;
            this.questionLbl.Text = "Qu\'est-ce qu\'un appel de loyer ?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUIProject.Properties.Resources.FAQ_40px;
            this.pictureBox2.Location = new System.Drawing.Point(5, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // answerLbl
            // 
            this.answerLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(65, 49);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(409, 59);
            this.answerLbl.TabIndex = 105;
            this.answerLbl.Text = "L’appel de loyer est un document par lequel le bailleur notifie au locataire les " +
    "sommes qu’il lui doit. L’appel de loyer peut également être se dénommer « avis d" +
    "’échéance » .";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(3, 95);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(35, 13);
            this.idLbl.TabIndex = 106;
            this.idLbl.Text = "label2";
            this.idLbl.Visible = false;
            // 
            // FAQUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FAQUserControl";
            this.Size = new System.Drawing.Size(516, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label answerLbl;
        public System.Windows.Forms.Label idLbl;
    }
}
