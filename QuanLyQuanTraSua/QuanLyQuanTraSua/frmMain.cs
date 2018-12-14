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
        private NhanVien user;

        public frmMain()
        {
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
            this.Close();
        }

        private void tbtChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.instance.Show();
        }

        private void tbtDelete_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }
    }
}
