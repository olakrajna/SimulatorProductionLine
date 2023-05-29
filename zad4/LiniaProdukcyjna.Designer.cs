
namespace zad4
{
    partial class LiniaProdukcyjna
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private bool xb;
        private bool presence = false;
        private bool malfunction = false;
        private bool fun = false;
        private bool fun_error = false;
        private bool engine = false;
        public bool login = false;
        private NoweOkno Okno2;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnWlaczSilnik = new System.Windows.Forms.Button();
            this.btnWylaczSilnik = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnObecnosc = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnNapraw = new System.Windows.Forms.Button();
            this.btnWlaczWentylator = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnWylaczWentylator = new System.Windows.Forms.Button();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWlaczSilnik
            // 
            this.btnWlaczSilnik.Location = new System.Drawing.Point(605, 153);
            this.btnWlaczSilnik.Margin = new System.Windows.Forms.Padding(4);
            this.btnWlaczSilnik.Name = "btnWlaczSilnik";
            this.btnWlaczSilnik.Size = new System.Drawing.Size(111, 28);
            this.btnWlaczSilnik.TabIndex = 0;
            this.btnWlaczSilnik.Text = "Włącz Silnik";
            this.btnWlaczSilnik.UseVisualStyleBackColor = true;
            this.btnWlaczSilnik.Click += new System.EventHandler(this.wlaczSilnik_Click);
            // 
            // btnWylaczSilnik
            // 
            this.btnWylaczSilnik.Location = new System.Drawing.Point(724, 153);
            this.btnWylaczSilnik.Margin = new System.Windows.Forms.Padding(4);
            this.btnWylaczSilnik.Name = "btnWylaczSilnik";
            this.btnWylaczSilnik.Size = new System.Drawing.Size(111, 28);
            this.btnWylaczSilnik.TabIndex = 4;
            this.btnWylaczSilnik.Text = "Wyłącz Silnik";
            this.btnWylaczSilnik.UseVisualStyleBackColor = true;
            this.btnWylaczSilnik.Click += new System.EventHandler(this.wylaczSilnik_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnObecnosc
            // 
            this.btnObecnosc.Location = new System.Drawing.Point(713, 78);
            this.btnObecnosc.Margin = new System.Windows.Forms.Padding(4);
            this.btnObecnosc.Name = "btnObecnosc";
            this.btnObecnosc.Size = new System.Drawing.Size(111, 28);
            this.btnObecnosc.TabIndex = 6;
            this.btnObecnosc.Text = "Obecność";
            this.btnObecnosc.UseVisualStyleBackColor = true;
            this.btnObecnosc.Click += new System.EventHandler(this.obecnosc_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(121, 471);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(303, 56);
            this.trackBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperatura Silnika";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnNapraw
            // 
            this.btnNapraw.Location = new System.Drawing.Point(605, 241);
            this.btnNapraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnNapraw.Name = "btnNapraw";
            this.btnNapraw.Size = new System.Drawing.Size(230, 28);
            this.btnNapraw.TabIndex = 9;
            this.btnNapraw.Text = "Napraw";
            this.btnNapraw.UseVisualStyleBackColor = true;
            this.btnNapraw.Click += new System.EventHandler(this.napraw_Click);
            // 
            // btnWlaczWentylator
            // 
            this.btnWlaczWentylator.Location = new System.Drawing.Point(605, 189);
            this.btnWlaczWentylator.Margin = new System.Windows.Forms.Padding(4);
            this.btnWlaczWentylator.Name = "btnWlaczWentylator";
            this.btnWlaczWentylator.Size = new System.Drawing.Size(100, 44);
            this.btnWlaczWentylator.TabIndex = 10;
            this.btnWlaczWentylator.Text = "Włącz Wentylator";
            this.btnWlaczWentylator.UseVisualStyleBackColor = true;
            this.btnWlaczWentylator.Click += new System.EventHandler(this.wlaczWentylator_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(605, 78);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.login_Click);
            // 
            // btnWylaczWentylator
            // 
            this.btnWylaczWentylator.Location = new System.Drawing.Point(724, 190);
            this.btnWylaczWentylator.Margin = new System.Windows.Forms.Padding(4);
            this.btnWylaczWentylator.Name = "btnWylaczWentylator";
            this.btnWylaczWentylator.Size = new System.Drawing.Size(111, 43);
            this.btnWylaczWentylator.TabIndex = 13;
            this.btnWylaczWentylator.Text = "Wyłącz Wentylator";
            this.btnWylaczWentylator.UseVisualStyleBackColor = true;
            this.btnWylaczWentylator.Click += new System.EventHandler(this.wylaczWentylator_Click);
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.Location = new System.Drawing.Point(657, 370);
            this.btnWyloguj.Margin = new System.Windows.Forms.Padding(4);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(111, 28);
            this.btnWyloguj.TabIndex = 14;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = true;
            this.btnWyloguj.Click += new System.EventHandler(this.wyloguj_Click);
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Location = new System.Drawing.Point(657, 318);
            this.btnWyjdz.Margin = new System.Windows.Forms.Padding(4);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(111, 44);
            this.btnWyjdz.TabIndex = 15;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.wyjdz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zaloguj się do systemu i potwierdź swoją obecność:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Obsługa linii produkcyjnej:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wyjdź lub wyloguj się z systemu:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::zad4.Properties.Resources.went1;
            this.pictureBox5.Location = new System.Drawing.Point(164, 320);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(219, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::zad4.Properties.Resources.tasma1;
            this.pictureBox4.Location = new System.Drawing.Point(121, 205);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(317, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::zad4.Properties.Resources.szara;
            this.pictureBox3.Location = new System.Drawing.Point(406, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::zad4.Properties.Resources.szara;
            this.pictureBox2.Location = new System.Drawing.Point(136, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::zad4.Properties.Resources.szara;
            this.pictureBox1.Location = new System.Drawing.Point(13, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::zad4.Properties.Resources.szara;
            this.pictureBox6.Location = new System.Drawing.Point(272, 42);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(126, 113);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // LiniaProdukcyjna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 566);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnWyloguj);
            this.Controls.Add(this.btnWylaczWentylator);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnWlaczWentylator);
            this.Controls.Add(this.btnNapraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnObecnosc);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnWylaczSilnik);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWlaczSilnik);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LiniaProdukcyjna";
            this.Text = "Linia produkcyjna";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWlaczSilnik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnWylaczSilnik;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnObecnosc;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnNapraw;
        private System.Windows.Forms.Button btnWlaczWentylator;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnWylaczWentylator;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

