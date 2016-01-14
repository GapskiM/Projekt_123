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
    public partial class adminUsuwanie : Form
    {
        private MySqlConnection conDatabase;
        private MySqlCommand zapytania;

        public adminUsuwanie()
        {
            InitializeComponent();
        }
        private class Item
        {
            public string Name;
            public string Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        private string licznik()
        {
            string licznik_g;
            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");            // LICZENIE ILOSCI PYTAN Z BAZY
            conDatabase.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM pytania", conDatabase);
            licznik_g = Convert.ToString(command.ExecuteScalar());
            conDatabase.Close();
            return licznik_g;

        }
        private void comboBoxWypelnienie()
        {
            string licznik_g = licznik();

          
                conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
                conDatabase.Open();

                zapytania = conDatabase.CreateCommand();
                zapytania.CommandText = ("SELECT pytanie,ID FROM pytania;");
                zapytania.ExecuteNonQuery();


                MySqlDataReader dr = zapytania.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    string pytanie = Convert.ToString(dr["pytanie"]);
                    string id = Convert.ToString(dr["ID"]);
                    comboBox1.Items.Add(new Item(pytanie, id));
                }
                

                dr.Dispose();

        
        }
        private void adminUsuwanie_Load(object sender, EventArgs e)
        {
            comboBoxWypelnienie();
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Item itm = (Item)comboBox1.SelectedItem;
            string zapytanie_d = "delete from pytania where ID='" + itm.Value + "';";

                conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
                conDatabase.Open();
                MySqlCommand command = new MySqlCommand(zapytanie_d, conDatabase);
                command.ExecuteNonQuery();
                conDatabase.Close();
                MessageBox.Show("Pytanie zostało usunięte!");
            adminUsuwanie aU = new adminUsuwanie();
            aU.Show();
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
}
