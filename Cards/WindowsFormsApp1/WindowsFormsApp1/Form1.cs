using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
  
        private void PB5_Click(object sender, EventArgs e)
        {
            ClosestToCards.Text = "Red Joker";
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            ClosestToCards.Text = "King Of Clubs"; 
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            ClosestToCards.Text = "Queen of Diamonds";
        }

        private void PB2_Click(object sender, EventArgs e)
        {
            ClosestToCards.Text = "Jack of Hearts";
        }

        private void PB1_Click(object sender, EventArgs e)
        {
            ClosestToCards.Text = "Ace of Spades";
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
