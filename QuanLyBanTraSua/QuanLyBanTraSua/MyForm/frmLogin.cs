using QuanLyBanTraSua.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanTraSua.MyForm
{
    public partial class frmLogin : Form
    {
        DoAnEntities db = new DoAnEntities();
       
        public frmLogin()
        {
            instance = this;
            InitializeComponent();
        }
        public static frmLogin instance;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            var user = db.NhanViens.Where(s => s.MaNv == userName && s.MatKhau == passWord).FirstOrDefault();
            if(user != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           frmDangki frm = new frmDangki();
            frm.Show();
            this.Hide();
        }
        
            private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                string userName = txtUserName.Text;
                string passWord = txtPassword.Text;
                var user = db.NhanViens.Where(s => s.MaNv == userName && s.MatKhau == passWord).FirstOrDefault();

                db.NhanViens.Remove(user);
                db.SaveChanges();

                MessageBox.Show("Xóa thành công");
            }
            catch 
            {

                MessageBox.Show("Xóa thất bại");
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            frmDoiMK frm = new frmDoiMK();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
