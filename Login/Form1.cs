using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Instance de la classe Login
        login lg = new login();

        //Instance de la base de donnee
        Database bd = new Database();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsFormValid()){
                    if (lg.VerificationDesChamps(txtLogIn.Text, txtMdp.Text))
                    {
                        home hm = new home();
                        this.Hide();
                        hm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe Incorrect","Log In",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Verifie les champs
        private bool IsFormValid()
        {
            if(txtLogIn.Text.Trim() == string.Empty){
                MessageBox.Show("Le Login est requis!","Erreur de Login");
                return false;
            }
            if (txtMdp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Le Mot de pass est requis!", "Erreur de Password");
                return false;
            }
            return true;
        }
         
       



    }
}
