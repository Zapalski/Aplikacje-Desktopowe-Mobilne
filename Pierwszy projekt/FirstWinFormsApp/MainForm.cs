﻿using System;
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
            textBoxName.Text = "Adam";
            labelName.Text = "Inny Tekst";
            Text = "Nowy Tekst Okna";
            ClientSize = new System.Drawing.Size(400, 400);
        }
    }
}
