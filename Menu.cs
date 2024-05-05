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
    public partial class MenuForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\971cy\OneDrive\Documents\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public MenuForm()
        {
            InitializeComponent();
        }

        //Pour afficher le formulaire de sous-formulaire dans le formulaire principal
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelUser.Controls.Add(childForm);
            panelUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        
        
        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm1());
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            openChildForm(new Fournisseurs());
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            openChildForm(new Categorie());
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            openChildForm(new Produits());
        }

        private void customerButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Main());

        }

          }
}
