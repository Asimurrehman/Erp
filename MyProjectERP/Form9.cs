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
    public partial class Form9 : Form
    {
        Form2 f2 = new Form2();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Text = "PURCHASE ORDER";



            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VDept from PO", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["VDept"].ToString());

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(poid) from po where vdept='" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox1.Text == "Consumer")
            {
                textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "HR")
            {
                textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "IT")
            {
                textBox1.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            f2.oleDbConnection1.Close();

            int i = 0;
            f2.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select count(vid) from po where vdept='" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                i = Convert.ToInt32(drr[0]);
                i++;
            }

            if (comboBox1.Text == "Consumer")
            {
                textBox4.Text = "0" + i.ToString();

            }

            if (comboBox1.Text == "Sales")
            {
                textBox4.Text = "0" + i.ToString();
            }

            if (comboBox1.Text == "HR")
            {
                textBox4.Text = "0" + i.ToString(); ;
            }
            f2.oleDbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into PO(VDept,POID,VName,VContectPerson,DDate,VID,PODate,Approve,TotalAmount) values(@VDept,@POID,@VName,@VContactPerson,@DDate,@VID,@PODate,@Approve,@TotalAmount)", f2.oleDbConnection1);
                cmd.Parameters.AddWithValue("@VDept", comboBox1.Text);
                cmd.Parameters.AddWithValue("@POID", textBox1.Text);
                cmd.Parameters.AddWithValue("@VName", textBox2.Text);
                cmd.Parameters.AddWithValue("@VContectPerson", textBox3.Text);
                cmd.Parameters.AddWithValue("@DDate", dateTimePicker1);
                cmd.Parameters.AddWithValue("@VID", textBox4.Text);
                cmd.Parameters.AddWithValue("@PODate", dateTimePicker2);
                cmd.Parameters.AddWithValue("@Approve", textBox5.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", textBox6.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show(":Your Purchase Order Is Create:");
                f2.oleDbConnection1.Close();

                Form12 f12 = new Form12();
                f12.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
