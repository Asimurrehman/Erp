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
    public partial class Form12 : Form
    {

        string[] st = new string[50];
        int[] qty = new int[50];
        int count = 0;
        int total = 0;

        Form2 f2 = new Form2();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.Text = "PO PRODUCT";

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select poid from po", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["poid"].ToString());
            }
            f2.oleDbConnection1.Close();


            f2.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select pid from products", f2.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["pid"].ToString());
            }
            f2.oleDbConnection1.Close();

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(poid) from po where poid='" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox1.Text == "Cons_01_2010")
            {
                textBox1.Text = "Cons-01-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_10_2010")
            {
                textBox1.Text = "Cons-10-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Cons_02_2010")
            {
                textBox1.Text = "Cons-02-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Cons_07_2010")
            {
                textBox1.Text = "Cons-07-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_08_2010")
            {
                textBox1.Text = "Cons-08-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_12_2010")
            {
                textBox1.Text = "Cons-12-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_04_2010")
            {
                textBox1.Text = "HR-04-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_05_2010")
            {
                textBox1.Text = "HR-05-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_11_2010")
            {
                textBox1.Text = "HR-11-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_03_2010")
            {
                textBox1.Text = "Sal-03-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_06_2010")
            {
                textBox1.Text = "Sal-06-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_09_2010")
            {
                textBox1.Text = "Sal-09-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }
            f2.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid='" + comboBox2.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["pname"].ToString();
                textBox4.Text = dr["baseprice"].ToString();
            }
            f2.oleDbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text += comboBox2.Text + Environment.NewLine;
            textBox7.Text += textBox3.Text + Environment.NewLine;
            st[count] = comboBox2.Text;
            qty[count] = Convert.ToInt32(textBox3.Text);
            count++;
            total += Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox3.Text);
            textBox5.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try{
            f2.oleDbConnection1.Open();

            for (int i = 0; i < count; i++)
            {
                
                
                    OleDbCommand cmd = new OleDbCommand("insert into poproducts(pid,pqty,pname,poid) values(@pid,@pqty,@pname,@poid)", f2.oleDbConnection1);

                    cmd.Parameters.AddWithValue("@pid", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@pqty", textBox3.Text);
                    cmd.Parameters.AddWithValue("@pname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@poid", textBox1.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your PO Product Is Create");
                }
                f2.oleDbConnection1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
