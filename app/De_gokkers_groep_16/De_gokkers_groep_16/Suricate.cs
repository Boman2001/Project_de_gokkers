using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_gokkers_groep_16
{

    public class Suricate
    {

        public int RaceTrackLength;             //De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer;               //Een instantie van Random (= Willekeurig) 
        public string name;
        internal bool bwinner = false;

        public Suricate(string id, PictureBox runner, PictureBox track)
        {

            this.RaceTrackLength = track.Size.Width;
            this.name = id;
            this.MyPictureBox = runner;

        }

        public int Run(PictureBox track)
        {
            //Ga willekeurig 1, 2, 3 of 4 posities naar voren.
            //Werk de positie van PictureBox bij op het formulier.
            //Geef de waarde ‘true’ terug als ik de race win.
            int total = 0;
            Random steps = new Random();
            //do
            //{

                int step = steps.Next(1, 8);
                total += step;

                Thread.Sleep(5);

                //this.MyPictureBox.Location = new Point(MyPictureBox.Location.X +, this.MyPictureBox.Location.Y);
                MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + step, this.MyPictureBox.Location.Y);

                Application.DoEvents();
            
                return step;

        }

        public bool Run(Random r, PictureBox track)
        {
            int min = 1, max = 4, RaceTrackPos = 0; ;

            //Ga willekeurig 1, 2, 3 of 4 posities naar voren.
            int random = r.Next(min, max);

            RaceTrackPos += random;

            //Werk de positie van PictureBox bij op het formulier.
            this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + (random), this.MyPictureBox.Location.Y);
            Application.DoEvents();

            //Geef de waarde ‘true’ terug als ik de race win.
            if (this.MyPictureBox.Location.X > track.Width )
                return true;
            else
                return false;
        }

        public void TakeStartingPosition(Random r)
        {
            int min = 1, max = 4, RaceTrackPos = 0; ;

            //Ga willekeurig 1, 2, 3 of 4 posities naar voren.
            int random = r.Next(min, max);

            RaceTrackPos -= random;

            //Werk de positie van PictureBox bij op het formulier.
            this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X - (random), this.MyPictureBox.Location.Y);
            Application.DoEvents();


        }

    }
}



