using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace gestionStock
{
    public partial class FormFournisseur : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public FormFournisseur()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show("Voulez-vous saugader un fournisseur ?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO fournisseur(fournisseur_nom,fournisseur_tel,fournisseur_mail)VALUES(@fournisseur_nom,@fournisseur_tel,@fournisseur_mail)", con);
                    cm.Parameters.AddWithValue("@fournisseur_nom", txtFName.Text);
                    cm.Parameters.AddWithValue("@fournisseur_tel", txtFTel.Text);
                    cm.Parameters.AddWithValue("@fournisseur_mail", txtFMail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("fournisseur bien enregistré");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtFName.Clear();
            txtFTel.Clear(); 
            txtFMail.Clear();
           
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Clear();
            btnAjout.Enabled = true;
            btnModif.Enabled = false;

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (MessageBox.Show("Voulez-vous modiffier les informations de ce fournisseur ?", "Modif Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE fournisseur SET fournisseur_nom = @fournisseur_nom , fournisseur_tel = @fournisseur_tel , fournisseur_mail = @fournisseur_mail WHERE fournisseur_nom LIKE '" + txtFName.Text + "'", con);
                    cm.Parameters.AddWithValue("@fournisseur_nom", txtFName.Text);
                    cm.Parameters.AddWithValue("@fournisseur_tel", txtFTel.Text);
                    cm.Parameters.AddWithValue("@fournisseur_mail", txtFMail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Les informations on bien été modifiées");
                    this.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClick_Click(object sender, EventArgs e)
        {

        }
    }
}
