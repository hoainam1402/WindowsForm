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
    public partial class frmRegiter : DevComponents.DotNetBar.Office2007RibbonForm
    {
        Entities db = new Entities();
        public frmRegiter()
        {
            InitializeComponent();
        }

        private void frmRegiter_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbtExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.instance.Show();
        }

        private void tbtYes_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtMaNv.Text;
                string passWord = txtPassword.Text;
                string Add = txtAdd.Text;
                string Phone = txtPhone.Text;
                string name = txtUsername.Text;
                string Chucvu = cmbchucvu.Text;
                if (txtMaNv.Text == "" || cmbchucvu.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtPhone.Text == "" || txtAdd.Text == "")
                {
                    MessageBox.Show("Chưa đủ thông tin đăng kí ");
                    frmLogin.instance.Show();
                    this.Hide();
                }
                var user = db.NhanViens.Where(s => s.MaNv == userName && s.MatKhau == passWord && s.SDT == Phone && s.TenNV == name && s.ChucVu == Chucvu && s.DiaChi == Add).FirstOrDefault();
                if (user == null)
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNv = userName;
                    nhanVien.MatKhau = passWord;
                    nhanVien.TenNV = name;
                    nhanVien.SDT = Phone;
                    nhanVien.DiaChi = Add;
                    nhanVien.ChucVu = Chucvu;
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công");
                    
                    frmLogin.instance.Show();
                    this.Close();
                }

            }
            catch
            {
                //MessageBox.Show("Đăng ký thất bại");
            }
        }
    }
}
