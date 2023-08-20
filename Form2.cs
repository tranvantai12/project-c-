using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlybanhang.BAL;
using quanlybanhang.GUI;

namespace quanlybanhang
{
    public partial class Form2 : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
            Application.Exit(); 
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoaDonBan form = new frmHoaDonBan();
            form.Show();
            this.Hide();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Functions.Conenct();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu form = new frmDMChatLieu();
            form.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDKKhachHang form1 =new frmDKKhachHang();
            form1.ShowDialog();
            form1.MdiParent = this;
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien form1 = new frmDMNhanVien();
            form1.ShowDialog();
            form1.MdiParent = this;
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa form1 = new frmDMHangHoa();
            form1.ShowDialog();
            form1.MdiParent = this;
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan form1 = new frmHoaDonBan();
            form1.ShowDialog();
            form1.MdiParent = this;
        }
    }
}
