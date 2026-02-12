using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pro01
{
    public partial class Form3 : Form
    {
        string name = null;
        string ID = null;
       

        public Form3(string name ,string ID)
        {
            InitializeComponent();
            this.name = name;
            this.ID = ID;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();//close 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)//My information 
        {
           
                this.Hide();
                Form2 f2 = new Form2(name,ID);
                f2.ShowDialog();
                f2 = null;
                this.Show();
            

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)//Tree plan
        {
            this.Hide();
            Form4 f4 = new Form4(name,ID);
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)//Definition of specialization
        {
            
                this.Hide();
                Form5 f5 = new Form5(name, ID);
                f5.ShowDialog();
                f5 = null;
                this.Show();
                
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)//Calculation of the rate 
        {
            this.Hide();
            Form6 f6 =new Form6 ();
            f6.ShowDialog();
            f6 = null;
            this.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //label : Student Assistant 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label : Student Assistant
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //logo
        }
    }
}
