namespace _6
{
    partial class FrmQuanlytaikhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.txtIDtaikhoan = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHovaten = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblMatacgia = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.grpDanhsachtacgia = new System.Windows.Forms.GroupBox();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.grpThongtin = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapnhat = new FontAwesome.Sharp.IconButton();
            this.btnKhoa = new FontAwesome.Sharp.IconButton();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.btnLammoi = new FontAwesome.Sharp.IconButton();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtTi = new System.Windows.Forms.Label();
            this.lblTimIDtaikhoan = new System.Windows.Forms.Label();
            this.txtTimtendangnhap = new System.Windows.Forms.TextBox();
            this.txtTimIDtaikhoan = new System.Windows.Forms.TextBox();
            this.grpTimkiem = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaycapnhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.grpDanhsachtacgia.SuspendLayout();
            this.grpThongtin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.grpTimkiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tendangnhap,
            this.Email,
            this.Trangthai,
            this.Ngaytao,
            this.Ngaycapnhat});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTaikhoan.EnableHeadersVisualStyles = false;
            this.dgvTaikhoan.Location = new System.Drawing.Point(27, 29);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersWidth = 51;
            this.dgvTaikhoan.Size = new System.Drawing.Size(1013, 177);
            this.dgvTaikhoan.TabIndex = 5;
            this.dgvTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaikhoan_CellClick);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox3.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 22;
            this.iconPictureBox3.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(26, 22);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(624, 35);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(266, 30);
            this.txtTendangnhap.TabIndex = 6;
            // 
            // txtIDtaikhoan
            // 
            this.txtIDtaikhoan.Location = new System.Drawing.Point(171, 36);
            this.txtIDtaikhoan.Name = "txtIDtaikhoan";
            this.txtIDtaikhoan.Size = new System.Drawing.Size(178, 30);
            this.txtIDtaikhoan.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(624, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // lblHovaten
            // 
            this.lblHovaten.AutoSize = true;
            this.lblHovaten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHovaten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHovaten.Location = new System.Drawing.Point(20, 123);
            this.lblHovaten.Name = "lblHovaten";
            this.lblHovaten.Size = new System.Drawing.Size(92, 23);
            this.lblHovaten.TabIndex = 5;
            this.lblHovaten.Text = "Trạng thái";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(443, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDienthoai.Location = new System.Drawing.Point(443, 41);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(128, 23);
            this.lblDienthoai.TabIndex = 5;
            this.lblDienthoai.Text = "Tên đăng nhập";
            // 
            // lblMatacgia
            // 
            this.lblMatacgia.AutoSize = true;
            this.lblMatacgia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatacgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMatacgia.Location = new System.Drawing.Point(24, 40);
            this.lblMatacgia.Name = "lblMatacgia";
            this.lblMatacgia.Size = new System.Drawing.Size(108, 23);
            this.lblMatacgia.TabIndex = 5;
            this.lblMatacgia.Text = "ID tài khoản";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(26, 22);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // grpDanhsachtacgia
            // 
            this.grpDanhsachtacgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.grpDanhsachtacgia.Controls.Add(this.dgvTaikhoan);
            this.grpDanhsachtacgia.Controls.Add(this.iconPictureBox3);
            this.grpDanhsachtacgia.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhsachtacgia.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpDanhsachtacgia.Location = new System.Drawing.Point(1, 525);
            this.grpDanhsachtacgia.Name = "grpDanhsachtacgia";
            this.grpDanhsachtacgia.Size = new System.Drawing.Size(1086, 235);
            this.grpDanhsachtacgia.TabIndex = 14;
            this.grpDanhsachtacgia.TabStop = false;
            this.grpDanhsachtacgia.Text = "   DANH SÁCH TÀI KHOẢN";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(381, 70);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 48);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpThongtin
            // 
            this.grpThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpThongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.grpThongtin.Controls.Add(this.panel2);
            this.grpThongtin.Controls.Add(this.txtTendangnhap);
            this.grpThongtin.Controls.Add(this.txtTrangthai);
            this.grpThongtin.Controls.Add(this.txtIDtaikhoan);
            this.grpThongtin.Controls.Add(this.txtEmail);
            this.grpThongtin.Controls.Add(this.lblHovaten);
            this.grpThongtin.Controls.Add(this.lblEmail);
            this.grpThongtin.Controls.Add(this.lblDienthoai);
            this.grpThongtin.Controls.Add(this.lblMatacgia);
            this.grpThongtin.Controls.Add(this.iconPictureBox1);
            this.grpThongtin.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongtin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpThongtin.Location = new System.Drawing.Point(3, 92);
            this.grpThongtin.Name = "grpThongtin";
            this.grpThongtin.Size = new System.Drawing.Size(1084, 311);
            this.grpThongtin.TabIndex = 12;
            this.grpThongtin.TabStop = false;
            this.grpThongtin.Text = "    THÔNG TIN TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapnhat);
            this.panel2.Controls.Add(this.btnKhoa);
            this.panel2.Location = new System.Drawing.Point(6, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 146);
            this.panel2.TabIndex = 10;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.AutoSize = true;
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.MintCream;
            this.btnCapnhat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCapnhat.IconColor = System.Drawing.Color.White;
            this.btnCapnhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapnhat.IconSize = 40;
            this.btnCapnhat.Location = new System.Drawing.Point(108, 70);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(142, 48);
            this.btnCapnhat.TabIndex = 0;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.AutoSize = true;
            this.btnKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.MintCream;
            this.btnKhoa.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnKhoa.IconColor = System.Drawing.Color.White;
            this.btnKhoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoa.IconSize = 40;
            this.btnKhoa.Location = new System.Drawing.Point(664, 70);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(169, 48);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = "Khóa/Mở khóa";
            this.btnKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoa.UseVisualStyleBackColor = false;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(171, 123);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.ReadOnly = true;
            this.txtTrangthai.Size = new System.Drawing.Size(178, 30);
            this.txtTrangthai.TabIndex = 6;
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.MintCream;
            this.btnLammoi.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btnLammoi.IconColor = System.Drawing.Color.AliceBlue;
            this.btnLammoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLammoi.IconSize = 20;
            this.btnLammoi.Location = new System.Drawing.Point(941, 47);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(139, 52);
            this.btnLammoi.TabIndex = 12;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimkiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimkiem.IconColor = System.Drawing.Color.AliceBlue;
            this.btnTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiem.IconSize = 20;
            this.btnTimkiem.Location = new System.Drawing.Point(788, 44);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(147, 55);
            this.btnTimkiem.TabIndex = 12;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTImkiem_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox2.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 22;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(26, 22);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // txtTi
            // 
            this.txtTi.AutoSize = true;
            this.txtTi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTi.Location = new System.Drawing.Point(325, 63);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(128, 23);
            this.txtTi.TabIndex = 5;
            this.txtTi.Text = "Tên đăng nhập";
            // 
            // lblTimIDtaikhoan
            // 
            this.lblTimIDtaikhoan.AutoSize = true;
            this.lblTimIDtaikhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimIDtaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTimIDtaikhoan.Location = new System.Drawing.Point(4, 68);
            this.lblTimIDtaikhoan.Name = "lblTimIDtaikhoan";
            this.lblTimIDtaikhoan.Size = new System.Drawing.Size(108, 23);
            this.lblTimIDtaikhoan.TabIndex = 5;
            this.lblTimIDtaikhoan.Text = "ID tài khoản";
            // 
            // txtTimtendangnhap
            // 
            this.txtTimtendangnhap.Location = new System.Drawing.Point(532, 58);
            this.txtTimtendangnhap.Name = "txtTimtendangnhap";
            this.txtTimtendangnhap.Size = new System.Drawing.Size(236, 30);
            this.txtTimtendangnhap.TabIndex = 6;
            // 
            // txtTimIDtaikhoan
            // 
            this.txtTimIDtaikhoan.Location = new System.Drawing.Point(164, 58);
            this.txtTimIDtaikhoan.Name = "txtTimIDtaikhoan";
            this.txtTimIDtaikhoan.Size = new System.Drawing.Size(155, 30);
            this.txtTimIDtaikhoan.TabIndex = 6;
            // 
            // grpTimkiem
            // 
            this.grpTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.grpTimkiem.Controls.Add(this.btnLammoi);
            this.grpTimkiem.Controls.Add(this.btnTimkiem);
            this.grpTimkiem.Controls.Add(this.iconPictureBox2);
            this.grpTimkiem.Controls.Add(this.txtTi);
            this.grpTimkiem.Controls.Add(this.lblTimIDtaikhoan);
            this.grpTimkiem.Controls.Add(this.txtTimtendangnhap);
            this.grpTimkiem.Controls.Add(this.txtTimIDtaikhoan);
            this.grpTimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimkiem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpTimkiem.Location = new System.Drawing.Point(1, 403);
            this.grpTimkiem.Name = "grpTimkiem";
            this.grpTimkiem.Size = new System.Drawing.Size(1086, 118);
            this.grpTimkiem.TabIndex = 13;
            this.grpTimkiem.TabStop = false;
            this.grpTimkiem.Text = "   TÌM KIẾM TÀI KHOẢN";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(450, 298);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(8, 8);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 86);
            this.panel1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.DataPropertyName = "username";
            this.Tendangnhap.HeaderText = "Tên đăng nhập";
            this.Tendangnhap.MinimumWidth = 6;
            this.Tendangnhap.Name = "Tendangnhap";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 120F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "is_active";
            this.Trangthai.FillWeight = 40F;
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            // 
            // Ngaytao
            // 
            this.Ngaytao.DataPropertyName = "created_at";
            this.Ngaytao.HeaderText = "Ngày tạo";
            this.Ngaytao.MinimumWidth = 6;
            this.Ngaytao.Name = "Ngaytao";
            // 
            // Ngaycapnhat
            // 
            this.Ngaycapnhat.DataPropertyName = "updated_at";
            this.Ngaycapnhat.HeaderText = "Ngày cập nhật";
            this.Ngaycapnhat.MinimumWidth = 6;
            this.Ngaycapnhat.Name = "Ngaycapnhat";
            // 
            // FrmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1128, 796);
            this.Controls.Add(this.grpDanhsachtacgia);
            this.Controls.Add(this.grpThongtin);
            this.Controls.Add(this.grpTimkiem);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanlytaikhoan";
            this.Text = "FrmQuanlytaikhoan";
            this.Load += new System.EventHandler(this.FrmQuanlytaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.grpDanhsachtacgia.ResumeLayout(false);
            this.grpThongtin.ResumeLayout(false);
            this.grpThongtin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.grpTimkiem.ResumeLayout(false);
            this.grpTimkiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtIDtaikhoan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHovaten;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblMatacgia;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.GroupBox grpDanhsachtacgia;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.GroupBox grpThongtin;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCapnhat;
        private FontAwesome.Sharp.IconButton btnKhoa;
        private FontAwesome.Sharp.IconButton btnLammoi;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label txtTi;
        private System.Windows.Forms.Label lblTimIDtaikhoan;
        private System.Windows.Forms.TextBox txtTimtendangnhap;
        private System.Windows.Forms.TextBox txtTimIDtaikhoan;
        private System.Windows.Forms.GroupBox grpTimkiem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaycapnhat;
    }
}