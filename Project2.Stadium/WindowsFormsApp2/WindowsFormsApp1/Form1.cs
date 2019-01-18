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

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            TextA.Text="";
            TextB.Text = "";
            TextC.Text = "";

            Rev_A.Text = "";
            Rev_B.Text = "";
            Rev_C.Text = "";
            TextofTotal.Text = "";

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalRev_Click_1(object sender, EventArgs e)
        {
            decimal x = decimal.Parse(TextA.Text);
                x = x * 15;
                    Rev_A.Text = x.ToString("C");

            decimal y = decimal.Parse(TextB.Text);
                y = y * 12;
                    Rev_B.Text = y.ToString("C");


            decimal z = decimal.Parse(TextC.Text);
                z = z * 9;
                    Rev_C.Text = z.ToString("C");

            decimal sum = x + y + z;

            TextofTotal.Text = sum.ToString("C");


            



        }
    }
}
