using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace pro01
{
    public partial class Form1 : Form

    {



        public object texstBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();//close
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //text box :name 
        }

        private void guna2Button1_Click(object sender, EventArgs e)//sign in
        {
            string name = "", ID = "";//
            name = textBox5.Text;
            ID = textBox4.Text;
            bool test = true;
            Form3 f2 = new Form3(ID, name);//

            if (ID.Length !=12 || name.Length == 0) test = false;//note
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                int num = Convert.ToInt32(c);
                if (!(c >= 97 && c <= 122 || c >= 65 && c <= 90 || c == 32))
                {
                    test = false;
                    break;
                }


            }
            for (int i = 0; i < ID.Length; i++)
            {
                char c = ID[i];
                int num = Convert.ToInt32(c);
                if (!(num >= 48 && num <= 58))
                {
                    test = false;
                    break;
                }

            }

            if (test)
            {
                this.Hide();//hide the form
                f2.ShowDialog();//بمنع استخدام اي شاشة غير f2
                                //لحتى اغلاقها 
              //---------------------------------
                f2 = null;//delet data in the f2
                this.Show();//عرض الفورم هاد ._.
            }
            else
                MessageBox.Show("try agin");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ////label :Student Assistant 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //label :"Student name :"
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //lable :"Student ID Number : "
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //label :Student Assistant 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //logo
        }

        private void guna2CirclePictureBox1_Click_2(object sender, EventArgs e)
        {
            //p
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            //text Box :ID
        }
    }
}
