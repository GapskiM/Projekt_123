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
        private void adminUsuwanie_Load(object sender, EventArgs e)
        {
            string licznik_g;
            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");            // LICZENIE ILOSCI PYTAN Z BAZY
            conDatabase.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM pytania", conDatabase);
            licznik_g = Convert.ToString(command.ExecuteScalar());
            conDatabase.Close();



            for (int i = 1; i <= int.Parse(licznik_g); i++)
            {
                conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
                conDatabase.Open();

                zapytania = conDatabase.CreateCommand();
                zapytania.CommandText = ("SELECT pytanie FROM pytania WHERE ID='" + i + "';");
                zapytania.ExecuteNonQuery();


                MySqlDataReader dr = zapytania.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();

                string pytanie = Convert.ToString(dr["pytanie"]);
                comboBox1.Items.Add(new Item(pytanie, i.ToString()));

                
            }
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
                // adminPanel admin = new adminPanel();
                //  admin.Show();
                //this.Close();
            }
        }

       
}
