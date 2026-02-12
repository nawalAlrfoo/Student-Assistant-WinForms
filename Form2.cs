using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pro01
{
    public partial class Form2 : Form
    {
        string name = null;
        string ID = null;
        public Form2(string ID1, string name1)
        {

            InitializeComponent();
            name = name1;
            ID = ID1;
            textBox1.Text += "Hello student : " + name + Environment.NewLine;

            string num1 = ID.Substring(0, 3);//note
            if (num1 == "320")
            {
                textBox1.Text += "Student at Tafila Technical University." + Environment.NewLine;

            }
            
            int num2 = Convert.ToInt32(ID.Substring(3,3));//note

            if (num2 == 240)
            {
                textBox1.Text += "you is a freshman at the university (1) ." + Environment.NewLine;
                textBox1.Text += "You entered the university in 2024 ." + Environment.NewLine;
            }
            else if (num2 == 230)
            {
                textBox1.Text += "You're in your Second year (2) ." + Environment.NewLine;
                textBox1.Text += "You entered the university in 2023 ." + Environment.NewLine;
            }
            else if (num2 == 220)
            {
                textBox1.Text += "You're in your third year (3) ." + Environment.NewLine;
                textBox1.Text += "You entered the university in 2022 ." + Environment.NewLine;
            }
            else if (num2 == 210)
            {
                textBox1.Text += "You're in your fourth year (4) ." + Environment.NewLine;
                textBox1.Text += "You entered the university in 2021 ." + Environment.NewLine;
            }
            else
            {
                textBox1.Text += "You're in your fourth year (4) ." + Environment.NewLine;
                textBox1.Text += "You entered the university before the year 2021 ." + Environment.NewLine;
            }
            int num3 = Convert.ToInt32(ID.Substring(6, 2));
            if (num3 == 60) 
            { 
                textBox1.Text += "You are in the faculty of information technology  ." + Environment.NewLine;
                int num4 = Convert.ToInt32(ID.Substring(8, 1));
                     if (num4 == 1) textBox1.Text += "Your major at the Computer information system \"CIS\"" + Environment.NewLine;
                     else if (num4 == 2) textBox1.Text += "Your major at the Computing smart devices \"CSD\"" + Environment.NewLine;
                     else if (num4 == 3) textBox1.Text += "Your major at the Artificial intelligence \"AI\"" + Environment.NewLine;
                     else if (num4 == 4) textBox1.Text += "Your major at the Computer science \"CS\"" + Environment.NewLine;
                     else if (num4 == 5) textBox1.Text += "Your major at the Cyber security \"CYS\"" + Environment.NewLine;
            }
            textBox1.Text += "Your serial number in the university system : " + ID.Substring(9, 3) + " ."+ Environment.NewLine;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   //close
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Label :Student Assistant
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Label :Student Assistant
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();//skip
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text Box 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //logo
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //logo
        }
    }
}
