namespace gestionStock
{
    partial class FormCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorie));
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtCdescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCRayon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lCid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.Red;
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.ForeColor = System.Drawing.Color.White;
            this.btnSup.Location = new System.Drawing.Point(547, 285);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(110, 50);
            this.btnSup.TabIndex = 40;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Olive;
            this.btnModif.FlatAppearance.BorderSize = 0;
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(428, 285);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(113, 50);
            this.btnModif.TabIndex = 39;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.Green;
            this.btnAjout.FlatAppearance.BorderSize = 0;
            this.btnAjout.ForeColor = System.Drawing.Color.White;
            this.btnAjout.Location = new System.Drawing.Point(315, 285);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(107, 50);
            this.btnAjout.TabIndex = 38;
            this.btnAjout.Text = "Valider";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtCdescription
            // 
            this.txtCdescription.Location = new System.Drawing.Point(206, 223);
            this.txtCdescription.Name = "txtCdescription";
            this.txtCdescription.Size = new System.Drawing.Size(451, 26);
            this.txtCdescription.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Description :";
            // 
            // txtCRayon
            // 
            this.txtCRayon.Location = new System.Drawing.Point(206, 168);
            this.txtCRayon.Name = "txtCRayon";
            this.txtCRayon.Size = new System.Drawing.Size(451, 26);
            this.txtCRayon.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rayon :";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(206, 114);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(451, 26);
            this.txtCName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom Catégorie :";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(708, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 11;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Catégories";
            // 
            // lCid
            // 
            this.lCid.AutoSize = true;
            this.lCid.Location = new System.Drawing.Point(62, 285);
            this.lCid.Name = "lCid";
            this.lCid.Size = new System.Drawing.Size(101, 20);
            this.lCid.TabIndex = 41;
            this.lCid.Text = "Catégorie id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 62);
            this.panel1.TabIndex = 31;
            // 
            // FormCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 350);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtCdescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCRayon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lCid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategorie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSup;
        public System.Windows.Forms.Button btnModif;
        public System.Windows.Forms.Button btnAjout;
        public System.Windows.Forms.TextBox txtCdescription;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCRayon;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lCid;
        private System.Windows.Forms.Panel panel1;
    }
}