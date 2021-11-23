using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //Displaying name on form
            label3.Text = Form1.pOne;
            label4.Text = Form1.pTwo;
            label5.Text = Form1.pOne;
            label6.Text = Form1.pTwo;

            this.Load += new System.EventHandler(this.form3_load);
        }
        //Score
        int countTurns = 0;
        int scoreOne = 0;
        int scoreTwo = 0;
        string playerOne = "O";
        string playerTwo = "X";
        string draw = "C";
        IDictionary<string, char> playerSymbol = new Dictionary<string, char>();
        private void form3_load(object sender, EventArgs e)
        {
            playerSymbol.Add("playerone", 'X');
            playerSymbol.Add("playertwo", 'O');
        }
        //Clearing board
        private void clearBoard()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        //Play again
        private void playAgain()
        {
            DialogResult dr = MessageBox.Show("Would you like to play agian? \nClicking No will end the game.", "Play Again", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                clearBoard();
            } 
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }
        //end game
        private void endGame(string symbol)
        {
            if (symbol == playerOne)
            {
                label11.Text = (Int32.Parse(label11.Text) + 1).ToString();
            }
            else if (symbol == playerTwo)
            {
                label12.Text = (Int32.Parse(label12.Text) + 1).ToString();
            }
            else if (symbol == draw)
            {
                label13.Text = (Int32.Parse(label13.Text) + 1).ToString();
            }
            playAgain();
        }

        //Determining the winner
        private void CheckWinner(string symbol)
        {
            //Getting correct horizontal
            if (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            else if (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol); ;
            }
            else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            //Getting correct vertically
            else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            //Getting correct Diaganally
            else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show(symbol + " Has Won the Game");
                endGame(symbol);
            }
            //Draw
            else if (button1.Text != ""
                && button2.Text != ""
                && button3.Text != ""
                && button4.Text != "" 
                && button5.Text != "" 
                && button6.Text != "" 
                && button7.Text != "" 
                && button8.Text != "" 
                && button9.Text != ""
                )
            {
                MessageBox.Show("The game has been a draw");
                endGame("C");
            }
        }
        //Determing either x or o in boxes
        void fnsymbol(object senderobj)
        {
            string text = ((Button)senderobj).Text;
            if (text == "")
            {
                if (countTurns % 2 == 0)
                {
                    ((Button)senderobj).Text = "O";

                }
                else
                {
                    ((Button)senderobj).Text = "X";
                }
                //determining the next player
                countTurns++;
                CheckWinner("O");
                CheckWinner("X");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
        //Displaying either x or o
        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
        private void label2_Click(object sender, EventArgs e, string value)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void label10_Click(object sender, EventArgs e)
        {
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}
