﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcıadı" && textBox2.Text == "sifre") 
            {
                Form2 form2 = new Form2();
                form2.Show();
                

            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
