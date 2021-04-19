using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Login
{
    class Database
    {
        
        //Connexion a la base de donnee

        private MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=tpsharp;UID=root;PASSWORD=;");

        public MySqlConnection getConnexion
        {
            get { return con; }  
        }

        // Ouveture de la connexion
        public void OpenConnexion()
        {
           if(con.State == ConnectionState.Closed){
               con.Open();
           }
        }

        //Fermeture de la connexion
        public void CloseConnexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
