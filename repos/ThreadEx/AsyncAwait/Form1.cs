using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int countChar()
        {
            int count = 0;
            StreamReader sr = new StreamReader("C:\\c#\\c programs.txt");
            string word= sr.ReadToEnd();
            count=word.Length;
            Thread.Sleep(4000);
            return count;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(countChar);
            task.Start();
            
            label3.Text="Processing...";
            int count = await task;
            label3.Text="Number of characters:"+count.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
