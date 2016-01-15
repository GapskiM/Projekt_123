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
    public partial class adminDodawanie : Form
    {
        private MySqlConnection conDatabase;
        private MySqlCommand zapytania;

        public adminDodawanie()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()    // metoda do czyszczenia pól formularza
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonDodajPyt_Click(object sender, EventArgs e)
        {
            if ((this.boxPytanie.Text.Length != 0) && (this.boxPoprOdp.Text.Length != 0) && (this.boxDrugaOdp.Text.Length != 0) &&   // sprawdzenie czy pola nie są puste
               (this.boxTrzeciaOdp.Text.Length != 0) && (this.boxCzwartaOdp.Text.Length != 0))
            {

                string zapytanie_d = "INSERT INTO pytania (pytanie, poprawna_odp, druga_odp, trzecia_odp, czwarta_odp) "    // zapytanie do bazy (dodajace pytanie)
                + "VALUES ('" + boxPytanie.Text + "', '" + boxPoprOdp.Text + "', '"
                + boxDrugaOdp.Text + "', '" + boxTrzeciaOdp.Text + "', '" + boxCzwartaOdp.Text + "');";

                admin admin = new admin();
                admin.Dodaj(zapytanie_d);

                MessageBox.Show("Twoje pytanie zostało poprawnie dodane do bazy danych");
                 ClearTextBoxes();   // Czyści pola formularza po poprawnym dodaniu pytania!
              
            }
            else
            {
                MessageBox.Show("Wszystkie rubryki muszą być wypełnione!");
            }

        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Application.Restart();    // Powrót do logowania po kliknięciu "zamknij"
        }
    }
}
