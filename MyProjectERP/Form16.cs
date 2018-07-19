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
    public partial class Form16 : Form
    {
        Form2 conn = new Form2();
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("data has been inserted");
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select deptname from dept", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["deptname"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                //conn.oleDbConnection1.Open();
                //OleDbConnection cmd = new OleDbConnection("select cid from customer where cgroup=customer" , conn.oleDbConnection1);
        }
    }
}
