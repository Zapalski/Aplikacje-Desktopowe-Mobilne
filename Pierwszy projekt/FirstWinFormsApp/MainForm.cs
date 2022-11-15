using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Witaj w pierwszym programie WinForms");

            string strAge = textBoxWiek.Text;
            if (string.IsNullOrWhiteSpace(strAge))
            {
                MessageBox.Show("Nie podano wieku");
                return;
            }
            int age;
            if (!int.TryParse(strAge, out age))
            {
                MessageBox.Show("Wiek nie jest liczbą");
                return;
            }
            if (age <1)
            {
                MessageBox.Show("Podano wiek ujemny");
                return;
            }

            string message = "";
            if (age >= 18)
                message = "Jesteś pełnoletni";
            else
                message = "Jesteś niepełnoletni ";

            message = "Witaj" + textBoxName.Text + "w tym programie\n" + message;
            MessageBox.Show(message);
            
          



        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            string message = "Witaj " + textBoxName.Text + " w tym programie";
            MessageBox.Show(message);
            textBoxName.Text = "Jakub";
            labelName.Text = "Inny Tekst";
            Text = "Nowy Tekst Okna";
            ClientSize = new System.Drawing.Size(400, 400);
        }
    }
}
