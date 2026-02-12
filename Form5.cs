using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro01
{
    public partial class Form5 : Form
    {
        public Form5(string ID1, string name1)
        {
            InitializeComponent();
             string name = name1;
             string ID = ID1;
             string num =(ID.Substring(8, 1));

             int num4 = Convert.ToInt32(num);
             if (num4 == 1)//CIS
            {
                 textBox1.Text += "Computer information system \"CIS\" : " + Environment.NewLine;
                 textBox1.Text += "The specialization aims to equip students with the skills to design, implement, and manage information systems across various fields like accounting, finance, administration, and healthcare, serving institutions such as banks, universities, and hospitals.";
             }
             else if (num4 == 2)//CSD
            {
                 textBox1.Text += "Computing smart devices \"CSD\"" + Environment.NewLine;
                 textBox1.Text += "This program offers a strong theoretical foundation and practical training to prepare specialists in mobile computing, addressing the local and regional shortage of qualified professionals. It focuses on the analysis, design, development, maintenance, and management of mobile applications to meet market demands.";
             }
             else if (num4 == 3)//AI
            {
                 textBox1.Text += "Artificial intelligence \"AI\"" + Environment.NewLine;
                 textBox1.Text += "This specialization provides students with the knowledge and skills in data science to enhance organizational efficiency. It covers data analysis, big data handling, and decision-making, along with machine learning techniques for practical applications.";
             }
             else if (num4 == 4)//CS
            {
                 textBox1.Text += "Computer science \"CS\"" + Environment.NewLine;
                 textBox1.Text += "This specialization provides students with the knowledge and skills in data science to enhance organizational efficiency. It covers data analysis, big data handling, and decision-making, along with machine learning techniques for practical applications.";

             }
             else if (num4 == 5)//CYS
            {
                 textBox1.Text += "Cyber security \"CYS\"" + Environment.NewLine;
                 textBox1.Text += "It is the field specialized in protecting data, information, and systems from attacks or breaches that may occur over the internet. This includes securing networks, servers, devices, databases, and software against threats such as viruses, malware, cyberattacks, and hacking.";
             }
         }




         private void label2_Click(object sender, EventArgs e)
         {

         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void guna2Button2_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void pictureBox6_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Close();//close
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();//Close//skip
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Student Assistant 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //logo
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //Student Assistant 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //logo
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //
        }
    }
    }

