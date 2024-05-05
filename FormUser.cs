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
    public partial class FormUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public FormUser()
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
                if(txtPass.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Mots de passe incorrecte", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Voulez-vous saugader un utilisateur ?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO utilisateur(nomutilisateur,nomprenom,password,tel,mail)VALUES(@nomutilisateur,@nomprenom,@password,@tel,@mail)", con);
                    cm.Parameters.AddWithValue("@nomutilisateur",txtName.Text);
                    cm.Parameters.AddWithValue("@nomprenom", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.Parameters.AddWithValue("@tel", txtTel.Text);
                    cm.Parameters.AddWithValue("@mail", txtMail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("utilisateur bien enregistré");
                    Clear();

                }
            }
            catch(Exception ex)
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
            txtName.Clear();
            txtFullName.Clear(); 
            txtPass.Clear();
            txtConfirm.Clear();
            txtTel.Clear(); 
            txtMail.Clear();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Mots de passe incorrecte", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Voulez-vous modiffier les informations de cette utilisateur ?", "Modif Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE utilisateur SET nomutilisateur = @nomutilisateur , nomprenom = @nomprenom , password = @password , tel = @tel , mail = @mail WHERE nomutilisateur LIKE '"+txtName.Text+"'", con);
                    cm.Parameters.AddWithValue("@nomutilisateur", txtName.Text);
                    cm.Parameters.AddWithValue("@nomprenom", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.Parameters.AddWithValue("@tel", txtTel.Text);
                    cm.Parameters.AddWithValue("@mail", txtMail.Text);
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
