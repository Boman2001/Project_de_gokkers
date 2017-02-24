using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_gokkers_groep_16
{
    public partial class Form1 : Form
    {
        //internal Guy[] guys;
        internal Suricate[] racers = new Suricate[4];
        internal Guy fer;
        internal Guy lidy;
        internal Guy sietse;
        internal Bet[] bet = new Bet[3];
        internal string winner;
        Random step = new Random();

        public Form1()
        {
            InitializeComponent();
            //players en racers maken 
            fer = new Guy("Fer", 45, textbox69, textBox9);
            linda = new Guy("Lidy", 75, textBox3, textBox8);
            sietse = new Guy("Sietse", 50, textbox5, textBox7);
            racers[0] = new Suricate(0, runner1,pictureBox2);
            racers[1] = new Suricate(1, runner2, pictureBox2);
            racers[2] = new Suricate(2, runner3, pictureBox2);
            racers[3] = new Suricate(3, runner4, pictureBox2);
            
            fer.displayMoney(FerMoney);
            linda.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);

        }






        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGamble_Click(object sender, EventArgs e)
        {
           
            TextBox ferText = textBox9;
            TextBox sietseText = textBox8;
            TextBox lindaText = textBox7;
            fer.displayMoney(FerMoney);
            linda.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);



            if (name_1.Checked)
            {

                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[0] = new Bet(vedt, fer);
                displayRacer(ferText);
                fer.displayMoney(FerMoney);
                bet[0].Lose();




            }
            else if (name_3.Checked)
            {
                
                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[1] = new Bet(vedt, sietse);
                displayRacer(sietseText);
                sietse.displayMoney(SietseMoney);
                bet[1].Lose();


            }
            else if (name_2.Checked)
            {
                
                decimal wed = numericUpDown1.Value;
                int vedt = Convert.ToInt32(wed);
                bet[2] = new Bet(vedt, linda);
                linda.displayMoney(LindaMoney);
                displayRacer(lindaText);
                bet[2].Lose();


            }
            fer.displayMoney(FerMoney);
            linda.displayMoney(LindaMoney);
            sietse.displayMoney(SietseMoney);

        }

        internal void displayRacer(TextBox player)
        {
            string bert = "bert";
            string ernie = "ernie";
            string bassie = "Bassie";
            string adriaan = "adriaan";

            if (radioButton6.Checked)
            {
                player.Text = bert;

            }
            else if (radioButton5.Checked)
            {
                player.Text = ernie;

            }
            else if (radioButton4.Checked)
            {
                player.Text = bassie;

            }
            else if (radioButton7.Checked)
            {
                player.Text = adriaan;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            int total0 = 0;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            
            bool winner = false;
            bool winner0 = false;
            bool winner1 = false;
            bool winner2 = false;
            bool winner3 = false;

            do
            {
                total0 += racers[0].Run();
                if (total0 == racers[0].RaceTrackLength && winner1 == false || winner2 == false || winner3 == false)
                {
                    this.winner = "bert";
                   
                }
                total1 += racers[1].Run();
                if (total2 == racers[1].RaceTrackLength && winner0 == false || winner2 == false || winner3 == false)
                {
                    this.winner = "ernie";
                }
                total2 += racers[2].Run();
                if (total2 == racers[2].RaceTrackLength && winner1 == false || winner0 == false || winner3 == false)
                {
                    this.winner = "bassie";
                }
                total3 += racers[3].Run();
                if (total3 == racers[3].RaceTrackLength && winner1 == false || winner2 == false || winner0 == false)
                {
                    this.winner = "adriaan";
                }



            } while (total0 <= racers[0].RaceTrackLength && total1 <= racers[1].RaceTrackLength && total2 <= racers[2].RaceTrackLength && total3 <= racers[3].RaceTrackLength);
            textBoxWinner.Text = this.winner;
       

            //racers[0].Run();
            //racers[1].Run();
            //racers[2].Run();
            //racers[3].Run();




        }
    }
}
