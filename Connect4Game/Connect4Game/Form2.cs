/// <summary>
/// the main game layout
/// </summary>
namespace Connect4Game
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    
    /// <summary>
    /// this is the main form of the game where user plays game.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// here are the global variables that are used in couple of methods
        /// </summary>
        private int rows;
        private int cols;
        private int columnIncreament;
        private int rowIncreament;
        private string player1;
        private string player2;
        private List<Button> grid = new List<Button>();
        private Button[,] gridArray;
        private Form1 form1;
        private GameLogic gameLogic;

        /// <summary>
        /// initialize new instance this is the constructor without arguments
        /// </summary>
        public Form2() 
        {
        }

        /// <summary>
        /// over loaded constructor
        /// </summary>
        /// <param name="form1">form1 argument</param>
        public Form2(Form1 form1)
        {
            this.InitializeComponent();
            this.form1 = form1;
           
           
            gameLogic = new GameLogic();

        }

        /// <summary>
        /// this methods takes the number of rows and columns with players information and create an array or grid layout for  
        /// </summary>
        /// <param name="rows">row variable</param>
        /// <param name="cols">column variable</param>
        /// <param name="player1">player variable</param>
        /// <param name="player2">player2 variable</param>
        public void SetCredentials(int rows, int cols, string player1, string player2)
        {
            this.rows = rows;
            this.cols = cols;
            this.player1 = player1;
            this.player2 = player2;

            this.gridArray = new Button[this.rows, this.cols];
            this.CreateGameLayOut();
        }

        /// <summary>
        /// this method create layout for game and fill the data.
        /// </summary>
        public void CreateGameLayOut()
        {
            this.p1.Text = "X:" + this.player1 + ":";
            this.p2.Text = "O:" + this.player2 + ":";

            this.columnIncreament = 12;
            for (int i = 0; i < this.cols; i++)
            {
                Button headerBtn = new Button();
                headerBtn.Click += this.HeaderBtn_Click;

                headerBtn.Text = i + string.Empty;
                headerBtn.Name = i + string.Empty;
                headerBtn.Width = 40;
                headerBtn.Location = new Point(this.columnIncreament, 50);
                headerBtn.Visible = true;
                this.Controls.Add(headerBtn);

                this.columnIncreament += 50;
            }

            this.rowIncreament = 100;
            this.columnIncreament = 12;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    Button dynamicButton = new Button();
                    dynamicButton.Name = i + ":" + j;
                    this.grid.Add(dynamicButton);
                    this.gridArray[i, j] = dynamicButton;

                    dynamicButton.Text = string.Empty;
                    dynamicButton.Enabled = true;
                    dynamicButton.Height = 40;
                    dynamicButton.Width = 40;
                    dynamicButton.Location = new Point(this.columnIncreament, this.rowIncreament);
                    dynamicButton.Visible = true;

                    this.Controls.Add(dynamicButton);
                    this.columnIncreament += 50;
                }

                this.columnIncreament = 12;
                this.rowIncreament += 42;
            }
        }

        /// <summary>
        /// this method trigger whenever header button clicked
        /// </summary>
        /// <param name="sender"> sender variable</param>
        /// <param name="e">e variable</param>
        private void HeaderBtn_Click(object sender, EventArgs e)
        {
            gameLogic.OnHeaderBtn(sender, grid, player1, player2, this, form1,gridArray, rows, cols);
        }

     

        /// <summary>
        /// constructor called when click on form.
        /// </summary>
        /// <param name="sender">sender variable</param>
        /// <param name="e">e variable</param>
        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}