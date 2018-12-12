namespace QuanLyBanTraSua.MyForm
{
    partial class frmDoiMK
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbtYes = new DevComponents.DotNetBar.ButtonX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Nhân Viên";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 79);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mật Khẩu Cũ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 131);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Mật Khẩu Mới";
            // 
            // tbtYes
            // 
            this.tbtYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbtYes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbtYes.Location = new System.Drawing.Point(72, 184);
            this.tbtYes.Name = "tbtYes";
            this.tbtYes.Size = new System.Drawing.Size(75, 23);
            this.tbtYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbtYes.TabIndex = 1;
            this.tbtYes.Text = "Đồng ý";
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(128, 34);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PreventEnterBeep = true;
            this.txtMaNV.Size = new System.Drawing.Size(164, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(128, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtnewPassword
            // 
            // 
            // 
            // 
            this.txtnewPassword.Border.Class = "TextBoxBorder";
            this.txtnewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnewPassword.Location = new System.Drawing.Point(128, 132);
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PreventEnterBeep = true;
            this.txtnewPassword.Size = new System.Drawing.Size(164, 20);
            this.txtnewPassword.TabIndex = 2;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(251, 184);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(405, 238);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.txtnewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.tbtYes);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmDoiMK";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX tbtYes;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnewPassword;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}