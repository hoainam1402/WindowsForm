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
using System.IO;    

namespace QuanLyQuanTraSua
{
    public partial class SearchNhanVien : Form
    {
        Entities db = new Entities();
        public SearchNhanVien()
        {
            InitializeComponent();
            dgvNV.AutoGenerateColumns = false;
        }

        private void SearchNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = db.NhanViens.SqlQuery(frmNhanVien.share).ToList();
        }

        private void SearchNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        public void SearchNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
