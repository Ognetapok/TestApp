﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Надосделать
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работает 1 кнопка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работает 2 кнопка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
   
 
    }
}
