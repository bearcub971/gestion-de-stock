namespace gestionStock
{
    partial class FormFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFournisseur));
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtFMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.Red;
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.ForeColor = System.Drawing.Color.White;
            this.btnSup.Location = new System.Drawing.Point(547, 270);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(110, 50);
            this.btnSup.TabIndex = 29;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Olive;
            this.btnModif.FlatAppearance.BorderSize = 0;
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(428, 270);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(113, 50);
            this.btnModif.TabIndex = 28;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.Green;
            this.btnAjout.FlatAppearance.BorderSize = 0;
            this.btnAjout.ForeColor = System.Drawing.Color.White;
            this.btnAjout.Location = new System.Drawing.Point(315, 270);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(107, 50);
            this.btnAjout.TabIndex = 27;
            this.btnAjout.Text = "Valider";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtFMail
            // 
            this.txtFMail.Location = new System.Drawing.Point(206, 208);
            this.txtFMail.Name = "txtFMail";
            this.txtFMail.Size = new System.Drawing.Size(451, 28);
            this.txtFMail.TabIndex = 24;
            this.txtFMail.TextChanged += new System.EventHandler(this.txtFMail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mail :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFTel
            // 
            this.txtFTel.Location = new System.Drawing.Point(206, 153);
            this.txtFTel.Name = "txtFTel";
            this.txtFTel.Size = new System.Drawing.Size(451, 28);
            this.txtFTel.TabIndex = 22;
            this.txtFTel.TextChanged += new System.EventHandler(this.txtFTel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Téléphone :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(206, 99);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(451, 28);
            this.txtFName.TabIndex = 18;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Fournisseur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.Location = new System.Drawing.Point(62, 270);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(117, 21);
            this.labelClick.TabIndex = 30;
            this.labelClick.Text = "Fournisseur id";
            this.labelClick.Click += new System.EventHandler(this.labelClick_Click);
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 350);
            this.Controls.Add(this.labelClick);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtFMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFournisseur";
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
        public System.Windows.Forms.TextBox txtFMail;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFTel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelClick;
    }
}