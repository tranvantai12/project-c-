using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlybanhang
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8D07BDCJ\SQLEXPRESS;Initial Catalog=quanlybanhang;User ID=sa;Password=sa");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From login where Username='"+textBox1.Text+"'and Password='"+textBox2.Text+"'",con);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                Form2 f = new Form2();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui nhập đầy đủ tài khoản mật khẩu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
