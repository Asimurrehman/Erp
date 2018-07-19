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
    public partial class Form8 : Form
    {
        Form2 f2 = new Form2();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = "UPDATE";


            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from vendor", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["VID"].ToString());

            }
            f2.oleDbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("update vendor set VID=@VID, VName=@VName, VCode=@VCode, VCity=@VCity, PH1=@PH1, PH2=@PH2, VAddress=@VAddress, CPName=@CPName, CPPH=@CPPH, VEmail=@VEmail, VFax=@VFax, VGroup=@VGroup, VStatus=@VStatus where VID=@VID", f2.oleDbConnection1);

                cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
                cmd.Parameters.AddWithValue("@VName", textBox1.Text);
                cmd.Parameters.AddWithValue("@VCode", textBox2.Text);
                cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
                cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
                cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
                cmd.Parameters.AddWithValue("@VAddress", textBox6.Text);
                cmd.Parameters.AddWithValue("@CPName", textBox7.Text);
                cmd.Parameters.AddWithValue("@CPPH", textBox8.Text);
                cmd.Parameters.AddWithValue("@VEmail", textBox9.Text);
                cmd.Parameters.AddWithValue("@VFax", textBox10.Text);
                cmd.Parameters.AddWithValue("@VGroup", textBox11.Text);
                cmd.Parameters.AddWithValue("@VStatus", textBox12.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("data has been updated");
                f2.oleDbConnection1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
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
