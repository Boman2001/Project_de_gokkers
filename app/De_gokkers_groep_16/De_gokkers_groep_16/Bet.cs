using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_gokkers_groep_16
{
    public class Bet
    {
        public int Amount;          //Het bedrag van de weddenschap.
        public Suricate Timon;      //Het nummer van de hond waarop weddenschap is afgesloten.
        public Guy Bettor;          //De gokker die gewed heeft.
        internal bool isBetOn;


        public Bet(int amount, Guy bettoer)
        {
            this.Amount = amount;

            this.Bettor = bettoer;
            //this.isBetOn = false;

        }

        public string GetDescription()
        {
            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)
            return "test";
        }

        public void PayOut(Guy Winner)
        {
            int payout = this.Amount;
            //De parameter van deze methode is de winnaar van de race.
            //Als de hond gewonnen heeft, retourneer dan het bedrag dat gewed is
            //Anders, retourneer het tegengestelde van het gewedde bedrag.
            //Winner.Cash += Amount * 2;
            payout += this.Amount;
            Winner.Cash += payout;
        }

        public void Lose()
        {
            Bettor.Cash -= this.Amount;
            Bettor.mytextbox.Text = Convert.ToString(this.Amount);
        }

        public void clearBet()
        {
            this.Amount = 0;
        }

    }
}