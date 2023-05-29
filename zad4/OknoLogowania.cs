﻿using System;
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
    public partial class NoweOkno : Form
    {

        private const string login = "1234";
        private const string haslo = "1234";

        public NoweOkno()
        {
            InitializeComponent();
            this.OknoRodzic = null;
        }
        public NoweOkno(LiniaProdukcyjna OknoRodz)
        {
            InitializeComponent();
            this.OknoRodzic = OknoRodz;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zalogujBtn_Click(object sender, EventArgs e)
        {
            if (login.Equals(textBox1.Text) && haslo.Equals(textBox2.Text))
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                this.OknoRodzic.login = true;
               
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Błędne dane logowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
