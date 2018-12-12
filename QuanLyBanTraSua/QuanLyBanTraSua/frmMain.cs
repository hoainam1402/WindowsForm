using QuanLyBanTraSua.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanTraSua.MyForm;

namespace QuanLyBanTraSua
{
    public partial class frmMain : Form
    {
        DoAnEntities db = new DoAnEntities();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var lst = db.NhanViens.ToList();
            dgvUsers.DataSource = lst;
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMaNV.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Tên nhân viên không tồn tại");
                return;
            }
        }

        private void contextMenuBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Không có");
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
