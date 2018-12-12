using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanTraSua.Model;

namespace QuanLyBanTraSua.MyForm
{
    
    public partial class frmDangki : Form
    {
        DoAnEntities db = new DoAnEntities();
        private TextBox txtMaNV;
        private TextBox txtUserName;
        private TextBox txtPhone;
        private TextBox txtAdd;
        private TextBox txtPassword;
        private TextBox txtChucVu;
        private Button btnRegiter;

        
        public frmDangki()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.btnRegiter = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(12, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 16);
            label2.TabIndex = 0;
            label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(12, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 16);
            label3.TabIndex = 0;
            label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(12, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 16);
            label4.TabIndex = 0;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(12, 203);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 16);
            label5.TabIndex = 0;
            label5.Text = "Mật Khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(12, 248);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 16);
            label6.TabIndex = 0;
            label6.Text = "Chức Vụ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(156, 37);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(258, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(156, 161);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(258, 20);
            this.txtAdd.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(156, 248);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(258, 20);
            this.txtChucVu.TabIndex = 6;
            // 
            // btnRegiter
            // 
            this.btnRegiter.BackColor = System.Drawing.Color.White;
            this.btnRegiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegiter.ForeColor = System.Drawing.Color.Black;
            this.btnRegiter.Location = new System.Drawing.Point(462, 272);
            this.btnRegiter.Name = "btnRegiter";
            this.btnRegiter.Size = new System.Drawing.Size(75, 23);
            this.btnRegiter.TabIndex = 7;
            this.btnRegiter.Text = "Đăng Kí";
            this.btnRegiter.UseVisualStyleBackColor = false;
            this.btnRegiter.Click += new System.EventHandler(this.btnRegiter_Click);
            // 
            // frmDangki
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QuanLyBanTraSua.Properties.Resources.gong_cha_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(571, 307);
            this.Controls.Add(this.btnRegiter);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegiter_Click(object sender, EventArgs e)
        {
            
            string userName = txtMaNV.Text;
            string passWord = txtPassword.Text;
            string Add = txtAdd.Text;
            string Phone = txtPhone.Text;
            string name = txtUserName.Text;
            string  Chucvu = txtChucVu.Text;

            var user = db.NhanViens.Where(s => s.MaNv == userName && s.MatKhau == passWord && s.SDT == Phone && s.TenNV == name && s.ChucVu == Chucvu && s.DiaChi == Add ).FirstOrDefault();
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
                        this.Close();
                        frmLogin.instance.Show();

            }
            else
                {
                    MessageBox.Show("Đăng ký thất bại");
                    frmLogin.instance.Show();
                    this.Hide();
                }
        }
    }
}
