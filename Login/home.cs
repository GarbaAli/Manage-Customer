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
using System.Runtime.InteropServices;


namespace Login
{
    public partial class home : Form
    {
        char caractere , lettre;
        MySqlDataReader result;
        string id;


        public home()
        {
            InitializeComponent();
        }

        //Importation de la bd
        Database bd = new Database();
        

       

        private bool IsFormValid()
        {
            if (txtNom.Text.Trim() == string.Empty)
            {
                ErrorNom.Visible = true;
                return false;
            }
            else
            {
                ErrorNom.Visible = false;
            }

            if (txtAge.Text.Trim() == string.Empty)
            {
                ErrorAge.Visible = true;
                return false;
            }
            else { ErrorAge.Visible = false; }

            if (txtPhone.Text.Trim() == string.Empty)
            {
                ErrorPhone.Visible = true;
                return false;
            }
            else { ErrorPhone.Visible = false; }

            if (txtAdresse.Text.Trim() == string.Empty)
            {
                ErrorAdresse.Visible = true;
                return false;
            }
            else { ErrorAdresse.Visible = false; }

            return true;
        }

        //Importation de la classe Client
        Client client = new Client();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(IsFormValid()){
                if (client.AjouterClient(txtNom.Text, txtAge.Text, txtPhone.Text, txtAdresse.Text, cbxStatut.Text))
                {
                    MessageBox.Show(txtNom.Text + " Ajouté  avec Success", "Ajout Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNom.Clear();
                    txtPhone.Clear();
                    txtAge.Clear();
                    txtAdresse.Clear();
                    cbxStatut.SelectedIndex = 0;

                    SelectClient();

                }
                else
                {
                    MessageBox.Show(txtNom.Text + " Erreur lors de l'insertion du client", "Ajout Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Contrainte qui ne  lit que les chiffres
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
             caractere = e.KeyChar;
            if (!char.IsDigit(caractere) && caractere != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
             lettre = e.KeyChar;
             if (!char.IsDigit(lettre) && lettre != '+' && lettre != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            SelectClient();
        }

        //Afficher les clients
        private void SelectClient()
        {
            try
            {
                bd.OpenConnexion();

            tableauClient.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM client", bd.getConnexion);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                tableauClient.Rows.Add(result.GetValue(0).ToString(), result.GetValue(1).ToString(), result.GetValue(2).ToString(), result.GetValue(3).ToString(), result.GetValue(4).ToString(), result.GetValue(5).ToString());
            }
            result.Close();
            bd.CloseConnexion();
          
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message ,"Erreur Innatendue");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tableauClient.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment suprimmer ce Client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = tableauClient.CurrentRow.Cells["id_clt"].Value.ToString();
                    string nom = tableauClient.CurrentRow.Cells["nom_prenom_clt"].Value.ToString();

                    if (client.DeleteClient(id))
                    {
                        MessageBox.Show(nom + " Supprimer  avec Success", "Suppression Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectClient();
                    }
                    else
                    {
                        MessageBox.Show(" Erreur lors de la Suppression de" + nom, "Suppression Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
        }


        //Boutton d'arret du programme
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           if (tableauClient.SelectedRows.Count > 0)
           {
               txtNom.Text  = tableauClient.CurrentRow.Cells["nom_prenom_clt"].Value.ToString();
               txtAge.Text  = tableauClient.CurrentRow.Cells["age"].Value.ToString();
               txtPhone.Text  = tableauClient.CurrentRow.Cells["phone"].Value.ToString();
               txtAdresse.Text  = tableauClient.CurrentRow.Cells["Adresse"].Value.ToString();
               cbxStatut.Text  = tableauClient.CurrentRow.Cells["status"].Value.ToString();
               id  = tableauClient.CurrentRow.Cells["id_clt"].Value.ToString();

               btnUpdateClt.Visible = true;
               btnUpdate.Enabled = false;

           }
        }

        private void btnUpdateClt_Click(object sender, EventArgs e)
        {
            try
            {
                 if (IsFormValid())
            {
                if (client.UpdateClient(id, txtNom.Text, txtAge.Text, txtPhone.Text, txtAdresse.Text, cbxStatut.Text))
                {
                    MessageBox.Show(txtNom.Text + " Modifié  avec Success", "Modification Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNom.Clear();
                    txtPhone.Clear();
                    txtAge.Clear();
                    txtAdresse.Clear();
                    cbxStatut.SelectedIndex = 0;
                    SelectClient();

                    btnUpdateClt.Visible = false;
                    btnUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show(txtNom.Text + " Erreur lors de la Modification du client", "Modifier Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Erreur d'insertion");
            }
        }

        //permet de faire swinger la page
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown_2(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}



 