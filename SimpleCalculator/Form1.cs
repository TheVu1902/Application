using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double resultValue = 0;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "1") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "2") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "3") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }
    }
}
