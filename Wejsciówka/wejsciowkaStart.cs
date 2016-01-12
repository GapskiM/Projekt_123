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
                         
            conDatabase = new MySqlConnection("SERVER=localhost;DataBase=bazadanych123;UserId=root; PWD=;");
            conDatabase.Open();

            zapytania = conDatabase.CreateCommand();
            zapytania.CommandText = ("SELECT pytanie, poprawna_odp, druga_odp, trzecia_odp, czwarta_odp FROM pytania WHERE ID='" + id + "';");
            zapytania.ExecuteNonQuery();
            

            MySqlDataReader dr = zapytania.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
                                                                                             // odczyt zmiennych z bazy danych
            string pytanie = Convert.ToString(dr["pytanie"]);
            string poprawna_odp = Convert.ToString(dr["poprawna_odp"]);
            string druga_odp = Convert.ToString(dr["druga_odp"]);
            string trzecia_odp = Convert.ToString(dr["trzecia_odp"]);
            string czwarta_odp = Convert.ToString(dr["czwarta_odp"]);
            string[] tab = { pytanie, poprawna_odp, druga_odp, trzecia_odp, czwarta_odp };    // przypisanie tych zmiennych do tablicy
            return tab;
            

        }

        private int LosujPytanie()                  // losowanie pytania
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
               
                string odpowiedz = "";
           
                    // sprawdzanie ktory radiobutton zostal zaznaczony
            if (radioButton1.Checked == true) odpowiedz = radioButton1.Text;
           
            else if (radioButton2.Checked == true) odpowiedz = radioButton2.Text;
           
            else if (radioButton3.Checked == true) odpowiedz = radioButton3.Text;
          
            else if (radioButton4.Checked == true) odpowiedz = radioButton4.Text;
          

           

            if (odpowiedz == tab[1].ToString())   // sprawdzenie poprawnosci odp
                {
                    iloscPoprOdp++;
                    LosujPytanie();                                // losowanie kolejnego pytania
                    int nrid = LosujPytanie();                    // zmienna z nr pytania
                    ktorePyt++;                                  // zliczanie ilosci pytan

                    labelNrPyt.Text = nrid.ToString();          
                    labelKtorePyt.Text = ktorePyt.ToString();
                 }   
                else
                {
                
                    LosujPytanie();
                    int nrid = LosujPytanie();
                    ktorePyt++;
                    labelNrPyt.Text = nrid.ToString();
                    labelKtorePyt.Text = ktorePyt.ToString();
                 }

            if (ktorePyt == 6)                  //sprawdzenie ilosci pytan
            {
             
                wynik frm = new wynik(iloscPoprOdp.ToString());
                frm.Show();
                this.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
