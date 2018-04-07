namespace ThucTapNhom_QuanLyTHPT.GUI.UC.ChucVu
{
    partial class UCChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChucVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa_ChucVu = new System.Windows.Forms.Button();
            this.btnSua_ChucVu = new System.Windows.Forms.Button();
            this.btnThem_ChucVu = new System.Windows.Forms.Button();
            this.cbOption_ChucVu = new System.Windows.Forms.ComboBox();
            this.txtSearch_ChucVu = new System.Windows.Forms.TextBox();
            this.btnSearch_ChucVu = new System.Windows.Forms.Button();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.colMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.btnBack_ChucVu = new System.Windows.Forms.Button();
            this.btnClearText_ChucVu = new System.Windows.Forms.Button();
            this.btnLuu_ChucVu = new System.Windows.Forms.Button();
            this.pnlThongTin_ChucVu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.pnlThongTin_ChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa_ChucVu);
            this.panel1.Controls.Add(this.btnSua_ChucVu);
            this.panel1.Controls.Add(this.btnThem_ChucVu);
            this.panel1.Controls.Add(this.cbOption_ChucVu);
            this.panel1.Controls.Add(this.txtSearch_ChucVu);
            this.panel1.Controls.Add(this.btnSearch_ChucVu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 69);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnXoa_ChucVu
            // 
            this.btnXoa_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnXoa_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnXoa_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_ChucVu.Location = new System.Drawing.Point(1053, 19);
            this.btnXoa_ChucVu.Name = "btnXoa_ChucVu";
            this.btnXoa_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnXoa_ChucVu.TabIndex = 5;
            this.btnXoa_ChucVu.Text = "Xóa";
            this.btnXoa_ChucVu.UseVisualStyleBackColor = false;
            this.btnXoa_ChucVu.Click += new System.EventHandler(this.btnXoa_ChucVu_Click);
            // 
            // btnSua_ChucVu
            // 
            this.btnSua_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSua_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSua_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_ChucVu.Location = new System.Drawing.Point(927, 19);
            this.btnSua_ChucVu.Name = "btnSua_ChucVu";
            this.btnSua_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnSua_ChucVu.TabIndex = 4;
            this.btnSua_ChucVu.Text = "Sửa";
            this.btnSua_ChucVu.UseVisualStyleBackColor = false;
            this.btnSua_ChucVu.Click += new System.EventHandler(this.btnSua_ChucVu_Click);
            // 
            // btnThem_ChucVu
            // 
            this.btnThem_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_ChucVu.Location = new System.Drawing.Point(801, 19);
            this.btnThem_ChucVu.Name = "btnThem_ChucVu";
            this.btnThem_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnThem_ChucVu.TabIndex = 3;
            this.btnThem_ChucVu.Text = "Thêm";
            this.btnThem_ChucVu.UseVisualStyleBackColor = false;
            this.btnThem_ChucVu.Click += new System.EventHandler(this.btnThem_ChucVu_Click);
            // 
            // cbOption_ChucVu
            // 
            this.cbOption_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.cbOption_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption_ChucVu.FormattingEnabled = true;
            this.cbOption_ChucVu.Items.AddRange(new object[] {
            "Mã chức vụ"});
            this.cbOption_ChucVu.Location = new System.Drawing.Point(293, 22);
            this.cbOption_ChucVu.Name = "cbOption_ChucVu";
            this.cbOption_ChucVu.Size = new System.Drawing.Size(149, 29);
            this.cbOption_ChucVu.TabIndex = 1;
            this.cbOption_ChucVu.Tag = "";
            // 
            // txtSearch_ChucVu
            // 
            this.txtSearch_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_ChucVu.Location = new System.Drawing.Point(12, 22);
            this.txtSearch_ChucVu.Name = "txtSearch_ChucVu";
            this.txtSearch_ChucVu.Size = new System.Drawing.Size(275, 27);
            this.txtSearch_ChucVu.TabIndex = 0;
            // 
            // btnSearch_ChucVu
            // 
            this.btnSearch_ChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_ChucVu.Image")));
            this.btnSearch_ChucVu.Location = new System.Drawing.Point(448, 20);
            this.btnSearch_ChucVu.Name = "btnSearch_ChucVu";
            this.btnSearch_ChucVu.Size = new System.Drawing.Size(38, 34);
            this.btnSearch_ChucVu.TabIndex = 2;
            this.btnSearch_ChucVu.UseVisualStyleBackColor = true;
            this.btnSearch_ChucVu.Click += new System.EventHandler(this.btnSearch_ChucVu_Click);
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucVu,
            this.colTenChucVu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvChucVu.Location = new System.Drawing.Point(0, 69);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvChucVu.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvChucVu.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.RowTemplate.Height = 25;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(1171, 481);
            this.dgvChucVu.TabIndex = 9;
            this.dgvChucVu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvChucVu_MouseClick);
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.DataPropertyName = "machucvu";
            this.colMaChucVu.HeaderText = "Mã chức vụ";
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.ReadOnly = true;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucVu.DataPropertyName = "tenchucvu";
            this.colTenChucVu.HeaderText = "Tên chức vụ";
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên chức vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Mã chức vụ";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Location = new System.Drawing.Point(480, 18);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(226, 23);
            this.txtTenChucVu.TabIndex = 7;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChucVu.Location = new System.Drawing.Point(117, 18);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(226, 23);
            this.txtMaChucVu.TabIndex = 16;
            // 
            // btnBack_ChucVu
            // 
            this.btnBack_ChucVu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_ChucVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack_ChucVu.Location = new System.Drawing.Point(791, 11);
            this.btnBack_ChucVu.Name = "btnBack_ChucVu";
            this.btnBack_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnBack_ChucVu.TabIndex = 17;
            this.btnBack_ChucVu.Text = "Ẩn";
            this.btnBack_ChucVu.UseVisualStyleBackColor = false;
            this.btnBack_ChucVu.Click += new System.EventHandler(this.btnBack_GiaoVien_Click);
            // 
            // btnClearText_ChucVu
            // 
            this.btnClearText_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearText_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnClearText_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnClearText_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.btnClearText_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText_ChucVu.Location = new System.Drawing.Point(917, 11);
            this.btnClearText_ChucVu.Name = "btnClearText_ChucVu";
            this.btnClearText_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnClearText_ChucVu.TabIndex = 18;
            this.btnClearText_ChucVu.Text = "Clear";
            this.btnClearText_ChucVu.UseVisualStyleBackColor = false;
            this.btnClearText_ChucVu.Click += new System.EventHandler(this.btnClearText_GiaoVien_Click);
            // 
            // btnLuu_ChucVu
            // 
            this.btnLuu_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu_ChucVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_ChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_ChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_ChucVu.Location = new System.Drawing.Point(1043, 11);
            this.btnLuu_ChucVu.Name = "btnLuu_ChucVu";
            this.btnLuu_ChucVu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu_ChucVu.TabIndex = 19;
            this.btnLuu_ChucVu.Text = "Lưu";
            this.btnLuu_ChucVu.UseVisualStyleBackColor = false;
            this.btnLuu_ChucVu.Click += new System.EventHandler(this.btnLuu_GiaoVien_Click);
            // 
            // pnlThongTin_ChucVu
            // 
            this.pnlThongTin_ChucVu.BackColor = System.Drawing.Color.White;
            this.pnlThongTin_ChucVu.Controls.Add(this.btnLuu_ChucVu);
            this.pnlThongTin_ChucVu.Controls.Add(this.btnClearText_ChucVu);
            this.pnlThongTin_ChucVu.Controls.Add(this.btnBack_ChucVu);
            this.pnlThongTin_ChucVu.Controls.Add(this.txtMaChucVu);
            this.pnlThongTin_ChucVu.Controls.Add(this.txtTenChucVu);
            this.pnlThongTin_ChucVu.Controls.Add(this.label10);
            this.pnlThongTin_ChucVu.Controls.Add(this.label1);
            this.pnlThongTin_ChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin_ChucVu.Location = new System.Drawing.Point(0, 550);
            this.pnlThongTin_ChucVu.Name = "pnlThongTin_ChucVu";
            this.pnlThongTin_ChucVu.Size = new System.Drawing.Size(1171, 60);
            this.pnlThongTin_ChucVu.TabIndex = 10;
            // 
            // UCChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 610);
            this.Controls.Add(this.pnlThongTin_ChucVu);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCChucVu";
            this.Text = "UCChucVu";
            this.Load += new System.EventHandler(this.UCChucVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.pnlThongTin_ChucVu.ResumeLayout(false);
            this.pnlThongTin_ChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa_ChucVu;
        private System.Windows.Forms.Button btnSua_ChucVu;
        private System.Windows.Forms.Button btnThem_ChucVu;
        private System.Windows.Forms.ComboBox cbOption_ChucVu;
        private System.Windows.Forms.TextBox txtSearch_ChucVu;
        private System.Windows.Forms.Button btnSearch_ChucVu;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Button btnBack_ChucVu;
        private System.Windows.Forms.Button btnClearText_ChucVu;
        private System.Windows.Forms.Button btnLuu_ChucVu;
        private System.Windows.Forms.Panel pnlThongTin_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucVu;
    }
}