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
    public partial class UserForm1 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm1()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i=0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM utilisateur", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.btnSup.Enabled = true;
            formUser.btnModif.Enabled = false;
            formUser.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Modif")
            {
                FormUser formUser = new FormUser();
                formUser.txtName.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                formUser.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                formUser.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                formUser.txtTel.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                formUser.txtMail.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                formUser.btnAjout.Enabled = false;
                formUser.btnModif.Enabled = true;
                formUser.txtName.Enabled = false;
                formUser.ShowDialog();

            }
            else if (colName == "Sup")
            {
                if(MessageBox.Show("Voulez-vous vraiment supprimer cette utilisateur","Sup Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM utilisateur WHERE nomutilisateur LIKE '" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record a bien été supprimer!");
                }
            }
            LoadUser();
        }

    }
}
