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
    //2 Player Form
    public partial class frmMainGame : Form
    {
        public frmMainGame()
        {
            InitializeComponent();
            MessageBox.Show("player starts");
        }

        //Variable Assign
        //Static Type to check that no instence is unnessesarily used i.e No inheritance 
        static string Player1Name;
        static string Player2Name;
        static int score;
        static int RunScore;
        static int RunScore2;
        static int CumScore;
        static Player_Information player1 = new Player_Information();
        static Player_Information player2 = new Player_Information();
        static bool PlayerCheck = true;
        static int AgreedTotal = 0;
        Player_Information mPlayer;
        public static int counterPlayer1 = 0;
        public static int counterPlayer12 = 0;

        //static char choice = 'y';

        //Computer Mode Code for Computer Form Value Assignment
        public frmMainGame(string Player1Name, string Player2Name, int score)
        {
            InitializeComponent();
            frmMainGame.Player1Name = Player1Name;
            frmMainGame.Player2Name = Player2Name;
             frmMainGame.score = score;
            lblPlayer1.Text = frmMainGame.Player1Name;
            lblPlayer2.Text = frmMainGame.Player2Name;
            lblSetScore.Text = frmMainGame.score.ToString();
        }

        //Main Game Form Load Method for Variable Data Assignment
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressList.Items.Clear(); // Clear Progress List At Start
            
            player1.PlayerName = frmMainGame.Player1Name;
            player2.PlayerName = frmMainGame.Player2Name;

            label4.Text = player1.PlayerName+"'s wining ";
            label5.Text = player2.PlayerName+"'s wining";

            //Setting Target Score to Form
            this.activePlayer.Text = player1.PlayerName;
            try
            {
                AgreedTotal = frmMainGame.score;
            }
            //Inccorect Format Entered Message
            catch (Exception)
            {
                MessageBox.Show("Please Enter score in a correct format", "Error", MessageBoxButtons.OK);
            }
            Random rnd = new Random();
            int num = rnd.Next(0, 2);
            if (num == 0)
            {
                Player_Information player = CalculateScore(player2, AgreedTotal, 2);
                txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                this.activePlayer.Text = player2.PlayerName;
            }


            /*Player_Information player = CalculateScore(player1, AgreedTotal, 1);
            txbxPlayer1Score.Text = player.CumulativeScore.ToString();*/
            //Buttons on From remain Enable Throughout the Process
            btnKeepTurn.Enabled = true;
            btnPass.Enabled = true;
        }

        //Randome Dice Rolling Code
        public Player_Information CalculateScore(Player_Information player, int agreedTotal, int playerIdentity)
        {
            //Takes in the Player Name to show on the Progress List
            mPlayer = player;
            
            ProgressList.Items.Add($"{player.PlayerName}'s is rolling the Dice");
            this.activePlayer.Text = player.PlayerName;

            if (playerIdentity == 1)
               PlayerCheck = true;
            
            else if (playerIdentity == 2)
                PlayerCheck = false;
            
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
            Thread.Sleep(200); // Suspended time of 200 Milliseconds


            //Dice 1: Rolling with Random Computer generated Integers between 1 and 6
            int dice2 = new Random().Next(1, 7);
            // If Statement begins for Dice 1 comparing Dice Value with Numbers
            if (dice2 == 1)
            {
                //Dice 1 with Number 1 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D1;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 2)
            {
                //Dice 1 with Number 2 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D2;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 3)
            {
                //Dice 1 with Number 3 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D3;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 4)
            {
                //Dice 1 with Number 4 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D4;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 5)
            {
                //Dice 1 with Number 5 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D5;
                txbxDice2.Text = dice2.ToString();
            }
            else if (dice2 == 6)
            {
                //Dice 1 with Number 6 Image Appears with Score
                lblDice2.Image = FawadIjazAssigt.Properties.Resources.D6;
                txbxDice2.Text = dice2.ToString();
            }


            //Code for Game of Groans!
            //1st Condition The Snake's Eye: If Dices appear two 1s 
            if (dice1 == 1 && dice2 == 1  || dice1 == 1 && dice2 == 1)
            {
                //In condition a Player gets 7: Running and Cumulative Score gets Zero.
                player.CumulativeScore = 0;
                player.RunningScore = 0;
                ProgressList.Items.Add($"Snake's Eye. Your turn has ended");
                if (PlayerCheck == true)
                {
                    MessageBox.Show($"You got two 1s. Your turn has ended, now its " + player2.PlayerName + "'s turn", "The Snake's Eye", MessageBoxButtons.OK);
                    this.activePlayer.Text = player2.PlayerName;
                    this.txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                    CalculateScore(player2, AgreedTotal, 2);
                }

                else if (PlayerCheck == false) {
                    this.activePlayer.Text = player1.PlayerName;
                    MessageBox.Show($"You got two 1s. Your turn has ended, now its " + player1.PlayerName + "'s turn", "The Snake's Eye", MessageBoxButtons.OK);
                    this.txbxPlayer2Score.Text = player.CumulativeScore.ToString();
                    CalculateScore(player1, AgreedTotal, 1);
                }
                
            }
            // 2nd Condition: If If either of the Dice Rolls 1
            else if (dice1 == 1 || dice2 == 1)
            {
                //Player Running Score gets Zero with Message Prompt
                player.RunningScore = 0;
                ProgressList.Items.Add($"You got a 1. Your turn has ended");
                ProgressList.Items.Add($"{player.PlayerName} Running Score: {player.RunningScore} and Cumulative Score: {player.CumulativeScore}");
                if (PlayerCheck == true)
                {
                    this.txbxPlayer1Score.Text = player1.CumulativeScore.ToString();
                    MessageBox.Show($"You got a 1. Your turn has ended. now its " + player2.PlayerName + "'s turn. No Running Score for You", "Groan", MessageBoxButtons.OK);
                    
                    this.activePlayer.Text = player2.PlayerName;
                    PlayerCheck = false;
                    return player;
                    //CalculateScore(player2, AgreedTotal, 2);
                }
                else if (PlayerCheck == false) {
                    this.txbxPlayer2Score.Text = player2.CumulativeScore.ToString();
                    MessageBox.Show($"You got a 1. Your turn has ended. now its " + player1.PlayerName + "'s turn. No Running Score for You", "Groan", MessageBoxButtons.OK);
                    this.activePlayer.Text = player1.PlayerName;
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
            
            //player.RunningScore = 0;
            
            return player;
        }

        //Code for Keep the Turn Button
        private void btn_Keep_Click(object sender, EventArgs e)
        {
            //If Keep the Turn Button Pressed
            if (PlayerCheck == true)
            {
                //Progress List will Prompt Message 
                ProgressList.Items.Add($"{player1.PlayerName} decided to keep the dice");
               
                Player_Information player = CalculateScore(player1, AgreedTotal, 1);
              //  txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                
                //Nested IF statement if Player Keep on Rolling the Dice and Scorecomes to Target Score
                //Palyer Win Message Prompt
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");
                    counterPlayer1++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label6.Text = counterPlayer1.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxPlayer2Score.Text = "0";
                        label2.Text = "0";

                     

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        Application.Exit();
                    }


                                        

                }
            }

            //If Other Player Keeps the Dice
            else if (PlayerCheck == false)
            {
                //Progress List will Prompt Message 
                ProgressList.Items.Add($"{player2.PlayerName} decided to keep the dice");
                Player_Information player = CalculateScore(player2, AgreedTotal, 2);
                //txbxPlayer2Score.Text = player.CumulativeScore.ToString();
                //Nested IF statement if Player Keep on Rolling the Dice and Scorecomes to Target Score
                //Palyer Win Message Prompt
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");


                    counterPlayer12++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label7.Text = counterPlayer12.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxPlayer2Score.Text = "0";
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

        //Code for Pass On Button
        private void btn_Pass_Click(object sender, EventArgs e)
        {
            

            //If Player Decides to Pass the Turn to another player
            if (PlayerCheck == true)
            {
                player1.RunningScore = 0;
                //Progress List will Prompt Message


                ProgressList.Items.Add($"{player1.PlayerName} decided to pass the dice");
                ProgressList.Items.Add($"{mPlayer.PlayerName} Running Score: {mPlayer.RunningScore} and Cumulative Score: {mPlayer.CumulativeScore}");
                this.txbxPlayer1Score.Text = mPlayer.CumulativeScore.ToString();
                
                this.activePlayer.Text = player2.PlayerName;


                Player_Information player = CalculateScore(player2, AgreedTotal, 2);
                txbxPlayer2Score.Text = player.CumulativeScore.ToString();
                //Nested IF statement if Player Keep on Rolling the Dice and Scorecomes to Target Score
                //Palyer Win Message Prompt
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");
                    counterPlayer12++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label7.Text = counterPlayer1.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxPlayer2Score.Text = "0";
                        label2.Text = "0";



                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        Application.Exit();
                    }

                }
            }

            //If Other Player Passes the Turn
            else if (PlayerCheck == false)
            {
                player2.RunningScore = 0;
                //Progress List will Prompt Message
                ProgressList.Items.Add($"{player2.PlayerName} decided to pass the dice");
                ProgressList.Items.Add($"{mPlayer.PlayerName} Running Score: {mPlayer.RunningScore} and Cumulative Score: {mPlayer.CumulativeScore}");
                this.txbxPlayer2Score.Text = mPlayer.CumulativeScore.ToString();

                this.activePlayer.Text = player1.PlayerName;

                PlayerCheck = true;
                Player_Information player = CalculateScore(player1, AgreedTotal, 1);
                txbxPlayer1Score.Text = player.CumulativeScore.ToString();
                //Nested IF statement if Player Keep on Rolling the Dice and Scorecomes to Target Score
                //Palyer Win Message Prompt
                if (player.CumulativeScore >= AgreedTotal)
                {
                    ProgressList.Items.Add($"{player.PlayerName} has won");
                    MessageBox.Show($"{player.PlayerName} has won");
                    counterPlayer1++;

                    DialogResult dialogResult = MessageBox.Show("Do you want to play Again?", "Option", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.label6.Text = counterPlayer1.ToString();
                        ProgressList.Items.Clear();
                        txbxPlayer1Score.Text = "0";
                        txbxPlayer2Score.Text = "0";
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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