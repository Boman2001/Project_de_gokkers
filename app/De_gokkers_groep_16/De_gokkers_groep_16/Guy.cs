using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_gokkers_groep_16
{
    public class Guy
    {
        public string Name;  // De naam van de gokker
        public int Cash;     // Het saldo van de gokker
        public string MyBetstr;    // Een instantie van Bet()
        internal Bet MyBet;
        public RadioButton MyRadiobutton;
        public Label mytextbox;
        public TextBox myTextBox1;



        public Guy(string name , int cash, Label text, TextBox bet )
        {
            this.Name = name;
            this.Cash = cash;
            this.mytextbox = text;
            this.myTextBox1 = bet;
           

        }

        //Deze twee velden zijn de gokkers GUI controls op het formulier
      public void displayMoney(TextBox money)
        {
            string cashString = Convert.ToString(this.Cash);
            money.Text = cashString ;
        }

        public void UpdateLabels()
        {
            //Verander mijn label in de omschrijving van mijn weddenschap.
            //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
            //(Bijv. “Lidy heeft 43 euro.”)
        }

        public bool PlaceBet(int amount, int dog)
        {
            //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet.
            //Retourneer een true als de gokker genoeg geld heeft om te wedden.

            //Onderstaande regel staat er tijdelijk om foutmeldingen te voorkomen. 
            //Haal deze regel later weg.
            return true;

        }

        public void ClearBet()
        {
            //Maak de weddenschap leeg.
            this.MyBet.Amount = 0;


        }

        public void Collect(int Winner)
        {
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.
        }

    }

}
