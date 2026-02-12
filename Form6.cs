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
    public partial class Form6 : Form
    {
        int sum = 0, lh = 0;
        int sh = 0;
        double avg = 0;
        int toh = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //group Box (sub and lab marks )
        }
        //numeric up down : num of sub
        private void subup_ValueChanged(object sender, EventArgs e)
        {
            {
                if (subup.Value == 1)
                {
                    sub1up.Visible = true;//one 
                    sub2up.Visible = false;
                    sub3up.Visible = false;
                    sub4up.Visible = false;
                    sub5up.Visible = false;
                    sub6up.Visible = false;
                    sub1.Visible = true;
                    sub2.Visible = false;
                    sub3.Visible = false;
                    sub4.Visible = false;
                    sub5.Visible = false;
                    sub6.Visible = false;
                    sh = 3;

                }
                else if (subup.Value == 2)
                {
                    sub1up.Visible = true;
                    sub2up.Visible = true;//two
                    sub3up.Visible = false;
                    sub4up.Visible = false;
                    sub5up.Visible = false;
                    sub6up.Visible = false;
                    sub1.Visible = true;
                    sub2.Visible = true;
                    sub3.Visible = false;
                    sub4.Visible = false;
                    sub5.Visible = false;
                    sub6.Visible = false;
                    sh = 6;


                }
                else if (subup.Value == 3)
                {
                    sub1up.Visible = true;
                    sub2up.Visible = true;
                    sub3up.Visible = true;//three
                    sub4up.Visible = false;
                    sub5up.Visible = false;
                    sub6up.Visible = false;
                    sub1.Visible = true;
                    sub2.Visible = true;
                    sub3.Visible = true;
                    sub4.Visible = false;
                    sub5.Visible = false;
                    sub6.Visible = false;
                    sh = 9;


                }
                else if (subup.Value == 4)
                {
                    sub1up.Visible = true;
                    sub2up.Visible = true;
                    sub3up.Visible = true;
                    sub4up.Visible = true;//four
                    sub5up.Visible = false;
                    sub6up.Visible = false;
                    sub1.Visible = true;
                    sub2.Visible = true;
                    sub3.Visible = true;
                    sub4.Visible = true;
                    sub5.Visible = false;
                    sub6.Visible = false;
                    sh = 12;


                }
                else if (subup.Value == 5)
                {
                    sub1up.Visible = true;
                    sub2up.Visible = true;
                    sub3up.Visible = true;
                    sub4up.Visible = true;
                    sub5up.Visible = true;//five
                    sub6up.Visible = false;
                    sub1.Visible = true;
                    sub2.Visible = true;
                    sub3.Visible = true;
                    sub4.Visible = true;
                    sub5.Visible = true;
                    sub6.Visible = false;
                    sh = 15;


                }
                else if (subup.Value == 6)
                {
                    sub1up.Visible = true;
                    sub2up.Visible = true;
                    sub3up.Visible = true;
                    sub4up.Visible = true;
                    sub5up.Visible = true;
                    sub6up.Visible = true;//six
                    sub1.Visible = true;
                    sub2.Visible = true;
                    sub3.Visible = true;
                    sub4.Visible = true;
                    sub5.Visible = true;
                    sub6.Visible = true;
                    sh = 18;


                }
            }

        }
        //numeric up down : num of lab 
        private void labup_ValueChanged(object sender, EventArgs e)
        {
            {
                if (labup.Value == 1)
                {
                    lab1up.Visible = true;//one 
                    lab2up.Visible = false;
                    lab3up.Visible = false;
                    lab4up.Visible = false;
                    lab5up.Visible = false;
                    lab1.Visible = true;
                    lab2.Visible = false;
                    lab3.Visible = false;
                    lab4.Visible = false;
                    lab5.Visible = false;
                    lh = 1;
                }
                else if (labup.Value == 2)
                {
                    lab1up.Visible = true;
                    lab2up.Visible = true;//two
                    lab3up.Visible = false;
                    lab4up.Visible = false;
                    lab5up.Visible = false;
                    lab1.Visible = true;
                    lab2.Visible = true;
                    lab3.Visible = false;
                    lab4.Visible = false;
                    lab5.Visible = false;
                    lh = 2;
                }
                else if (labup.Value == 3)
                {
                    lab1up.Visible = true;
                    lab2up.Visible = true;
                    lab3up.Visible = true;//three
                    lab4up.Visible = false;
                    lab5up.Visible = false;
                    lab1.Visible = true;
                    lab2.Visible = true;
                    lab3.Visible = true;
                    lab4.Visible = false;
                    lab5.Visible = false;
                    lh = 3;
                }
                else if (labup.Value == 4)
                {
                    lab1up.Visible = true;
                    lab2up.Visible = true;
                    lab3up.Visible = true;
                    lab4up.Visible = true;//four
                    lab5up.Visible = false;
                    lab1.Visible = true;
                    lab2.Visible = true;
                    lab3.Visible = true;
                    lab4.Visible = true;
                    lab5.Visible = false;
                    lh = 4;
                }
                else if (labup.Value == 5)
                {
                    lab1up.Visible = true;
                    lab2up.Visible = true;
                    lab3up.Visible = true;
                    lab4up.Visible = true;
                    lab5up.Visible = true;//five
                    lab1.Visible = true;
                    lab2.Visible = true;
                    lab3.Visible = true;
                    lab4.Visible = true;
                    lab5.Visible = true;
                    lh = 5;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lab1t_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub1up_ValueChanged(object sender, EventArgs e)//one sub
        {
            sum += Convert.ToInt32(sub1up.Value) * 3;
        }

        private void sub2up_ValueChanged(object sender, EventArgs e)//two sub
        {
            sum += Convert.ToInt32(sub2up.Value) * 3;
        }

        private void sub3up_ValueChanged(object sender, EventArgs e)//three sub
        {
            sum += Convert.ToInt32(sub3up.Value) * 3;
        }

        private void sub4up_ValueChanged(object sender, EventArgs e)//fournsub
        {
            sum += Convert.ToInt32(sub4up.Value) * 3;
        }

        private void sub5up_ValueChanged(object sender, EventArgs e)//six sub
        {
            sum += Convert.ToInt32(sub5up.Value) * 3;
        }

        private void sub6up_ValueChanged(object sender, EventArgs e)//five sub
        {
            sum += Convert.ToInt32(sub6up.Value) * 3;
        }

        private void lab1up_ValueChanged(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(lab1up.Value);
        }
        private void avgt_TextChanged(object sender, EventArgs e)
        {
            //text box :average
        }

        private void lab3up_ValueChanged_1(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(lab3up.Value);
        }

        private void lab2up_ValueChanged_1(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(lab2up.Value);
        }

        private void lab4up_ValueChanged_1(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(lab4up.Value);
        }

        private void lab5up_ValueChanged_1(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(lab5up.Value);
        }

        private void gradet_TextChanged(object sender, EventArgs e)
        {
            //text box :grade
        }

        private void subl_Click(object sender, EventArgs e)
        {
            //lable :" subject :"
        }

        private void labl_Click(object sender, EventArgs e)
        {
            //lable :"labs : "
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //course
        }

        private void average_Click(object sender, EventArgs e)
        {
            //lable :average
        }

        private void grade_Click(object sender, EventArgs e)
        {
            //lable : grade
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            //group box :(average,grade)
        }

        private void sub1_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void sub3_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void sub4_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void sub5_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void sub6_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void lab1_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void lab2_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void lab3_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void lab4_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void lab5_Click(object sender, EventArgs e)
        {
            //lable 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0; avg = 0;
            avgt.Text = null;
            gradet.Text = null;
            labup.Value = 0;
            subup.Value = 0;
            //
            sub1up.Value = 35;
            sub2up.Value = 35;
            sub3up.Value = 35;
            sub4up.Value = 35;
            sub5up.Value = 35;
            sub6up.Value = 35;
            //
            lab1up.Value = 35;
            lab2up.Value = 35;
            lab3up.Value = 35;
            lab4up.Value = 35;
            lab5up.Value = 35;
            //
            lab1up.Visible = false;
            lab2up.Visible = false;
            lab3up.Visible = false;
            lab4up.Visible = false;
            lab5up.Visible = false;
            lab1.Visible = false;
            lab2.Visible = false;
            lab3.Visible = false;
            lab4.Visible = false;
            lab5.Visible = false;
            lh = 0;
            //
            sub1up.Visible = false;
            sub2up.Visible = false;
            sub3up.Visible = false;
            sub4up.Visible = false;
            sub5up.Visible = false;
            sub6up.Visible = false;
            sub1.Visible = false;
            sub2.Visible = false;
            sub3.Visible = false;
            sub4.Visible = false;
            sub5.Visible = false;
            sub6.Visible = false;
            sh = 0;
            toh = 0;


        }

        private void submit_Click(object sender, EventArgs e)//submit
        {
            avgt.Text = "";
            toh = sh + lh;
            avg = Convert.ToDouble(sum) / toh;
            avgt.Text = avg.ToString();
            if (avg >= 84 && avg <= 100)
                gradet.Text = "Excellent";
            else if (avg >= 76 && avg < 84)
                gradet.Text = "very good";
            else if (avg >= 68 && avg < 76)
                gradet.Text = "good";
            else if (avg >= 60 && avg < 68)
                gradet.Text = "pass high";
            else if (avg >= 50 && avg < 60)
                gradet.Text = "pass";
            else
                gradet.Text = "failed";

        }
    }
}
