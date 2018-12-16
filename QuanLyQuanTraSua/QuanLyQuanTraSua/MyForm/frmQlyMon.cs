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
    public partial class frmQlyMon : Form
    {
        Entities context = new Entities();
        //DoAnEntities context = new DoAnEntities();
        
        public frmQlyMon()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
          
        }

        private void showds()
        {
            var ds = context.MonAns.ToList();
            dataGridView1.DataSource = ds;

        }
        private void search()
        {
            string name = this.txtKey.Text;
            {
                var sql = context.MonAns.SqlQuery("Select * from MonAn where TenMon like N'%" + txtKey.Text + "%'").ToList();
                dataGridView1.DataSource = sql;
            }
        }


        private void QlyMon_Load(object sender, EventArgs e)
        {
            showds();
        }

        private void btTim_Click_1(object sender, EventArgs e)
        {
            search();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
         
            frmFormThem a = new frmFormThem();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMA.Text = row.Cells[0].Value.ToString();
            txtTEN.Text = row.Cells[1].Value.ToString();
            txtGIA.Text = row.Cells[2].Value.ToString();
            txtMAL.Text = row.Cells[3].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtGIA.Text == "" || txtMA.Text == "" || txtTEN.Text == "")
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin Cần Sửa","Thông Báo",MessageBoxButtons.OK);
            else
            {
                context.Database.ExecuteSqlCommand("Update LoaiMon Set TenMon = N'" + txtTEN.Text + "' where  MaLoai =N'" + txtMAL.Text + "' ");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("Update MonAn Set TenMon =N'" + txtTEN.Text + "', GiaTien = '" + txtGIA.Text + "', MaMon =N'" + txtMA.Text + "' where MaLoai = N'" + txtMAL.Text + "'");
                context.SaveChanges();
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtGIA.Text == "" || txtMA.Text == "" || txtTEN.Text == "")
                MessageBox.Show("Vui Lòng Nhập Thông Tin Món Cần Xóa", "Thông Báo", MessageBoxButtons.OK);

            else
            {
                DialogResult DR = MessageBox.Show("Xác nhận xóa món?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DR == DialogResult.OK)
                {
                    context.Database.ExecuteSqlCommand("DELETE FROM MonAn where MaLoai =N'" + txtMAL.Text + "'");
                    context.SaveChanges();
                    context.Database.ExecuteSqlCommand("DELETE FROM LoaiMon where MaLoai =N'" + txtMAL.Text + "'");
                    context.SaveChanges();
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Xóa thất bại!");
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Xác nhận thoát?",
            "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DR == DialogResult.OK)
                this.Close();
            else MessageBox.Show("OK!");
        }
    }
}
