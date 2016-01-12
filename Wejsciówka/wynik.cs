using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wejsciówka
{
    public partial class wynik : Form
    {
        public wynik(string strlabelWynik)
        {
            InitializeComponent();
            labelWynik.Text = strlabelWynik;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPowtorz_Click(object sender, EventArgs e)
        {
            wejsciowkaStart ws = new wejsciowkaStart();   // rozpoczęcie nowego testu
            ws.Show();
            this.Close();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logWindow lw = new logWindow();    // powrot do logowania
            lw.Show();
            this.Close();
        }
    }
}
