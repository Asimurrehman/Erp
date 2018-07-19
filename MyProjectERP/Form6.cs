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
    public partial class Form6 : Form
    {
        Form2 f2 = new Form2();
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            this.Text = "INSERT";


            int vid = 0;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select count(VID) From vendor", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                vid = Convert.ToInt32(dr[0]);
                vid++;

            }
            f2.oleDbConnection1.Close();
            this.comboBox1.Text = "vid 00" + "-" + vid + "-" + System.DateTime.Today.Year;

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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID,VName,VCode,VCity,PH1,PH2,VAddress,CPName,CPPH,VEmail,VFax,VGroup,VStatus)values(@VID,@VName,@VCode,@VCity,@PH1,@PH2,@VAddress,@CPName,@CPPH,@VEmail,@VFax,@VGroup,@VStaus);", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCode", textBox3.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox5.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox6.Text);
            cmd.Parameters.AddWithValue("@VAddress", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox8.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox10.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox11.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox12.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox13.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
