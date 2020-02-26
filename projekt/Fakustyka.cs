using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Fakustyka : Form
    {
        public Fakustyka()
        {
            wynik = 0;
            InitializeComponent();
            Start.Visible = false;
            cat.Visible = false; ;
            cow.Visible = false;
            frog.Visible = false;
            horse.Visible = false;
            dog.Visible = false;
            bird.Visible = false;
            elephant.Visible = false;
            lion.Visible = false;
            sheep.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 m = new Form1();
            m.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                czas.Text = "Czas: " + counter.ToString();
                MessageBox.Show("Brawo! Liczba zdobytych przez Ciebie punktów to: " + wynik);

            }
            czas.Text = "Czas: " + counter.ToString();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (!faza_szkoleniowa)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;
                timer1.Start();
                czas.Text = "Czas: " + counter.ToString();
            }
            Start.Visible = false;
            Random r = new Random();
            wylosowany_indeks = r.Next(0, 8);
            //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
            player.Play();
        }

        private void cat_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 0)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player2.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void cow_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 1)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void dog_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 2)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        
        private void frog_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 3)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void horse_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 4)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void sheep_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 5)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void elephant_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 6)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void lion_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 7)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }
        }
        private void bird_Click(object sender, EventArgs e)
        {
            if (wylosowany_indeks == 8)
            {
                wynik++;
                this.textBox2.Text = "Wynik: " + wynik;
                Random r = new Random();
                wylosowany_indeks = r.Next(0, 8);
                //zagraj sygnal dobrego dzwieku i czekaj na nowy dzwiek
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../good.wav");
                player1.Play();
                System.Threading.Thread.Sleep(1000);
                //zagraj dzwiek z tablicy o indeksie [wylosowany_indeks]
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(tab[wylosowany_indeks]);
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("../../bad.wav");
                player1.Play();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faza_szkoleniowa = true;
            wynik = 0;
            MessageBox.Show("Klinij ok aby zacząć faze szkoleniową, w której czas nie będzie odmierzany.");
            Start.Visible = true;
            cat.Visible = true;
            cow.Visible = true;
            frog.Visible = true;
            horse.Visible = true;
            dog.Visible = true;
            bird.Visible = true;
            elephant.Visible = true;
            lion.Visible = true;
            sheep.Visible = true;
            MessageBox.Show("Postaraj się jak najszybciej kliknąć w obrazek zwierzęcia, które usłyszysz. Wciśnij Start, aby rozpocząć test.", "Zasady");
            this.textBox2.Text = "Wynik: " + wynik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faza_szkoleniowa = false;
            counter = 30;
            wynik = 0;
            Start.Visible = true;
            cat.Visible = true;
            cow.Visible = true;
            frog.Visible = true;
            horse.Visible = true;
            dog.Visible = true;
            bird.Visible = true;
            elephant.Visible = true;
            lion.Visible = true;
            sheep.Visible = true;
            MessageBox.Show("Test zaraz się rozpocznie. Postaraj się jak najszybciej kliknąć w obrazek zwierzęcia, które usłyszysz. Wciśnij Start, aby rozpocząć test.", "Zasady");
            this.textBox2.Text = "Wynik: " + wynik;

        }
    }
}
