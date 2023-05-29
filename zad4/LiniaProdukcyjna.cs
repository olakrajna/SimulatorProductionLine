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
    public partial class LiniaProdukcyjna : Form
    {
        private int timerCount = 0;

        public LiniaProdukcyjna()
        {
            InitializeComponent();
            btnWlaczSilnik.Enabled = false;
            btnWlaczWentylator.Enabled = false;
            btnWylaczSilnik.Enabled = false;
            btnWylaczWentylator.Enabled = false;
            btnNapraw.Enabled = false;  
            btnWyloguj.Enabled = false;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fun == true)
            {
                if (xb == true)
                {
                    xb = false; ;
                    this.pictureBox4.Load("tasma1.png");
                    this.pictureBox5.Load("went1.png");
                }
                else
                {
                    xb = true;
                    this.pictureBox4.Load("tasma2.png");
                    this.pictureBox5.Load("went2.png");
                    timerCount++;
                }

                if (timerCount == 20) {

                    this.pictureBox6.Load("szara.png");
                    MessageBox.Show("Zmniejsz temperature do 5, a następnie wyłącz wentylator.");

                }
            }
            else
            {
                
                if (xb == true)
                {
                xb = false; ;
                this.pictureBox4.Load("tasma1.png");

                }
                else
                {
                xb = true;
                this.pictureBox4.Load("tasma2.png");

                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Stop();
            presence = false;
            new Obecnosc().Show();            
            this.pictureBox2.Load("zolta.png");
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if(fun_error == false && presence == true && engine == true)
            {
                this.pictureBox2.Load("szara.png");
            }
            else if (fun_error == true)
            {
                this.timer3.Stop();
                this.pictureBox2.Load("zolta.png");                
                MessageBox.Show("Włącz wentylator");
            }

            if(malfunction == false)
            {
                this.pictureBox3.Load("szara.png");
                
            }
            else
            {
                this.timer3.Stop();
                this.pictureBox1.Load("szara.png");
                this.pictureBox2.Load("szara.png");
                this.pictureBox6.Load("szara.png");
                this.pictureBox3.Load("czerwona.png");
                this.timer1.Stop();
                this.timer2.Stop();
                engine = false;
                MessageBox.Show("Awaria Silnika. Napraw silnik. Zostałeś wylogowany.");
            }

            if (this.trackBar1.Value >= 6 && this.trackBar1.Value < 10 && fun == false)
            {
                this.pictureBox6.Load("pomaranczowa.png");                
                
            }


            if (this.trackBar1.Value >= 6 && fun == false)
            {
                fun_error = true;
            }           

            if (this.trackBar1.Value == 10)
            {
                malfunction = true;
            }
        }

       
        private void napraw_Click(object sender, EventArgs e)
        {

            if (malfunction == true)
            {
                malfunction = false;
                fun_error = false;
                this.trackBar1.Value = 0;
                this.timer3.Start();
                fun = false;

            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Okno2 = new NoweOkno(this);
            this.Okno2.Show();            
           
        }

        private void wlaczSilnik_Click(object sender, EventArgs e)
        {
            if (presence == true && login == true)
            {
                this.pictureBox1.Load("zielona.png");
                this.timer1.Start();
                this.timer3.Start();
                engine = true;
            }
            else
            {
                MessageBox.Show("Brak Uzytkownika.");
            }
        }

        private void wylaczSilnik_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load("szara.png");
            this.pictureBox2.Load("szara.png");
            this.pictureBox3.Load("szara.png");
            this.pictureBox6.Load("szara.png");
            this.timer1.Stop();
            engine = false;
            fun = false;
        }

        private void obecnosc_Click(object sender, EventArgs e)
        {
            if (login == true)
            {
                presence = true;
                this.timer2.Start();
                this.pictureBox2.Load("szara.png");
                MessageBox.Show("Obecność potwierdzona. Włącz silnik.");
                btnWlaczSilnik.Enabled = true;
                btnWlaczWentylator.Enabled = true;
                btnWylaczSilnik.Enabled = true;
                btnWylaczWentylator.Enabled = true;
                btnNapraw.Enabled = true;
                btnWyloguj.Enabled = true;
            }
            else 
            {

                MessageBox.Show("Zaloguj się!");
            }
        }

        private void wyloguj_Click(object sender, EventArgs e)
        {
            login = false;
        }

        private void wlaczWentylator_Click(object sender, EventArgs e)
        {
            fun = true;
            fun_error = false;
            this.timer3.Start();
        }

        private void wylaczWentylator_Click(object sender, EventArgs e)
        {
            fun = false;
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
