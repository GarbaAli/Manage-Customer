using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Login
{
    class login
    {
        Database bd = new Database();


        public bool VerificationDesChamps(string login, string password)
        {
            bd.OpenConnexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE login = @pseudo AND mdp = @mdp", bd.getConnexion);
            cmd.Parameters.AddWithValue("@pseudo", login);
            cmd.Parameters.AddWithValue("@mdp", password);
            cmd.CommandType = CommandType.Text;

            MySqlDataReader resultat = cmd.ExecuteReader();

            

            if (resultat.HasRows)
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
