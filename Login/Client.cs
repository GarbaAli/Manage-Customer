using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Login
{
    class Client
    {
       
        //Importation de la bd
        Database bd = new Database();

        //Ajouter client
        


        public bool AjouterClient(string nom, string age, string phone, string adresse, string status)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `client` (`nom_prenom_clt`, `age`, `phone`, `Adresse`, `status`) VALUES (@nom, @age, @phone, @adresse, @status)", bd.getConnexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@status", status);

            bd.OpenConnexion();

            if (cmd.ExecuteNonQuery() == 1)
            {
                bd.CloseConnexion();
                return true;
            }
            else
            {
                bd.CloseConnexion();
                return false;
            }
        }

        public bool DeleteClient(string id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `client` WHERE `client`.`id_clt` = @id", bd.getConnexion);
            cmd.Parameters.AddWithValue("@id", id);

            bd.OpenConnexion();

            if (cmd.ExecuteNonQuery() == 1)
            {
                bd.CloseConnexion();
                return true;
            }
            else
            {
                bd.CloseConnexion();
                return false;
            }
        }

        public bool UpdateClient(string id, string nom, string age, string phone, string adresse, string status)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `client` SET `nom_prenom_clt` = @nom, `age` = @age, `phone` = @phone, `Adresse` = @adresse, `status` = @status WHERE `client`.`id_clt` = @id", bd.getConnexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@status", status);

            bd.OpenConnexion();

            if (cmd.ExecuteNonQuery() == 1)
            {
                bd.CloseConnexion();
                return true;
            }
            else
            {
                bd.CloseConnexion();
                return false;
            }       
        }

      
    }
}
