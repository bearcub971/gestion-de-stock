using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gestionStock
{
    public partial class FormCategorie : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public FormCategorie()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();      
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Voulez-vous saugader une catégorie ?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO categorie(categorie_nom,categorie_rayon,categorie_descrip)VALUES(@categorie_nom,@categorie_rayon,@categorie_descrip)", con);
                    cm.Parameters.AddWithValue("@categorie_nom", txtCName.Text);
                    cm.Parameters.AddWithValue("@categorie_rayon", txtCRayon.Text);
                    cm.Parameters.AddWithValue("@categorie_descrip", txtCdescription.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Catégorie bien enregistré");
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
            txtCName.Clear();
            txtCRayon.Clear();
            txtCdescription.Clear();

        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Clear();
            btnAjout.Enabled = true;
            btnModif.Enabled = false;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Voulez-vous modiffier les informations de ce fournisseur ?", "Modif Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE categorie SET categorie_nom = @categorie_nom , categorie_rayon = @categorie_rayon , categorie_descrip = @categorie_descrip WHERE categorie_nom LIKE '" + txtCName.Text + "'", con);
                    cm.Parameters.AddWithValue("@categorie_nom", txtCName.Text);
                    cm.Parameters.AddWithValue("@categorie_rayon", txtCRayon.Text);
                    cm.Parameters.AddWithValue("@categorie_descrip", txtCdescription.Text);
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
    }
}
