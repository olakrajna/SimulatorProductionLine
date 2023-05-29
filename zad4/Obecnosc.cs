using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{

    public partial class Obecnosc : Form
    {
        private int timerCount = 0;

        public Obecnosc()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            label2.Text = "Jeżeli nie zrobisz tego w ciągu " + (10 - timerCount).ToString() +
                " sekund,\r\n zostaniesz wylogowany/a z systemu!";
            if (timerCount >= 10)
            {
                Application.Exit();
            }

        }

        private void jestem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
