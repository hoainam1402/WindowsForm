namespace QuanLyQuanTraSua.MyForm
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbtLogin = new DevComponents.DotNetBar.ButtonX();
            this.tbtRegiter = new DevComponents.DotNetBar.ButtonX();
            this.tbtExit = new DevComponents.DotNetBar.ButtonX();
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
            this.ribbonControl1.Size = new System.Drawing.Size(410, 28);
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
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Cursor = System.Windows.Forms.Cursors.No;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(17, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.White;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tài Khoản";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(17, 103);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mật Khẩu";
            // 
            // txtMaNv
            // 
            // 
            // 
            // 
            this.txtMaNv.Border.Class = "TextBoxBorder";
            this.txtMaNv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNv.Location = new System.Drawing.Point(116, 50);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.PreventEnterBeep = true;
            this.txtMaNv.Size = new System.Drawing.Size(172, 20);
            this.txtMaNv.TabIndex = 1;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(116, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // tbtLogin
            // 
            this.tbtLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtLogin.Location = new System.Drawing.Point(326, 47);
            this.tbtLogin.Name = "tbtLogin";
            this.tbtLogin.Size = new System.Drawing.Size(75, 23);
            this.tbtLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtLogin.TabIndex = 3;
            this.tbtLogin.Text = "Đăng Nhập";
            this.tbtLogin.Click += new System.EventHandler(this.tbtLogin_Click);
            // 
            // tbtRegiter
            // 
            this.tbtRegiter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtRegiter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtRegiter.Location = new System.Drawing.Point(326, 89);
            this.tbtRegiter.Name = "tbtRegiter";
            this.tbtRegiter.Size = new System.Drawing.Size(75, 23);
            this.tbtRegiter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtRegiter.TabIndex = 4;
            this.tbtRegiter.Text = "Đăng Ký";
            this.tbtRegiter.Click += new System.EventHandler(this.tbtRegiter_Click);
            // 
            // tbtExit
            // 
            this.tbtExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtExit.Location = new System.Drawing.Point(326, 134);
            this.tbtExit.Name = "tbtExit";
            this.tbtExit.Size = new System.Drawing.Size(75, 23);
            this.tbtExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtExit.TabIndex = 5;
            this.tbtExit.Text = "Thoát";
            this.tbtExit.Click += new System.EventHandler(this.tbtExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanTraSua.Properties.Resources.privileges_gong_cha;
            this.BackgroundImageUnderCaption = true;
            this.ClientSize = new System.Drawing.Size(420, 188);
            this.Controls.Add(this.tbtExit);
            this.Controls.Add(this.tbtRegiter);
            this.Controls.Add(this.tbtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.ButtonX tbtLogin;
        private DevComponents.DotNetBar.ButtonX tbtRegiter;
        private DevComponents.DotNetBar.ButtonX tbtExit;
    }
}