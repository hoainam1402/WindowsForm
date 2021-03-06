﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.Model;
using QuanLyQuanTraSua.MyForm;

namespace QuanLyQuanTraSua.MyForm
{


    public partial class frmChangePassword : DevComponents.DotNetBar.Office2007RibbonForm
    {
        NhanVien nhanVien = new NhanVien();
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private IContainer components;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPassword;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX tbtYes;
        private DevComponents.DotNetBar.ButtonX tbtExit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPass;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNv;
        Entities db = new Entities();
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(NhanVien nv)
        {
            nhanVien = nv;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbtYes = new DevComponents.DotNetBar.ButtonX();
            this.tbtExit = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(319, 25);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(174, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.Border.Class = "TextBoxBorder";
            this.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPassword.Location = new System.Drawing.Point(174, 182);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PreventEnterBeep = true;
            this.txtNewPassword.Size = new System.Drawing.Size(133, 20);
            this.txtNewPassword.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(19, 124);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mật Khẩu Hiện Tại";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(17, 176);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Mật Khẩu Mới";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(17, 235);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(123, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.Border.Class = "TextBoxBorder";
            this.txtNewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPass.Location = new System.Drawing.Point(174, 238);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.PreventEnterBeep = true;
            this.txtNewPass.Size = new System.Drawing.Size(133, 20);
            this.txtNewPass.TabIndex = 3;
            // 
            // tbtYes
            // 
            this.tbtYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtYes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtYes.Location = new System.Drawing.Point(58, 284);
            this.tbtYes.Name = "tbtYes";
            this.tbtYes.Size = new System.Drawing.Size(75, 23);
            this.tbtYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtYes.TabIndex = 4;
            this.tbtYes.Text = "Đồng ý";
            this.tbtYes.Click += new System.EventHandler(this.tbtYes_Click);
            // 
            // tbtExit
            // 
            this.tbtExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtExit.Location = new System.Drawing.Point(195, 284);
            this.tbtExit.Name = "tbtExit";
            this.tbtExit.Size = new System.Drawing.Size(75, 23);
            this.tbtExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtExit.TabIndex = 5;
            this.tbtExit.Text = "Thoát";
            this.tbtExit.Click += new System.EventHandler(this.tbtExit_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(17, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(98, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Mã Nhân VIên";
            // 
            // txtMaNv
            // 
            // 
            // 
            // 
            this.txtMaNv.Border.Class = "TextBoxBorder";
            this.txtMaNv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNv.Location = new System.Drawing.Point(172, 75);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.PreventEnterBeep = true;
            this.txtMaNv.Size = new System.Drawing.Size(133, 20);
            this.txtMaNv.TabIndex = 0;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // frmChangePassword
            // 
            this.BackgroundImage = global::QuanLyQuanTraSua.Properties.Resources.foody_mobile_gongcha_mb_jpg_157_635636065715423611;
            this.BackgroundImageUnderCaption = true;
            this.ClientSize = new System.Drawing.Size(329, 332);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.tbtExit);
            this.Controls.Add(this.tbtYes);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtMaNv.Text = nhanVien.MaNv;
            txtMaNv.Enabled = false;

        }

        private void tbtYes_Click(object sender, EventArgs e)
        {
            try
            {

                string password = txtPassword.Text;
                string newpasss = txtNewPassword.Text;
                string newpassword = txtNewPass.Text;
                //MessageBox.Show(password.ToString() + " " + nhanVien.MatKhau);
                if (nhanVien.MatKhau.Trim() != password.ToString())
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                    return;
                }
                else if (newpasss.Trim() != newpassword.Trim())
                {
                    MessageBox.Show("Mật khẩu mới nhập không khớp");
                    return;
                }
                else
                {
                    nhanVien.MatKhau = newpasss;
                    // db.Set<NhanVien>().Attach(nhanVien);
                    db.Database.ExecuteSqlCommand("Update NhanVien set MatKhau ='" + newpasss + "' where MaNV = '" + nhanVien.MaNv + "'");
                    db.SaveChanges();
                    MessageBox.Show("Đổi Mật Khẩu Thành Công !");
                    this.Close();
                    frmMain frm = new frmMain(nhanVien);
                    frm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đổi Mật Khẩu Không Thành Công !" + ex.Message);

            }


        }

        private void tbtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
