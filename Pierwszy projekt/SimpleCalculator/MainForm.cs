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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacji dodawanie:" + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {

        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {

        }

        private void MulButton_Click(object sender, EventArgs e)
        {

        }
    }
}
