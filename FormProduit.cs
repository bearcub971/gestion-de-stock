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
using System.Xml.Linq;

namespace gestionStock
{
    public partial class FormProduit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FormProduit()
        {
            InitializeComponent();
            LoadCategorie();
            
        }


        public void LoadCategorie()
        {
            comboBoxCat.Items.Clear();
            cm = new SqlCommand("SELECT categorie_nom FROM categorie", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (MessageBox.Show("Voulez-vous saugader un Produit ?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO produit(produit_nom,produit_qte,produit_prix,produit_des,produit_cat)VALUES(@produit_nom,@produit_qte,@produit_prix,@produit_des,@produit_cat)", con);
                    cm.Parameters.AddWithValue("@produit_nom", txtNameP.Text);
                    cm.Parameters.AddWithValue("@produit_qte", Convert.ToInt16(txtQté.Text));
                    cm.Parameters.AddWithValue("@produit_prix", Convert.ToInt16(txtPrix.Text));
                    cm.Parameters.AddWithValue("@produit_des", txtDes.Text);
                    cm.Parameters.AddWithValue("@produit_cat", comboBoxCat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produit bien enregistré");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Clear();
            btnAjout.Enabled = true;
            btnModif.Enabled = false;
        }

        public void Clear()
        {
            txtNameP.Clear();
            txtQté.Clear();
            txtPrix.Clear();
            txtDes.Clear();
            comboBoxCat.Text = "";
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show("Voulez-vous modiffier les informations de ce produit ?", "Modif Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE produit SET produit_nom = @produit_nom , produit_qte = @produit_qte , produit_prix = @produit_prix , produit_des = @produit_des, produit_cat = @produit_cat WHERE produit_nom LIKE '" + txtNameP.Text + "'", con);
                    cm.Parameters.AddWithValue("@produit_nom", txtNameP.Text);
                    cm.Parameters.AddWithValue("@produit_qte", txtQté.Text);
                    cm.Parameters.AddWithValue("@produit_prix", txtPrix.Text);
                    cm.Parameters.AddWithValue("@produit_des", txtDes.Text);
                    cm.Parameters.AddWithValue("@produit_cat", comboBoxCat.Text);

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
