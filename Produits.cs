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
    public partial class Produits : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Produits()
        {
            InitializeComponent();
            LoadProduit();

        }

        public void LoadProduit()
        {
            int i = 0;
            dgvProduit.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM produit WHERE CONCAT(produit_Id, produit_nom,produit_qte,produit_prix,produit_des,produit_cat) LIKE'%"+txtSearch.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduit.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProduit formCategorie = new FormProduit();
            formCategorie.btnAjout.Enabled = true;
            formCategorie.btnModif.Enabled = false;
            formCategorie.ShowDialog();
            LoadProduit();
        }

        private void dgvProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //char action = 'a';

            string colName = dgvProduit.Columns[e.ColumnIndex].Name;
            if (colName == "Modif")
            {

                FormProduit formProduit = new FormProduit();
                formProduit.idP.Text = dgvProduit.Rows[e.RowIndex].Cells[1].Value.ToString();
                formProduit.txtNameP.Text = dgvProduit.Rows[e.RowIndex].Cells[2].Value.ToString();
                formProduit.txtQté.Text = dgvProduit.Rows[e.RowIndex].Cells[3].Value.ToString();
                formProduit.txtPrix.Text = dgvProduit.Rows[e.RowIndex].Cells[4].Value.ToString();
                formProduit.txtDes.Text = dgvProduit.Rows[e.RowIndex].Cells[5].Value.ToString();
                formProduit.comboBoxCat.Text = dgvProduit.Rows[e.RowIndex].Cells[6].Value.ToString();

                formProduit.btnAjout.Enabled = false;
                formProduit.btnModif.Enabled = true;
                formProduit.ShowDialog();

            }
            else if (colName == "Sup")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce produit", "Sup Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM produit WHERE produit_Id LIKE '" + dgvProduit.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Le Produit a bien été supprimer!");
                }
            }
            LoadProduit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduit();
        }
    }
}
