namespace gestionStock
{
    partial class FormProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduit));
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtQté = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.idP = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(219, 258);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(394, 28);
            this.txtPrix.TabIndex = 31;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Location = new System.Drawing.Point(147, 265);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(46, 21);
            this.labelConfirm.TabIndex = 30;
            this.labelConfirm.Text = "Prix :";
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.Red;
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.ForeColor = System.Drawing.Color.White;
            this.btnSup.Location = new System.Drawing.Point(503, 462);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(110, 50);
            this.btnSup.TabIndex = 29;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = false;
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Olive;
            this.btnModif.FlatAppearance.BorderSize = 0;
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(384, 462);
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
            this.btnAjout.Location = new System.Drawing.Point(271, 462);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(107, 50);
            this.btnAjout.TabIndex = 27;
            this.btnAjout.Text = "Valider";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtQté
            // 
            this.txtQté.Location = new System.Drawing.Point(219, 197);
            this.txtQté.Name = "txtQté";
            this.txtQté.Size = new System.Drawing.Size(394, 28);
            this.txtQté.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Catégorie :";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(219, 317);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(394, 28);
            this.txtDes.TabIndex = 20;
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(219, 129);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(394, 28);
            this.txtNameP.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom Produit :";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(684, 0);
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
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Produits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description :";
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
            this.panel1.Size = new System.Drawing.Size(709, 62);
            this.panel1.TabIndex = 16;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(219, 376);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(394, 29);
            this.comboBoxCat.TabIndex = 32;
            // 
            // idP
            // 
            this.idP.AutoSize = true;
            this.idP.Location = new System.Drawing.Point(80, 477);
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(88, 21);
            this.idP.TabIndex = 33;
            this.idP.Text = "Produit id";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(333, 81);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(0, 21);
            this.lblTitre.TabIndex = 34;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 535);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.idP);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtQté);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNameP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label labelConfirm;
        public System.Windows.Forms.Button btnSup;
        public System.Windows.Forms.Button btnModif;
        public System.Windows.Forms.Button btnAjout;
        public System.Windows.Forms.TextBox txtQté;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDes;
        public System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBoxCat;
        public System.Windows.Forms.Label idP;
        private System.Windows.Forms.Label lblTitre;
    }
}