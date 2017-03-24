using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_gokkers_groep_16
{
    public partial class Form1 : Form
    {
        //internal Guy[] guys;
        internal Suricate[] racers = new Suricate[4];
        internal Guy fer;
        internal Guy lida;
        internal Guy sietse;
        internal Bet[] bet = new Bet[3];
        internal string winner;
        Random step = new Random();
        Random r;


        //public string wiener;
        public Form1()
        {
            InitializeComponent();
            //pbBert.BackColor = Color.Transparent;
            //players en racers maken 
            fer = new Guy("Fer", 45, textbox69, textBox9);
            lida = new Guy("Lidy", 75, textBox3, textBox8);
            sietse = new Guy("Sietse", 50, textbox5, textBox7);

            racers[0] = new Suricate("Bert", runner1,pictureBox2);
            racers[1] = new Suricate("Ernie", runner2, pictureBox2);
            racers[2] = new Suricate("Bassie", runner3, pictureBox2);
            racers[3] = new Suricate("Adriaan", runner4, pictureBox2);

            r = new Random();

            fer.displayMoney(FerMoney);
            lida.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);
            ButtonStart.Hide();

        }






        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGamble_Click(object sender, EventArgs e)
        {

            TextBox ferText = textBox9;
            TextBox sietseText = textBox7;
            TextBox lindaText = textBox8;
            fer.displayMoney(FerMoney);
            lida.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);



            if (name_1.Checked)
            {

                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[0] = new Bet(vedt, fer);
                displayRacer(ferText, fer);
                fer.displayMoney(FerMoney);
                bet[0].Lose();




            }
            else if (name_3.Checked)
            {
                
                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[1] = new Bet(vedt, sietse);
                displayRacer(sietseText,fer);
                sietse.displayMoney(SietseMoney);
                bet[1].Lose();


            }
            else if (name_2.Checked)
            {
                
                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[2] = new Bet(vedt, lida);
                lida.displayMoney(LindaMoney);
                displayRacer(lindaText, lida);
                bet[2].Lose();

            }
            fer.displayMoney(FerMoney);
            lida.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);
            ButtonStart.Show();

        }

        internal void displayRacer(TextBox player,Guy Bettor)
        {
            string bert = "Bert";
            string ernie = "Ernie";
            string bassie = "Bassie";
            string adriaan = "Adriaan";

            if (radioButton6.Checked)
            {
                player.Text = bert;
                Bettor.MyBetstr = bert;


            }
            else if (radioButton5.Checked)
            {
                player.Text = ernie;
                Bettor.MyBetstr = ernie;

            }
            else if (radioButton4.Checked)
            {
                player.Text = bassie;
                Bettor.MyBetstr = bassie;

            }
            else if (radioButton7.Checked)
            {
                player.Text = adriaan;
                Bettor.MyBetstr = adriaan;

            }

        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonStart.Hide();
            ButtonGamble.Hide();
            raceStart(pictureBox2, racers, textBoxWinner);
            Thread.Sleep(1000);
            backToStart(pictureBox2, racers);
            if (fer.MyBetstr == textBoxWinner.Text)
            {
                //int money = Convert.ToInt32(textbox69.Text);
                //fer.Cash += money * 2;
                bet[0].PayOut(fer);
            }
            else if (lida.MyBetstr == textBoxWinner.Text)
            {
                //int money = Convert.ToInt32(textbox5.Text);
                //lida.Cash += money * 2;
                bet[1].PayOut(lida);

            }
            else if (sietse.MyBetstr == textBoxWinner.Text)
            {
                //int money = Convert.ToInt32(textBox3.Text);
                //sietse.Cash += money * 2;
                bet[2].PayOut(sietse);
            }

            fer.displayMoney(FerMoney);
            lida.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);
                this.bet[0].Amount = 0;
                this.bet[1].Amount = 0;
                this.bet[2].Amount = 0;
            textbox69.Text = "";
            textBox3.Text = "";
            textbox5.Text = "";
            ButtonStart.Show();
            ButtonGamble.Show();
            textBoxWinner.ResetText();
            bet[0].clearBet();
            bet[1].clearBet();
            bet[2].clearBet();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void raceStart()
        {


            int total0 = 0;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;

            bool winner0 = false;
            bool winner1 = false;
            bool winner2 = false;
            bool winner3 = false;

            do
            {
                //total0 += racers[0].Run();
                if (racers[0].RaceTrackLength == total0 && winner1 == false || winner2 == false || winner3 == false)
                {
                    this.winner = "bert";
                    racers[0].bwinner = true;
                    textBoxWinner.Text = racers[0].name;

                }
                //total1 += racers[1].Run();
                if (racers[1].RaceTrackLength == total2 && winner0 == false || winner2 == false || winner3 == false)
                {
                    this.winner = "ernie";
                    racers[1].bwinner = true;
                    textBoxWinner.Text = racers[1].name;

                }
                //total2 += racers[2].Run();
                if (racers[2].RaceTrackLength == total2 && winner1 == false || winner0 == false || winner3 == false)
                {
                    this.winner = "bassie";
                    racers[2].bwinner = true;
                    textBoxWinner.Text = racers[2].name;

                }
                //total3 += racers[3].Run();
                if (racers[3].RaceTrackLength == total3 && winner1 == false || winner2 == false || winner0 == false)
                {
                    this.winner = "adriaan";
                    racers[3].bwinner = true;
                    textBoxWinner.Text = racers[3].name;

                }




            } while (total0 <= racers[0].RaceTrackLength || total1 <= racers[1].RaceTrackLength || total2 <= racers[2].RaceTrackLength || total3 <= racers[3].RaceTrackLength);
            int i = -1;
            foreach (Suricate suricate in racers)
            {
                i++;

                if (racers[i].bwinner == false)
                {
                    Thread.Sleep(100);
                    textBoxWinner.Text = racers[i].name;
                }
            }



            //racers[0].Run();
            //racers[1].Run();
            //racers[2].Run();
            //racers[3].Run();




        }
        public void raceStart(PictureBox track, Suricate[] racers, TextBox textBoxWinner) {
            // PictureBox racer0, PictureBox racer1, PictureBox racer2, PictureBox racer3,
            //Random r = new Random();
           
            do
            {
                racers[0].Run(r, track);
                racers[1].Run(r, track);
                racers[2].Run(r, track);
                racers[3].Run(r, track);
                if (racers[0].Run(r, track))
                {
                    textBoxWinner.Text = racers[0].name;
                    this.wiener = racers[0].name;
                }
                else if (racers[1].Run(r, track))
                {
                    textBoxWinner.Text = racers[1].name;
                    this.wiener = racers[1].name;
                }
                else if (racers[2].Run(r, track))
                {
                    textBoxWinner.Text = racers[2].name;
                    this.wiener = racers[2].name;
                }
                else if (racers[3].Run(r, track))
                {
                    textBoxWinner.Text = racers[3].name;
                    this.wiener = racers[3].name;
                }

            } while (
            !racers[0].Run(r, track) &&
            !racers[1].Run(r, track) &&
            !racers[2].Run(r, track) &&
            !racers[3].Run(r, track)
            );
            textBoxWinner.Text = this.wiener;
        }
        public void backToStart (PictureBox track, Suricate[] racers)
        {
            for (int i = 0; i < 1200; i++)
            {
                racers[0].TakeStartingPosition(r);
                racers[1].TakeStartingPosition(r);
                racers[2].TakeStartingPosition(r);
                racers[3].TakeStartingPosition(r);
            }



            for (int i = 0; i < racers.Length; i++)
            {
                racers[i].MyPictureBox.Location = new Point(2, racers[i].MyPictureBox.Location.Y);
            }





        }

        private void textBoxWinner_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
