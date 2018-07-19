using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Form2 f2 = new Form2();
        public Form4()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "VENDOR OPEN NOW";
            this.button1.Text = "VENDOR";
            this.button2.Text = "PURCHASE";
            this.button3.Text = "GRN";
            this.button4.Text = "INVOICE";
            this.button5.Text = "BACK TO MENU";
            this.button6.Text = "SEARCH";
            this.button7.Text = "INSERT";
            this.button8.Text = "UPDATE";


            this.label1.Text = "VENDOR INFORMATION";

            
           

            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;

            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;

            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;

            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;

            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;


            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;


            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;


            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;



           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
