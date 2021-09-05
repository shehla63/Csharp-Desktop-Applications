namespace Connect4Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading.Tasks;

    class GameLogic
    {
        private int turn=0;
        Button[,] gridArray;
        private int tieCount=0;
        bool checkForTie = false;
        int rows;
        int cols;

        public void OnHeaderBtn(Object sender, List<Button> grid,string player1, string player2, Form2 form2, Form1 form1, Button[,] gridArray, int rows, int cols) 
        {
            Button btn = (Button)sender;
            int depth = 0;
            int location_I = 0;
            int location_J = 0;
            Button targetBtn = null;
            this.gridArray = gridArray;
            this.rows = rows;
            this.cols = cols;


            foreach (Button b in grid)
            {
                if (b.Name.Split(':')[1] == btn.Name)
                {
                    depth++;
                    targetBtn = b;
                    location_I = int.Parse(b.Name.Split(':')[0]);
                    location_J = int.Parse(b.Name.Split(':')[1]);
                }
            }

            if (depth > 0)
            {
                tieCount += 1;
                string text = this.GetTurn();
                targetBtn.Text = text;
                targetBtn.Name = text + ":" + text;
                bool result = this.CheckWin(location_I, location_J, text);

                if (result)
                {
                    if (text.Equals("X"))
                    {
                        this.RestartGame(player1 + " WON THE GAME", form2, form1);
                    }
                    else
                    {
                        this.RestartGame(player2 + " WON THE GAME", form2, form1);
                    }
                }
                else if (checkForTie && !result)
                {
                    this.RestartGame("Tie in a Game", form2, form1);
                }

                return;
            }
        }

        /// <summary>
        /// this method restart the game and all the variables....
        /// </summary>
        /// <param name="winner">inner variable </param>
        private void RestartGame(string winner, Form2 form2, Form1 form1)
        {
            tieCount = 0;
            checkForTie = false;
            Form3 form3 = new Form3(winner, form2, form1);
            form3.ShowDialog();
            if (form3.GetChoice().Equals("YES"))
            {
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.cols; j++)
                    {
                        this.gridArray[i, j].Text = string.Empty;
                        this.gridArray[i, j].Name = i + ":" + j;
                    }
                }
            }
        }

        /// <summary>
        /// this check win methods called each time when player plays a turn and it checks if someone has won the game.
        /// </summary>
        /// <param name="i">i variable</param>
        /// <param name="j">j variable</param>
        /// <param name="text">text variable</param>
        /// <returns>return Statement</returns>
        private bool CheckWin(int i, int j, string text)
        {
            int leftRight = this.CheckLeftRight(i, j, text);
            int topBottom = this.CheckTopBottom(i, j, text);
            bool diagonal = this.CheckDiagonal(i, j, text);

            if (leftRight >= 4 || topBottom >= 4 || diagonal)
            {
                return true;
            }
            else if (tieCount == (this.rows * this.cols))
            {
                checkForTie = true;
            }

            return false;
        }


        /// <summary>
        /// this methods checks left and right winning chance
        /// </summary>
        /// <param name="location_I">variable</param>
        /// <param name="location_J">variable</param>
        /// <param name="text">variable</param>
        /// <returns>return statement</returns>
        private int CheckLeftRight(int location_I, int location_J, string text)
        {
            int count = 0;
            int temp = location_J;
            while (location_J < this.cols - 1)
            {
                if (this.gridArray[location_I, location_J + 1].Name.Split(':')[0] == text)
                {
                    count++;
                    location_J++;
                }
                else
                {
                    break;
                }
            }

            location_J = temp;
            while (location_J - 1 > 0)
            {
                if (this.gridArray[location_I, location_J - 1].Name.Split(':')[0] == text)
                {
                    count++;
                    location_J--;
                }
                else
                {
                    break;
                }

            }

            return count + 1;
        }

        /// <summary>
        /// this methods checks top and bottom winning chance
        /// </summary>
        /// <param name="location_I">variable</param>
        /// <param name="location_J">variable</param>
        /// <param name="text">variable</param>
        /// <returns>returnStatement</returns>
        private int CheckTopBottom(int location_I, int location_J, string text)
        {
            int count = 0;
            int temp = location_I;
            while (location_I < this.rows - 1)
            {
                if (this.gridArray[location_I + 1, location_J].Name.Split(':')[0] == text)
                {
                    count++;
                    location_I++;
                }
                else
                {
                    break;
                }
            }

            location_I = temp;

            while (location_I - 1 > 0)
            {
                if (this.gridArray[location_I - 1, location_J].Name.Split(':')[0] == text)
                {
                    count++;
                    location_I--;
                }
                else
                {
                    break;
                }
            }

            return count + 1;
        }

        /// <summary>
        /// this methods checks diagonal winning chance
        /// </summary>
        /// <param name="location_I">variable</param>
        /// <param name="location_J">variable</param>
        /// <param name="text">variable</param>
        /// <returns>returnStatement</returns>
        private bool CheckDiagonal(int location_I, int location_J, string text)
        {
            int case1 = 0;

            int x = location_I - 1;
            int y = location_J + 1;
            while ((x + y) == (location_I + location_J) && x >= 0 && y < this.cols)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    case1++;
                    x--;
                    y++;
                }
                else
                {
                    break;
                }
            }

            x = location_I + 1;
            y = location_J - 1;
            while (x + y == location_I + location_J && x < this.rows && y >= 0)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    case1++;
                    x++;
                    y--;
                }
                else
                {
                    break;
                }
            }

            int case2 = 0;
            x = location_I - 1;
            y = location_J - 1;
            while (x == y && x >= 0 && y >= 0)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    case2++;
                    x--;
                    y--;
                }
                else
                {
                    break;
                }
            }

            x = location_I + 1;
            y = location_J + 1;
            while (x == y && x < this.rows && y < this.cols)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    case2++;
                    x++;
                    y++;
                }
                else
                {
                    break;
                }
            }

            int case3 = 0;
            x = location_I + 1;
            y = location_J + 1;
            int sum = location_I + location_J + 2;
            while (x + y == sum && x < this.rows && y < this.cols)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    sum += 2;
                    case3++;
                    x++;
                    y++;
                }
                else
                {
                    break;
                }
            }

            x = location_I - 1;
            y = location_J - 1;
            sum = location_I + location_J - 2;
            while (x + y == sum && x >= 0 && y >= 0)
            {
                if (this.gridArray[x, y].Name.Split(':')[0] == text)
                {
                    sum -= 2;
                    case3++;
                    x--;
                    y--;
                }
                else
                {
                    break;
                }
            }

            case1 += 1;
            case2 += 1;
            case3 += 1;

            if (case1 >= 4 || case2 >= 4 || case3 >= 4)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// methods to change the player turn
        /// </summary>
        /// <returns>it return X or O</returns>
        private string GetTurn()
        {
            turn++;
            return turn % 2 == 0 ? "O" : "X";
        }

    }
}
