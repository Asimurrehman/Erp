using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "LOGIN FORM ";
            this.label1.Text = "User Name";
            this.label2.Text = "Passward";
            this.button1.Text = "Login";
            this.label3.Text = "LOGIN FORM";



            this.textBox2.PasswordChar = '*';
            button1.Cursor = Cursors.Hand;

            button1.FlatStyle = FlatStyle.Flat;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {

                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();

            }
            else {

                MessageBox.Show("YOUR USERNAME AND PASSWARD IS RONG");
            }
        }
    }
}
