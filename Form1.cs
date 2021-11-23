using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        //Read in names
        public static string pOne, pTwo, pTwoDefault, POneDefault;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(playerOne.Text) || string.IsNullOrWhiteSpace(playerTwo.Text))
            {
                MessageBox.Show("Please fill out the text boxes.");
                return;
            }
            pOne = playerOne.Text;
            pTwo = playerTwo.Text;
            // close form after
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
