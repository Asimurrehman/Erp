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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "ERP OPEN NOW";
            this.button1.Text = "VENDOR";
            this.button2.Text = "PURCHASE";
            this.button3.Text = "GRN";
            this.button4.Text = "INVOICE";
            this.button5.Text = "BACK TO MANU";

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

            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
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
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
    }
}
