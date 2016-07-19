using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Greyhound[] GreyhoundArray = new Greyhound[3];
        // Random MyRandomizer = new Random();

        private void start()
        {
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width,
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox2.Width,
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox3.Width,
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }

    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            //Set my label to my bet's description and the label on my radio button to show my cash
        }

        public void ClearBet()
        {
            //Reset bet to 0
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            //Place a new bet and store it in my bet field
            //Return true if th guy had enough money to bet

            return true;
        }

        public void Coller(int Winner)
        {
            //Ask my bet to pay out, clear my bet, and update my labels
        }
    }

    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            //Return a string that asays who placed the bet, how much cash was bet, and which dog he bet on. If the amount is zero,n ot bet was placed.
            return "description";
        }

        public int PayOut(int Winner)
        {
            //The parameter is the winner of the race. If the dog won, return the amount bet. Otherwise return the negative of the amount bet.
            return 0;
        }
    }
}
