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


namespace gestionStock
{
    public partial class Fournisseurs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Fournisseurs()
        {
            InitializeComponent();
            LoadFournisseur();
        }
        public void LoadFournisseur()
        {
            int i = 0;
            dgvFournisseur.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM fournisseur", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvFournisseur.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            FormFournisseur formFournisseur = new FormFournisseur();
            formFournisseur.btnAjout.Enabled = true;
            formFournisseur.btnModif.Enabled = false;
            formFournisseur.ShowDialog();
            LoadFournisseur();
        }

        private void dgvFournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvFournisseur.Columns[e.ColumnIndex].Name;
            if (colName == "Modif")
            {
                FormFournisseur formFournisseur = new FormFournisseur();
                formFournisseur.labelClick.Text = dgvFournisseur.Rows[e.RowIndex].Cells[1].Value.ToString();
                formFournisseur.txtFName.Text = dgvFournisseur.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                formFournisseur.txtFTel.Text = dgvFournisseur.Rows[e.RowIndex].Cells[3].Value.ToString();
                formFournisseur.txtFMail.Text = dgvFournisseur.Rows[e.RowIndex].Cells[4].Value.ToString();

                formFournisseur.btnAjout.Enabled = false;
                formFournisseur.btnModif.Enabled = true;
                formFournisseur.txtFName.Enabled = false;
                formFournisseur.ShowDialog();

            }
            else if (colName == "Sup")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce fournisseur", "Sup Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM fournisseur WHERE fournisseur_Id LIKE '" + dgvFournisseur.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Le fournisseur a bien été supprimer!");
                }
            }
            LoadFournisseur();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
