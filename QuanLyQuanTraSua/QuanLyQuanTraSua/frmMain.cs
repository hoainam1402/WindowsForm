using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.MyForm;
using QuanLyQuanTraSua.Model;

namespace QuanLyQuanTraSua
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        Entities db = new Entities();

        NhanVien nhanVien = new NhanVien();
        public frmMain()
        { 
            InitializeComponent();
        }
        public frmMain(NhanVien nv)
        {
            nhanVien = nv;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbtExit_Click(object sender, EventArgs e)
        {
            frmDeleteUser frm = new frmDeleteUser();
            frm.Show();
        }

        private void tbtChangePassword_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmLogin.instance.Show();
        }

        private void tbtDelete_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(nhanVien);
            frm.Show();
        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem1_Click_2(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void ribbonBar8_ItemClick(object sender, EventArgs e)
        {

        }

        private void tbtThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            QlyMon ql = new QlyMon();
            ql.Show();
        }
    }
}
