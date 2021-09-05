using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //Added: Suspends the current thread for the specified amount of time.
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FawadIjazAssigt
{
    public partial class frmComputer : Form
    {
        //Variable Assign
        //Static Type to check that no instence is unnessesarily used i.e No inheritance 
        static string Player1Name;
        static string Player2Name;
        static int score;
        static Player_Information player1 = new Player_Information();
        static Player_Information player2 = new Player_Information();
        static bool PlayerCheck = true;
        static int AgreedTotal = 0;
        Player_Information mPlayer2;
        public static int counterPlayer11 = 0;
        public static int counterPlayer22 = 0;
        //static char choice = 'y';

        //Start of Program
        public frmComputer()
        {
            InitializeComponent();
        }

        //Computer Mode Code for Computer Form Value Assignment
        public frmComputer(string PlayerName, int score)
        {
            InitializeComponent();
            frmComputer.Player1Name = PlayerName;
            frmComputer.Player2Name = "Computer";
            frmComputer.score = score;
            lblPlayer1.Text = frmComputer.Player1Name;
            lblComputer.Text = frmComputer.Player2Name;
            lblScore.Text = frmComputer.score.ToString();
        }

        //Randome Function used
        public EventHandler RandomComputer;

        //Code against Keep the Turn Button
        private void btn_Keep_Click(object sender, EventArgs e)
        {
            //If Button Pressed
            if (PlayerCheck == true)
            {
                //Messages seen on the Progress List
                ProgressList.Items.Add($"{player1.PlayerName} decided to keep the dice");
                Player_Information player = CalculateScore(player1, AgreedTotal, 1);
               
                // txbxPlayer1Score.Text = player.CumulativeScore.ToString();
               
                //Nested If Statement: If Total reches Cumulative Score Human Player wins
                //Message appears in a Message Window
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");

                    counterPlayer11++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label7.Text = counterPlayer11.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxComputerScore.Text = "0";
                        label2.Text = "0";



                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        Application.Exit();
                    }
                }
            }
            //2nd Condition that if Keep the Turn button is not pressed
            else if (PlayerCheck == false)
            {
                
                bool randomVar = new Random().Next(100) % 2 == 0;

                //While Loop Statement with random variable assignment for Computer Turn
                while (randomVar)
                {
                    Thread.Sleep(1000);
                    ProgressList.Items.Add($"{player2.PlayerName} decided to keep the dice");
                    Player_Information player = CalculateScore(player2, AgreedTotal, 2);
                
                    //    txbxComputerScore.Text = player.CumulativeScore.ToString();
                    
                    //If Computer Score reaches the Targeted Total Computer Win Message is Displayed
                    if (player.CumulativeScore >= AgreedTotal)
                    {
                        ProgressList.Items.Add($"{player.PlayerName} has won");
                        MessageBox.Show($"{player.PlayerName} has won");
                        counterPlayer22++;

                        DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            this.label8.Text = counterPlayer22.ToString();
                            ProgressList.Items.Clear();
                            txbxPlayer1Score.Text = "0";
                            txbxComputerScore.Text = "0";
                            label2.Text = "0";



                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            Application.Exit();
                        }

                    }
                    //1000 Milliseconds Suspend time
                    Thread.Sleep(1000);
                    randomVar = new Random().Next(100) % 2 == 0;

                }
                //While Loop plays computer's turn If Human Player passes the turn by Pressing Pass Button
                btn_Pass_Click(sender, e);


            }
        }

        //Code against Pass Button
        private void btn_Pass_Click(object sender, EventArgs e)
        {
            //If Pass Button Pressed by the User


            if (PlayerCheck == true)
            {
                player1.RunningScore = 0;
                this.txbxPlayer1Score.Text = mPlayer2.CumulativeScore.ToString();

                MessageBox.Show("Now its " + player2.PlayerName + "'s" + " turn");

                ProgressList.Items.Add($"{player1.PlayerName} decided to pass the dice");
                
                //ProgressList.Items.Add($"{mPlayer2.PlayerName} Running Score: {mPlayer2.RunningScore} and Cumulative Score: {mPlayer2.CumulativeScore}");
               
              //  this.txbxPlayer1Score.Text = mPlayer2.CumulativeScore.ToString();

                
                bool randomVar = new Random().Next(100) % 2 == 0;
                
                //While-IF Loop Statement Runs for the Computer's Turn
                while (randomVar)
                {
                    Thread.Sleep(1000);

                    Player_Information player = CalculateScore(player2, AgreedTotal, 2);
//                    txbxComputerScore.Text = player.CumulativeScore.ToString();
                    //If Agreed Total Reaches the Player Score Computer Win Message
                    if (player.CumulativeScore >= AgreedTotal)
                    {
                        ProgressList.Items.Add($"{player.PlayerName} has won");
                        MessageBox.Show($"{player.PlayerName} has won");
                        counterPlayer22++;

                        DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            this.label8.Text = counterPlayer22.ToString();
                            ProgressList.Items.Clear();
                            txbxPlayer1Score.Text = "0";
                            txbxComputerScore.Text = "0";
                            label2.Text = "0";



                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            Application.Exit();
                        }

                    }
                    //Suspends thread for 1500 Milliseconds
                    Thread.Sleep(1000);
                    randomVar = new Random().Next(100) % 2 == 0;
                    ProgressList.Items.Add($"{player2.PlayerName} decided to keep the dice");
                }
                //While Statement Run is this Condition is true i.e. Pass On Button Clicked
               
                if (randomVar == false)
                    PlayerCheck = false;
                btn_Pass_Click(sender, e);


            }
            //If Pass-On Button Not Clicked
            else if (PlayerCheck == false)
            {
                player2.RunningScore = 0;
                this.txbxComputerScore.Text = mPlayer2.CumulativeScore.ToString();
                // Progress List Keeps on Going for the Player
                ProgressList.Items.Add($"{player1.PlayerName} decided to pass the dice");
                MessageBox.Show("Now its " + player1.PlayerName + "'s" + " turn");
               
                // ProgressList.Items.Add($"{mPlayer2.PlayerName} Running Score: {mPlayer2.RunningScore} and Cumulative Score: {mPlayer2.CumulativeScore}");
               
                this.label2.Text = mPlayer2.RunningScore.ToString();
                txbxComputerScore.Text = mPlayer2.CumulativeScore.ToString();
                PlayerCheck = true;
              //  MessageBox.Show("Now its "+player1.PlayerName+"'s turn");
                this.label4.Text = player1.PlayerName;

               Player_Information player = CalculateScore(player1, AgreedTotal, 1);
                txbxPlayer1Score.Text = player.CumulativeScore.ToString();
               
                //Player Wins if Agreed total is equal to Cumulative Score
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");
                    counterPlayer11++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label7.Text = counterPlayer11.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxComputerScore.Text = "0";
                        label2.Text = "0";



                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        Application.Exit();
                    }

                }

            }

        }

        //Randome Dice Rolling Code
        public Player_Information CalculateScore(Player_Information player, int agreedTotal, int playerIdentity)
        {
            mPlayer2 = player;
            int period = 0;
            this.label4.Text = player.PlayerName;
            //Takes in the Player Name to show on the Progress List
            ProgressList.Items.Add($"{player.PlayerName}'s is rolling the Dice");
            if (playerIdentity == 1) {
                PlayerCheck = true;
            }
            
            else if (playerIdentity == 2)
            {
                PlayerCheck = false;
             
            }
            //threading wait for computer
            //Thread.Sleep(period);
            //Dice 1: Rolling with Random Computer generated Integers between 1 and 6
            int dice1 = new Random().Next(1, 7);
            // If Statement begins for Dice 1 comparing Dice Value with Numbers
            if (dice1 == 1)
            {
                //Dice 1 with Number 1 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D1;
                txbxDice1.Text = dice1.ToString();
            }
            else if (dice1 == 2)
            {
                //Dice 1 with Number 2 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D2;
                txbxDice1.Text = dice1.ToString();
            }
            else if (dice1 == 3)
            {
                //Dice 1 with Number 3 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D3;
                txbxDice1.Text = dice1.ToString();
            }
            else if (dice1 == 4)
            {
                //Dice 1 with Number 4 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D4;
                txbxDice1.Text = dice1.ToString();
            }
            else if (dice1 == 5)
            {
                //Dice 1 with Number 5 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D5;
                txbxDice1.Text = dice1.ToString();
            }
            else if (dice1 == 6)
            {
                //Dice 1 with Number 6 Image Appears with Score
                lblDice1.Image = FawadIjazAssigt.Properties.Resources.D6;
                txbxDice1.Text = dice1.ToString();
            }
            //Time Gap for 200 MilliSecond
            Thread.Sleep(200);

            //Dice 2: Rolling with Random Computer generated Integers between 1 and 6
            int dice2 = new Random().Next(1, 7);
            //If Statement for Dice 2 Comparing Dice Vaue with Numbers
            if (dice2 == 1)
            {
                //Dice 2 with Number 1 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D1;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 2)
            {
                //Dice 2 with Number 2 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D2;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 3)
            {
                //Dice 2 with Number 3 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D3;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 4)
            {
                //Dice 2 with Number 4 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D4;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 5)
            {
                //Dice 2 with Number 5 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D5;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 6)
            {
                //Dice 2 with Number 6 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D6;
                txbxDice2.Text = dice2.ToString();
            }


            //Code for Game of Groan
                     
            //1st Condition The Snake's Eye: If Dices appear 1 and 1 
            if (dice1 == 1 && dice2 == 1  || dice1 == 1 && dice2 == 1)
            {
                //In condition a Player gets two 1s: Running and Cumulative Score gets Zero.
                player.CumulativeScore = 0;
                player.RunningScore = 0;

                MessageBox.Show($"You got a Snake's Eye. Your turn has ended", "Result", MessageBoxButtons.OK);
                ProgressList.Items.Add($"You got a Snake's Eye. Your turn has ended");
                if (PlayerCheck == true)
                {
                    
                    this.txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                    MessageBox.Show("Now its "+player2.PlayerName+" 's"+" turn");
                    CalculateScore(player2, AgreedTotal, 2);
                }

                else if (PlayerCheck == false) {

                    this.txbxComputerScore.Text = player.CumulativeScore.ToString();
                    MessageBox.Show("Now its " + player1.PlayerName + " 's" + " turn");
                  
                    CalculateScore(player1, AgreedTotal, 1);
                }
                
            }
            //If either of the Dice Rolls One (1)
            else if (dice1 == 1 || dice2 == 1)
            {   
                //Player Running Score gets Zero with Message Prompt
                player.RunningScore = 0;
                ProgressList.Items.Add($"You got a Groan. Your turn has ended.");

                if (PlayerCheck == true) {
                    this.txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                    this.label4.Text = player2.PlayerName;
                    ProgressList.Items.Add($"{player.PlayerName} Running Score: {player.RunningScore} and Cumulative Score: {player.CumulativeScore}");
                    MessageBox.Show($"You got a six. Your turn has ended, now its " + player2.PlayerName + "'s turn", "Result", MessageBoxButtons.OK);
                    CalculateScore(player2, AgreedTotal, 2);
                }

                else if (PlayerCheck == false) {
                    this.txbxComputerScore.Text = player.CumulativeScore.ToString();
                    this.label4.Text = player1.PlayerName;

                    ProgressList.Items.Add($"{player.PlayerName} Running Score: {player.RunningScore} and Cumulative Score: {player.CumulativeScore}");

                    MessageBox.Show($"You got a six. Your turn has ended, now its " + player1.PlayerName + "'s turn", "Result", MessageBoxButtons.OK);

                    PlayerCheck = true;
                    return player;
                    // CalculateScore(player1, AgreedTotal, 1);

                }

            }
            //Otherwise the Score is Added to Player Total
            else
            {
                player.RunningScore += dice1 + dice2;
                player.CumulativeScore += player.RunningScore;
            }
            //Player Score Progress on Progress List
            ProgressList.Items.Add($"{player.PlayerName} Running Score: {player.RunningScore} and Cumulative Score: 0");
            this.label2.Text = player.RunningScore.ToString();

            if (!PlayerCheck) {
                player.RunningScore = 0;
                Thread.Sleep(1000);
                CalculateScore(player2,agreedTotal,2);
            }

            
           // player.RunningScore = 0;
            return player;
        }

        //Data Assignment and Check Before Computer Form Loads
        private void PlayWithComputer_Load(object sender, EventArgs e)
        {
            ProgressList.Items.Clear();
            player1.PlayerName = frmComputer.Player1Name;
            player2.PlayerName = frmComputer.Player2Name;

            label5.Text = player1.PlayerName + "'s wining ";
            label6.Text = player2.PlayerName + "'s wining";


            this.label4.Text = player1.PlayerName;

            //Score is not set if it is not written in Correct Format
            try
            {
                AgreedTotal = frmComputer.score;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter score in a correct format", "Error", MessageBoxButtons.OK);
            }
            Random rnd = new Random();
            int num = rnd.Next(0,2);
            if (num==0) {
                Player_Information player = CalculateScore(player2, AgreedTotal, 2);
                txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                this.label4.Text = player2.PlayerName;
            }
            /*

             */

            //Buttons on Form remains Enable thougout the process
            btnKeepTurn.Enabled = true;
            btnPass.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You may loose the current score if exit", "Warrning Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You may loose the current score in case of Back", "Warrning Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                frmPlayerMode obj = new frmPlayerMode();
                this.Hide();
                obj.Show();


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
//Fawad Ijaz
//St#: 3316042