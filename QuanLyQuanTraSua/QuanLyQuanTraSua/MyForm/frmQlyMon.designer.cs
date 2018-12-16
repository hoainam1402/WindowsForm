namespace QuanLyQuanTraSua.MyForm
{
    partial class frmQlyMon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSuaM = new System.Windows.Forms.Button();
            this.btXoaM = new System.Windows.Forms.Button();
            this.btThemM = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.txtMAL = new System.Windows.Forms.TextBox();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.GiaTien,
            this.MaLoai});
            this.dataGridView1.Location = new System.Drawing.Point(261, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 223);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Món";
            this.MaMon.Name = "MaMon";
            this.MaMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá";
            this.GiaTien.Name = "GiaTien";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(408, 100);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(217, 20);
            this.txtKey.TabIndex = 0;
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.Maroon;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.Transparent;
            this.btTim.Location = new System.Drawing.Point(631, 89);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(66, 42);
            this.btTim.TabIndex = 1;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập Món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm Món";
            // 
            // btSuaM
            // 
            this.btSuaM.Location = new System.Drawing.Point(-164, 262);
            this.btSuaM.Name = "btSuaM";
            this.btSuaM.Size = new System.Drawing.Size(86, 34);
            this.btSuaM.TabIndex = 10;
            this.btSuaM.Text = "Sửa";
            this.btSuaM.UseVisualStyleBackColor = true;
            // 
            // btXoaM
            // 
            this.btXoaM.Location = new System.Drawing.Point(-164, 203);
            this.btXoaM.Name = "btXoaM";
            this.btXoaM.Size = new System.Drawing.Size(86, 35);
            this.btXoaM.TabIndex = 11;
            this.btXoaM.Text = "Xóa Món";
            this.btXoaM.UseVisualStyleBackColor = true;
            // 
            // btThemM
            // 
            this.btThemM.Location = new System.Drawing.Point(-164, 142);
            this.btThemM.Name = "btThemM";
            this.btThemM.Size = new System.Drawing.Size(86, 37);
            this.btThemM.TabIndex = 12;
            this.btThemM.Text = "Thêm Món";
            this.btThemM.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(622, 164);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 38);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm Món";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(11, 218);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 42);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtMA
            // 
            this.txtMA.Location = new System.Drawing.Point(69, 51);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(143, 20);
            this.txtMA.TabIndex = 13;
            // 
            // txtMAL
            // 
            this.txtMAL.Location = new System.Drawing.Point(69, 161);
            this.txtMAL.Name = "txtMAL";
            this.txtMAL.ReadOnly = true;
            this.txtMAL.Size = new System.Drawing.Size(143, 20);
            this.txtMAL.TabIndex = 14;
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(69, 128);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(143, 20);
            this.txtGIA.TabIndex = 15;
            // 
            // txtTEN
            // 
            this.txtTEN.Location = new System.Drawing.Point(69, 89);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(143, 20);
            this.txtTEN.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên Món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Loại";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(92, 218);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 42);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa Món";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(16, 399);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(121, 52);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // QlyMon
            // 
            this.BackgroundImage = global::QuanLyQuanTraSua.Properties.Resources.foody_mobile_gongcha_mb_jpg_157_635636065715423611;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 473);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTEN);
            this.Controls.Add(this.txtGIA);
            this.Controls.Add(this.txtMAL);
            this.Controls.Add(this.txtMA);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSuaM);
            this.Controls.Add(this.btXoaM);
            this.Controls.Add(this.btThemM);
            this.Name = "QlyMon";
            this.Load += new System.EventHandler(this.QlyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuaM;
        private System.Windows.Forms.Button btXoaM;
        private System.Windows.Forms.Button btThemM;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.TextBox txtMAL;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btExit;
    }
}