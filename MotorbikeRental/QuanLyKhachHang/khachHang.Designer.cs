
namespace MotorbikeRental.QuanLyKhachHang
{
    partial class khachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(khachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitleDS = new System.Windows.Forms.Label();
            this.panelDSNV = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.iMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbCMND = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTitleNV = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.panelThongTinNV = new System.Windows.Forms.Panel();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton4 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnThem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton3 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton2 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.panelDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNV)).BeginInit();
            this.panel10.SuspendLayout();
            this.panelThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN TRỊ KHÁCH HÀNG";
            // 
            // lbTitleDS
            // 
            this.lbTitleDS.AutoSize = true;
            this.lbTitleDS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleDS.Location = new System.Drawing.Point(18, 21);
            this.lbTitleDS.Name = "lbTitleDS";
            this.lbTitleDS.Size = new System.Drawing.Size(209, 23);
            this.lbTitleDS.TabIndex = 14;
            this.lbTitleDS.Text = "II. Danh sách Khách hàng";
            // 
            // panelDSNV
            // 
            this.panelDSNV.Controls.Add(this.lbTitleDS);
            this.panelDSNV.Controls.Add(this.dgvKH);
            this.panelDSNV.Location = new System.Drawing.Point(57, 363);
            this.panelDSNV.Name = "panelDSNV";
            this.panelDSNV.Size = new System.Drawing.Size(1200, 448);
            this.panelDSNV.TabIndex = 13;
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaKH,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.Location = new System.Drawing.Point(41, 61);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKH.Name = "dgvKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1126, 361);
            this.dgvKH.TabIndex = 7;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // iMaKH
            // 
            this.iMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iMaKH.DataPropertyName = "PK_iMaKH";
            this.iMaKH.HeaderText = "Mã KH";
            this.iMaKH.MinimumWidth = 6;
            this.iMaKH.Name = "iMaKH";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sTenKH";
            this.Column1.HeaderText = "Tên KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sSDT";
            this.Column2.HeaderText = "Số điện thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sGioiTinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sCCCD";
            this.Column4.HeaderText = "CCCD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sDiaChi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // errorProviderNV
            // 
            this.errorProviderNV.ContainerControl = this;
            // 
            // lbCMND
            // 
            this.lbCMND.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCMND.Location = new System.Drawing.Point(29, 160);
            this.lbCMND.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(69, 29);
            this.lbCMND.TabIndex = 15;
            this.lbCMND.Text = "CCCD";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHoTen.BackColor = System.Drawing.Color.White;
            this.tbHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHoTen.Location = new System.Drawing.Point(133, 103);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(231, 30);
            this.tbHoTen.TabIndex = 60;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.Location = new System.Drawing.Point(29, 106);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(84, 23);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // lbSDT
            // 
            this.lbSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(430, 49);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(111, 23);
            this.lbSDT.TabIndex = 5;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // tbCMND
            // 
            this.tbCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCMND.BackColor = System.Drawing.Color.White;
            this.tbCMND.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCMND.Location = new System.Drawing.Point(133, 160);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(231, 30);
            this.tbCMND.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(430, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Giới tính";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaKH.BackColor = System.Drawing.Color.White;
            this.tbMaKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaKH.Location = new System.Drawing.Point(133, 46);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(231, 30);
            this.tbMaKH.TabIndex = 63;
            // 
            // lbTK
            // 
            this.lbTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTK.Location = new System.Drawing.Point(29, 49);
            this.lbTK.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(61, 23);
            this.lbTK.TabIndex = 31;
            this.lbTK.Text = "Mã KH";
            // 
            // tbSDT
            // 
            this.tbSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSDT.BackColor = System.Drawing.Color.White;
            this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSDT.Location = new System.Drawing.Point(564, 46);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(262, 30);
            this.tbSDT.TabIndex = 62;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(430, 160);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(62, 23);
            this.lbDiaChi.TabIndex = 38;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbTitleNV
            // 
            this.lbTitleNV.AutoSize = true;
            this.lbTitleNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleNV.Location = new System.Drawing.Point(18, 3);
            this.lbTitleNV.Name = "lbTitleNV";
            this.lbTitleNV.Size = new System.Drawing.Size(201, 23);
            this.lbTitleNV.TabIndex = 16;
            this.lbTitleNV.Text = "I. Thông tin Khách hàng";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.btnTimKiem);
            this.panel10.Controls.Add(this.vbButton4);
            this.panel10.Controls.Add(this.textBox5);
            this.panel10.Controls.Add(this.btnThem);
            this.panel10.Controls.Add(this.vbButton3);
            this.panel10.Controls.Add(this.vbButton2);
            this.panel10.Location = new System.Drawing.Point(31, 204);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1136, 81);
            this.panel10.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox5.Location = new System.Drawing.Point(673, 24);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(240, 32);
            this.textBox5.TabIndex = 61;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.Color.White;
            this.tbDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDiaChi.Location = new System.Drawing.Point(564, 157);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(256, 33);
            this.tbDiaChi.TabIndex = 56;
            // 
            // panelThongTinNV
            // 
            this.panelThongTinNV.Controls.Add(this.tbGioiTinh);
            this.panelThongTinNV.Controls.Add(this.tbDiaChi);
            this.panelThongTinNV.Controls.Add(this.panel10);
            this.panelThongTinNV.Controls.Add(this.lbTitleNV);
            this.panelThongTinNV.Controls.Add(this.lbDiaChi);
            this.panelThongTinNV.Controls.Add(this.tbSDT);
            this.panelThongTinNV.Controls.Add(this.lbTK);
            this.panelThongTinNV.Controls.Add(this.tbMaKH);
            this.panelThongTinNV.Controls.Add(this.label10);
            this.panelThongTinNV.Controls.Add(this.tbCMND);
            this.panelThongTinNV.Controls.Add(this.lbSDT);
            this.panelThongTinNV.Controls.Add(this.lbHoTen);
            this.panelThongTinNV.Controls.Add(this.tbHoTen);
            this.panelThongTinNV.Controls.Add(this.lbCMND);
            this.panelThongTinNV.Location = new System.Drawing.Point(57, 60);
            this.panelThongTinNV.Name = "panelThongTinNV";
            this.panelThongTinNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelThongTinNV.Size = new System.Drawing.Size(1200, 297);
            this.panelThongTinNV.TabIndex = 14;
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(564, 103);
            this.tbGioiTinh.Multiline = true;
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(244, 30);
            this.tbGioiTinh.TabIndex = 64;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(946, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // vbButton4
            // 
            this.vbButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton4.BackColor = System.Drawing.Color.Transparent;
            this.vbButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.vbButton4.BorderRadius = 15;
            this.vbButton4.BorderSize = 2;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.ForeColor = System.Drawing.Color.Black;
            this.vbButton4.Location = new System.Drawing.Point(458, 24);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(125, 40);
            this.vbButton4.TabIndex = 14;
            this.vbButton4.Text = "Làm mới";
            this.vbButton4.TextColor = System.Drawing.Color.Black;
            this.vbButton4.UseVisualStyleBackColor = false;
            this.vbButton4.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 15;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(32, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // vbButton3
            // 
            this.vbButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 15;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(316, 24);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(125, 40);
            this.vbButton3.TabIndex = 13;
            this.vbButton3.Text = "Xóa";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.vbButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 15;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(174, 24);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(125, 40);
            this.vbButton2.TabIndex = 12;
            this.vbButton2.Text = "Sửa";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 926);
            this.Controls.Add(this.panelThongTinNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDSNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "khachHang";
            this.Text = " ";
            this.Load += new System.EventHandler(this.khachHang_Load);
            this.panelDSNV.ResumeLayout(false);
            this.panelDSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNV)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelThongTinNV.ResumeLayout(false);
            this.panelThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitleDS;
        private System.Windows.Forms.Panel panelDSNV;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.ErrorProvider errorProviderNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panelThongTinNV;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Panel panel10;
        private PresentationLayer.Custom.VBButton btnTimKiem;
        private PresentationLayer.Custom.VBButton vbButton4;
        private System.Windows.Forms.TextBox textBox5;
        private PresentationLayer.Custom.VBButton btnThem;
        private PresentationLayer.Custom.VBButton vbButton3;
        private PresentationLayer.Custom.VBButton vbButton2;
        private System.Windows.Forms.Label lbTitleNV;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.TextBox tbGioiTinh;
    }
}