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
    public partial class wejsciowkaStart : Form
    {
        private MySqlConnection conDatabase;    // połączenie
        private MySqlCommand zapytania;         // zapytanie



        public wejsciowkaStart()
        {
            InitializeComponent();

        }
        private string[] zapytanieDB(int numerpytania)
        {
            int id = numerpytania;    // randomowe ID trzeba ogarnąć, do losowania pytań!
                           //  trzeba bedzie zrobic petle i= ilosc pytan i wtedy losowo id + zliczanie pkt z odpowiedzi i może czas
            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
            conDatabase.Open();

            zapytania = conDatabase.CreateCommand();
            zapytania.CommandText = ("SELECT pytanie, poprawna_odp, druga_odp, trzecia_odp, czwarta_odp FROM pytania WHERE ID='" + id + "';");
            zapytania.ExecuteNonQuery();

            MySqlDataReader dr = zapytania.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            string pytanie = Convert.ToString(dr["pytanie"]);
            string poprawna_odp = Convert.ToString(dr["poprawna_odp"]);
            string druga_odp = Convert.ToString(dr["druga_odp"]);
            string trzecia_odp = Convert.ToString(dr["trzecia_odp"]);
            string czwarta_odp = Convert.ToString(dr["czwarta_odp"]);
            string[] tab = { pytanie, poprawna_odp, druga_odp, trzecia_odp, czwarta_odp };
            return tab;
            
        }

        private void wejsciowkaStart_Load(object sender, EventArgs e)
        {
            string[] tab = zapytanieDB(1);   // zmienic 1 na nazwe zemiennej od losowania
            
            this.labelPytanie.Text = tab [0];
            this.radioButton1.Text = tab [1];
            this.radioButton2.Text = tab [2];
            this.radioButton3.Text = tab [3];
            this.radioButton4.Text = tab [4];

            // randomowe losowanie pytan, randomowy uklad odpowiedzi, punktacja, ew czas,

        }

        private void boxWyswPyt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void labelPytanie_Text(object sender, EventArgs e)
        {
           
        }

        private void ButtonAnuluj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
