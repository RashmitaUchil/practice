﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadEx
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            Thread.Sleep(3000);

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                listView1.Items.Add(i.ToString());
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
