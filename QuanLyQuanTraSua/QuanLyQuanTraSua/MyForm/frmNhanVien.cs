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
using QuanLyQuanTraSua.Script;
using System.IO;


namespace QuanLyQuanTraSua
{
    public partial class frmNhanVien : Form
    {
        Entities db = new Entities();
        bool check = true;
        //private BindingSource bs;
        private static int local;
        public static string share;
        public frmNhanVien()
        {
            
            InitializeComponent();

            dgvListNV.AutoGenerateColumns = false;
        }
        private void sideNavItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvListNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.dgvListNV.Rows[e.RowIndex];
                txtID.Text = dgvListNV.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dgvListNV.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvListNV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvListNV.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                local = e.RowIndex;
            }
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                    if (check)
                    {
                        var lst = db.NhanViens.OrderBy(r => r.MaNv).ToList();
                        dgvListNV.DataSource = lst;
                    }
                    else
                    {
                        var lst = db.NhanViens.OrderByDescending(r => r.MaNv).ToList();
                        dgvListNV.DataSource = lst;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    if (btnSort.Text == "Tên Az")
                    {
                        var lst = db.NhanViens.OrderBy(r => r.TenNV).ToList();
                        dgvListNV.DataSource = lst;
                        btnSort.Text = "Tên Za";
                    }
                    else
                    {
                        var lst = db.NhanViens.OrderByDescending(r => r.TenNV).ToList();
                        dgvListNV.DataSource = lst;
                        btnSort.Text = "Tên Az";
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    if (check)
                    {
                        var lst = db.NhanViens.OrderBy(r => r.DiaChi).ToList();
                        dgvListNV.DataSource = lst;
                    }
                    else
                    {
                        var lst = db.NhanViens.OrderByDescending(r => r.DiaChi).ToList();
                        dgvListNV.DataSource = lst;
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    if (check)
                    {
                        var lst = db.NhanViens.OrderBy(r => r.SDT).ToList();
                        dgvListNV.DataSource = lst;
                    }
                    else
                    {
                        var lst = db.NhanViens.OrderByDescending(r => r.SDT).ToList();
                        dgvListNV.DataSource = lst;
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (check)
                    {
                        var lst = db.NhanViens.OrderBy(r => r.ChucVu).ToList();
                        dgvListNV.DataSource = lst;
                    }
                    else
                    {
                        var lst = db.NhanViens.OrderByDescending(r => r.ChucVu).ToList();
                        dgvListNV.DataSource = lst;
                    }
                }
                check = !check;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txtID.Text;
            string Add = txtDiaChi.Text;
            string Phone = txtSDT.Text;
            string name = txtHoTen.Text;
            if( userName ==""|| Add == "" || Phone == "" || name == "")
            {
                MessageBox.Show("Thông tin không được để trông", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = db.NhanViens.Where(s => s.MaNv == userName).FirstOrDefault();
            if (user != null)
            {
                //DataGridViewRow row = this.dgvListNV.Rows[local];
                var query = ("Update NhanVien set TenNV = N'" + txtHoTen.Text + "' ,DiaChi = N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "' where MaNV=N'" + txtID.Text + "'");
                db.Database.ExecuteSqlCommand(query);
                db.SaveChanges();
                Entities a = new Entities();
                var lst = a.NhanViens.ToList();
                dgvListNV.DataSource = lst;


            }
            else
            {
                MessageBox.Show("Không tìm thấy ID trong database","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (btnSort.Text == "Tên Az")
            {
                var lst = db.NhanViens.OrderBy(r => r.TenNV).ToList();
                dgvListNV.DataSource = lst;
                btnSort.Text = "Tên Za";
            }
            else
            {
                var lst = db.NhanViens.OrderByDescending(r => r.TenNV).ToList();
                dgvListNV.DataSource = lst;
                btnSort.Text = "Tên Az";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("Không được để trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string search = "Select * from NhanVien where TenNV like N'%" + txtSearch.Text + "%' or MaNV like N'%"+ txtSearch.Text + "%' or DiaChi like N'%"+ txtSearch.Text + "%'or SDT like N'%"+ txtSearch.Text + "%'";
            var user = db.NhanViens.SqlQuery(search).ToList();

                share = search;
                SearchNhanVien sear = new SearchNhanVien();
                Hide();
                sear.Show();


            
            //{ MessageBox.Show("Không tìm thấy ai", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error); }


        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            var lst = db.NhanViens.ToList();
            dgvListNV.DataSource = lst;
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không thay đổi được ID", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void InitTbl(DataTable myTbl)
        {
            myTbl.Columns.Add(new DataColumn("id"));
            myTbl.Columns.Add(new DataColumn("nam"));
            myTbl.Columns.Add(new DataColumn("add"));
            myTbl.Columns.Add(new DataColumn("phone"));

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            DataTable dt = new DataTable();
            InitTbl(dt);
            foreach (DataGridViewRow row in dgvListNV.Rows)
            {
                DataRow  dtrow = dt.NewRow();
             

                dtrow["id"] = row.Cells["MaNV"].Value.ToString();
                dtrow["nam"] = row.Cells["TenNV"].Value.ToString();
                dtrow["add"] = row.Cells["DiaChi"].Value.ToString();
                dtrow["phone"] = row.Cells["SDT"].Value.ToString();
                //dtrow[4] = row.Cells["ChucVu"].Value.ToString();
                dt.Rows.Add(dtrow);
            }
            excel.Export(dt, "Danh sach", "DANH SÁCH CÁC NHÂN VIÊN");
        }
    }
}
