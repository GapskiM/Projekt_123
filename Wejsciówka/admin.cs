using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Wejsciówka
{
    

    class admin
    {
        private MySqlConnection conDatabase;
        

        public void Usun(string idUsun)
        {
           
            string zapytanie_d = "delete from pytania where ID='" + idUsun + "';";

            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
            conDatabase.Open();
            MySqlCommand command = new MySqlCommand(zapytanie_d, conDatabase);
            command.ExecuteNonQuery();
            conDatabase.Close();
            
        }
        public void Dodaj(string zapytanie_d)
        {
            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
            conDatabase.Open();
            MySqlCommand command = new MySqlCommand(zapytanie_d, conDatabase);
            command.ExecuteNonQuery();
            conDatabase.Close();
        }

    }
}
