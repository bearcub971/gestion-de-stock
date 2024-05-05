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
    public partial class Categorie : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader  dr;

        public Categorie()
        {
            InitializeComponent();
            LoadCategorie();

        }


        public void LoadCategorie()
        {
            int i = 0;
            dgvCategorie.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM categorie", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategorie.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategorie formCategorie = new FormCategorie();
            formCategorie.btnAjout.Enabled = true;
            formCategorie.btnModif.Enabled = false;
            formCategorie.ShowDialog();
            LoadCategorie();
        }

        private void dgvCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategorie.Columns[e.ColumnIndex].Name;
            if (colName == "Modif")
            {
                FormCategorie formCategorie = new FormCategorie();
                formCategorie.lCid.Text = dgvCategorie.Rows[e.RowIndex].Cells[1].Value.ToString();
                formCategorie.txtCName.Text = dgvCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                formCategorie.txtCRayon.Text = dgvCategorie.Rows[e.RowIndex].Cells[3].Value.ToString();
                formCategorie.txtCdescription.Text = dgvCategorie.Rows[e.RowIndex].Cells[4].Value.ToString();

                formCategorie.btnAjout.Enabled = false;
                formCategorie.btnModif.Enabled = true;
                formCategorie.txtCName.Enabled = false;
                formCategorie.ShowDialog();

            }
            else if (colName == "Sup")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette catégorie", "Sup Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM categorie WHERE categorie_Id LIKE '" + dgvCategorie.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("La catégorie a bien été supprimer!");
                }
            }
            LoadCategorie();
        }
    }
}
