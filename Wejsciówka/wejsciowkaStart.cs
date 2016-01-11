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
        int iloscPoprOdp = 0;

        public wejsciowkaStart()
        {
            InitializeComponent();
            
        }
        private string[] zapytanieDB(int id)
        {
          

            
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

        private int LosujPytanie()
        {
            Random random = new Random();
            int id = random.Next(1, 5);
            string[] tab = zapytanieDB(id);

            this.labelPytanie.Text = tab[0];




            int rone = 0, rtwo = 0, rthree = 0, rfour = 0;

            //losowanie, źródło losowania: http://www.algorytm.org/liczby-pseudolosowe/losowanie-bez-powtorzen.html

            Random rand = new Random();
            int n = 4;
            int k = 4;
            // wypełnianie tablicy liczbami 1,2...n
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = i + 1;
            // losowanie k liczb

            for (int i = 0; i < k; i++)
            {
                // tworzenie losowego indeksu pomiędzy 0 i n - 1
                int r = rand.Next(n);

                if (i == 0) rone = numbers[r];
                else if (i == 1) rtwo = numbers[r];
                else if (i == 2) rthree = numbers[r];
                else if (i == 3) rfour = numbers[r];

                // przeniesienia ostatniego elementu do miejsca z którego wzięliśmy
                numbers[r] = numbers[n - 1];
                n--;
            }

            this.radioButton1.Text = tab[rone];
            this.radioButton2.Text = tab[rtwo];
            this.radioButton3.Text = tab[rthree];
            this.radioButton4.Text = tab[rfour];

            return id;
          
        }

        private void wejsciowkaStart_Load(object sender, EventArgs e)
        {
          
            int id = LosujPytanie();
            int ktorePyt = 1;
            labelNrPyt.Text = id.ToString();
            labelKtorePyt.Text = ktorePyt.ToString();
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

       


        private void zatwierdz_Click(object sender, EventArgs e)
        {

            int id = int.Parse(labelNrPyt.Text);
            int ktorePyt = int.Parse(labelKtorePyt.Text);
            string[] tab = zapytanieDB(id);
                //  randomowy uklad odpowiedzi, punktacja, ew czas,
                string odpowiedz = "";
            // sprawdzanie ktory radiobutton zostal zaznaczony
            if (radioButton1.Checked == true)
            {
                odpowiedz = radioButton1.Text;
                MessageBox.Show(radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                odpowiedz = radioButton2.Text;
                MessageBox.Show(radioButton2.Text);
                MessageBox.Show(tab[1].ToString());

            }
            else if (radioButton3.Checked == true)
            {
                odpowiedz = radioButton3.Text;
                MessageBox.Show(radioButton3.Text);
                
            }
            else if (radioButton4.Checked == true)
            {
                odpowiedz = radioButton4.Text;
                MessageBox.Show(radioButton4.Text);

            }

           

            if (odpowiedz == tab[1].ToString())   // sprawdzenie poprawnosci odp
                {
                    iloscPoprOdp++;
                    MessageBox.Show("Poprawna odpowiedź");
                    MessageBox.Show("ilosc odpowiedzi poprawnych: " + iloscPoprOdp);
                    
                     LosujPytanie();
                     int nrid = LosujPytanie();
                
                ktorePyt++;
                labelNrPyt.Text = nrid.ToString();
                labelKtorePyt.Text = ktorePyt.ToString();
            }   
                else
                {
                    MessageBox.Show("Błędna odpowiedź");
                LosujPytanie();
                int nrid = LosujPytanie();

                ktorePyt++;
                labelNrPyt.Text = nrid.ToString();
                labelKtorePyt.Text = ktorePyt.ToString();
            }

            if (ktorePyt == 6)
            {
                MessageBox.Show("Twoj wynik to: " + iloscPoprOdp + "/" + "5. " + "Gratulacje!");
                Application.Restart();
                // Do zrobienia:
                // Przeslij dane do nastepnego formularza!! zakonczenie + random pytan nowy
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
