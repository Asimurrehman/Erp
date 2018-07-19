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
    public partial class Form11 : Form
    {
        Form2 f2 = new Form2();
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Text = "INVOICE";

           
            int c = 0;

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(InvoiceID) from Invoice ", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString(); //+ "-" + System.DateTime.Today.Year; 
            OleDbCommand cmdd = new OleDbCommand("Select GRNID from GRN where Status ='Close' ", f2.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                comboBox1.Items.Add(drr["GRNID"]).ToString();
            }



            f2.oleDbConnection1.Close();

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

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from GRN where GRNID = '" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox2.Text = dr["VID"].ToString();
                textBox3.Text = dr["VName"].ToString();
                textBox4.Text = dr["GRDate"].ToString();
                textBox5.Text = dr["POID"].ToString();

            }
            f2.oleDbConnection1.Close();


              f2.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select * from PO where TotalAmount = @TotalAmount", f2.oleDbConnection1);
            cmd1.Parameters.AddWithValue("TotalAmount", textBox6.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox6.Text = dr1["TotalAmount"].ToString();
                

            }
            f2.oleDbConnection1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int price = Convert.ToInt32(textBox6.Text);
            int disc = Convert.ToInt32(textBox7.Text);
            int discount = (price * disc) / 100;
            int d = price - discount;
            textBox8.Text = d.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Invoice(InvoiceID,GRNID,VendorID,VendorName,GRNDate,AmountPayable,POID) values(@InvoiceID,@GRNID,@VendorID,@VendorName,@GRNDate,@AmountPayable,@POID)", f2.oleDbConnection1);

                cmd.Parameters.AddWithValue("@InvoiceID", textBox1.Text);
                cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);
                cmd.Parameters.AddWithValue("@VendorID", textBox2.Text);
                cmd.Parameters.AddWithValue("@VendorName", textBox3.Text);
                cmd.Parameters.AddWithValue("@GRNDate", textBox4.Text);
                cmd.Parameters.AddWithValue("@AmountPayable", textBox8.Text);
                cmd.Parameters.AddWithValue("@POID", textBox5.Text);

                cmd.ExecuteNonQuery();

                f2.oleDbConnection1.Close();
                MessageBox.Show("INVOICE IS CREATED");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
