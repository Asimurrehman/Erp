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
    public partial class Form5 : Form
    {
        Form2 f2 = new Form2();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            this.Text = "SEARCH FOR VENDOR";
            this.button1.Text = "VENDOR";
            this.button2.Text = "PURCHASE ORDER";
            this.button3.Text = "GRN";
            this.button4.Text = "INVOICE";
            this.button5.Text = "BACK TO MENU";





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



            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from vendor", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["VID"].ToString());

            }
            f2.oleDbConnection1.Close();









        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where VID='" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                comboBox1.Text = (dr["VID"].ToString());
                textBox1.Text = (dr["VName"].ToString());
                textBox2.Text = (dr["VCode"].ToString());
                textBox3.Text = (dr["VCity"].ToString());
                textBox4.Text = (dr["PH1"].ToString());
                textBox5.Text = (dr["PH2"].ToString());
                textBox6.Text = (dr["VAddress"].ToString());
                textBox7.Text = (dr["CPName"].ToString());
                textBox8.Text = (dr["CPPH"].ToString());
                textBox9.Text = (dr["VEmail"].ToString());
                textBox10.Text = (dr["VFax"].ToString());
                textBox11.Text = (dr["VGroup"].ToString());
                textBox12.Text = (dr["VStatus"].ToString());

            }
            f2.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form9 f9 = new Form9();
            f9.Show();
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
    }
}
