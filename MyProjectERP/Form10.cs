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
    public partial class Form10 : Form
    {
        Form2 f2 = new Form2();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Text = "GRN";

            int c = 0;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(GRNID) from GRN ", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
                  
            
            
            }

            textBox1.Text = "GRN-0" + c.ToString();



            OleDbCommand cmd1 = new OleDbCommand("select POID from PO where Status='Open'", f2.oleDbConnection1);
            OleDbDataReader dr1= cmd1.ExecuteReader();
            while (dr1.Read())
            {

                comboBox1.Items.Add(dr1["POID"]).ToString();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from PO where POID='" + comboBox1.Text + "'", f2.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = (dr["VID"].ToString());
                    textBox3.Text = (dr["VName"].ToString());
                    dateTimePicker1.Text = (dr["DDate"].ToString());
                    //dateTimePicker2.Text = (dr["GRDate"].ToString());


                }

                OleDbDataAdapter da = new OleDbDataAdapter("select * from POProducts", f2.oleDbConnection1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                f2.oleDbConnection1.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into GRN(GRNID,POID,VID,VName,DDate,GRDate) values(@GRNID,@POID,@VID,@VName,@DDate,@GRDate)", f2.oleDbConnection1);
                cmd.Parameters.AddWithValue("@POID", comboBox1.Text);
                cmd.Parameters.AddWithValue("@GRNID", textBox1.Text);
                cmd.Parameters.AddWithValue("@VID", textBox2.Text);
                cmd.Parameters.AddWithValue("@VName", textBox3.Text);
                cmd.Parameters.AddWithValue("DDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("GRDate", dateTimePicker2.Text);

                cmd.ExecuteNonQuery();


                OleDbCommand cmd2 = new OleDbCommand("update PO set Status='Close' where POID=@POID", f2.oleDbConnection1);

                f2.oleDbConnection1.Close();
                MessageBox.Show("GRN IS CREATED");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
