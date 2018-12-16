using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyQuanTraSua.MyForm;
using QuanLyQuanTraSua.Model;


namespace QuanLyQuanTraSua.MyForm
{
    public partial class frmFormThem : Form
    {
        Entities context = new Entities();
        public frmFormThem()
        {
            InitializeComponent();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "" || txtTenMon.Text == "" || txtGia.Text == "" || txtMaMon.Text == "")
                MessageBox.Show("Vui long nhap day du thong tin mon an", "Thong bao", MessageBoxButtons.OK);
            else
            {
                {
                    string Lmon = ("N'" + txtMaLoai.Text + "',N'" + txtTenMon.Text + "'");
                    string values = ("N'" + txtMaMon.Text + "',N'" + txtTenMon.Text + "',N'" + txtGia.Text + "',N'" + txtMaLoai.Text + "'");
                    context.Database.ExecuteSqlCommand("Insert into LoaiMon (MaLoai,TenMon) values (" + Lmon + ")");
                    context.SaveChanges();
                    context.Database.ExecuteSqlCommand("Insert into MonAn (MaMon,TenMon,GiaTien,MaLoai) values (" + values + ")");
                    context.SaveChanges();
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
