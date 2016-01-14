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
    public partial class adminPanel : Form
    {
        


        public adminPanel()
        {
            InitializeComponent();
        }
        
       

        private void adminPanel_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminDodawanie ad = new adminDodawanie();
            ad.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminUsuwanie au = new adminUsuwanie();
            au.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

            
        
    
    


