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


namespace Wejsciówka
{
    public partial class logWindow : Form
    {
        private string conn;
        private MySqlConnection connect;

        public logWindow()
        {
            InitializeComponent();
        }

        private void db_connection()   /// Łączenie z bazą danych
        {
            try
            {
                conn = "Server=localhost;Database=bazadanych123;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        private bool validate_login(string user, string pass)   // sprawdzenie loginu/hasla
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from konta where nazwauzytkownika=@user and haslo=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void loginButton(object sender, EventArgs e)     // Obsługa przycisku zaloguj
        {
            string user = nazwaUzyt.Text;
            string pass = passwd.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Wypełnij poprawnie pola logwania!", "Błąd logowania");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                
                if(user == "admin")
                {
                    adminPanel admin = new adminPanel();     /// Otwarcie panelu Admina
                    admin.Show();
                    this.Hide(); 
                }
                else if (user == "student")
                {
                   wejsciowkaStart ws = new wejsciowkaStart();   /// Otwarcie testu dla studenta
                   ws.Show();
                   this.Hide();

                }

            }
            else
                MessageBox.Show("Podaj poprawne dane logowania!", "Błąd logowania");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();  // zamkniecie aplikacji
        }
    }
}