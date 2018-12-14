using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.Model;

namespace QuanLyQuanTraSua.MyForm
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007RibbonForm
    {
        Entities db = new Entities();
        public frmLogin()
        {
            instance = this;
            InitializeComponent();
        }
        public static frmLogin instance;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbtExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void tbtLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtMaNv.Text;
                string pasword = txtPassword.Text;
                var user = db.NhanViens.Where(s => s.MaNv == username && s.MatKhau == pasword).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
               
            }
            catch
            {   
                MessageBox.Show("Đăng nhập không thành công"); 
            }
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void tbtRegiter_Click(object sender, EventArgs e)
        {
            
            frmRegiter frm = new frmRegiter();
            frm.Show();
            this.Hide();
        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
