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
    public partial class frmDeleteUser : DevComponents.DotNetBar.Office2007RibbonForm
    {
        Entities db = new Entities();
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                string userName = txtUserName.Text;
                string passWord = txtPassWord.Text;
                var user = db.NhanViens.Where(s => s.MaNv == userName && s.MatKhau == passWord).FirstOrDefault();
                db.NhanViens.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                this.Close();
                frmMain frm = new frmMain();
                frm.Close();
                frmLogin.instance.Show();
                
            }
            catch
            {

                MessageBox.Show("Xóa thất bại");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
