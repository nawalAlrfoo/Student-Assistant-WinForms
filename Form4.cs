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

    public partial class Form4 : Form
    {
        public Form4(string id, string name)
        {
            InitializeComponent();
            int num4 = Convert.ToInt32(id.Substring(8, 1));
            if (num4 == 1)//cis
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

            }
            else if (num4 == 2)//csd
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            else if (num4 == 3)//ai
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;

            }
            else if (num4 == 4)//cs
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;

            }
            else if (num4 == 5)//cys
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();//close
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
