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
    public partial class Form14 : Form
    {
        Form2 f2 = new Form2();
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from Customer", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["CID"].ToString());

            }
            f2.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer where CID='" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                comboBox1.Text = (dr["CID"].ToString());
                textBox1.Text = (dr["Cname"].ToString());
                textBox2.Text = (dr["CAddress"].ToString());
                textBox3.Text = (dr["City"].ToString());
                textBox4.Text = (dr["PH1"].ToString());
                textBox5.Text = (dr["PH2"].ToString());
                textBox6.Text = (dr["ContectPerson"].ToString());
                textBox7.Text = (dr["CPPH"].ToString());
                textBox8.Text = (dr["CEmail"].ToString());
                textBox9.Text = (dr["CreditLimit"].ToString());
                textBox10.Text = (dr["CStatus"].ToString());
                textBox11.Text = (dr["CGroup"].ToString());
                

            }
            f2.oleDbConnection1.Close();
        }
    }
}
