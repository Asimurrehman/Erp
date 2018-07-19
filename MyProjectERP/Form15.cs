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
    public partial class Form15 : Form
    {
        Form2 f2 = new Form2();
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

            int cid = 0;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select count(CID) From Customer", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cid = Convert.ToInt32(dr[0]);
                cid++;

            }
            f2.oleDbConnection1.Close();
            this.textBox1.Text = "vid 00" + "-" + cid + "-" + System.DateTime.Today.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Customer(CID,Cname,City,PH1,PH2,ContectPerson,CPPH,CEmail,CreditLimit,CStatus,CGroup)values(@CID,@Cname,@City,@PH1,@PH2,@ContectPerson,@CPPH,@CEmail,@CreditLimit,@CStatus,@CGroup);", f2.oleDbConnection1);
                cmd.Parameters.AddWithValue("@CID", textBox1);
                cmd.Parameters.AddWithValue("@Cname", textBox2.Text);
                cmd.Parameters.AddWithValue("@City", textBox3.Text);
                cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
                cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
                cmd.Parameters.AddWithValue("@ContectPerson", textBox6.Text);
                cmd.Parameters.AddWithValue("@CPPH", textBox7.Text);
                cmd.Parameters.AddWithValue("@CEmail", textBox8.Text);
                cmd.Parameters.AddWithValue("@CreditLimlt", textBox9.Text);
                cmd.Parameters.AddWithValue("@CStatus", textBox10.Text);
                cmd.Parameters.AddWithValue("@CGroup", textBox11.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data has been inserted");
                f2.oleDbConnection1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
