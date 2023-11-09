namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grbDSS = new System.Windows.Forms.GroupBox();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.btnThay = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnXoaPTChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.grbDSS.SuspendLayout();
            this.grbChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(140, 26);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(383, 27);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(535, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKetThuc.Location = new System.Drawing.Point(35, 379);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(594, 39);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // grbDSS
            // 
            this.grbDSS.Controls.Add(this.lstDS);
            this.grbDSS.Location = new System.Drawing.Point(35, 77);
            this.grbDSS.Name = "grbDSS";
            this.grbDSS.Size = new System.Drawing.Size(294, 286);
            this.grbDSS.TabIndex = 5;
            this.grbDSS.TabStop = false;
            this.grbDSS.Text = "Danh sách số";
            // 
            // lstDS
            // 
            this.lstDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 20;
            this.lstDS.Location = new System.Drawing.Point(3, 23);
            this.lstDS.Name = "lstDS";
            this.lstDS.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDS.Size = new System.Drawing.Size(288, 260);
            this.lstDS.TabIndex = 0;
            // 
            // grbChucnang
            // 
            this.grbChucnang.Controls.Add(this.btnChonLe);
            this.grbChucnang.Controls.Add(this.btnChonChan);
            this.grbChucnang.Controls.Add(this.btnThay);
            this.grbChucnang.Controls.Add(this.btnTang);
            this.grbChucnang.Controls.Add(this.btnXoaPTChon);
            this.grbChucnang.Controls.Add(this.btnXoaDauCuoi);
            this.grbChucnang.Controls.Add(this.btnTong);
            this.grbChucnang.Location = new System.Drawing.Point(335, 77);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Size = new System.Drawing.Size(294, 286);
            this.grbChucnang.TabIndex = 6;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chọn chức năng";
            // 
            // btnChonLe
            // 
            this.btnChonLe.Location = new System.Drawing.Point(6, 242);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(282, 29);
            this.btnChonLe.TabIndex = 6;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Location = new System.Drawing.Point(6, 207);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(282, 29);
            this.btnChonChan.TabIndex = 5;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // btnThay
            // 
            this.btnThay.Location = new System.Drawing.Point(6, 172);
            this.btnThay.Name = "btnThay";
            this.btnThay.Size = new System.Drawing.Size(282, 29);
            this.btnThay.TabIndex = 4;
            this.btnThay.Text = "Thay bằng bình phương";
            this.btnThay.UseVisualStyleBackColor = true;
            this.btnThay.Click += new System.EventHandler(this.btnThay_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(6, 137);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(282, 29);
            this.btnTang.TabIndex = 3;
            this.btnTang.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnXoaPTChon
            // 
            this.btnXoaPTChon.Location = new System.Drawing.Point(6, 102);
            this.btnXoaPTChon.Name = "btnXoaPTChon";
            this.btnXoaPTChon.Size = new System.Drawing.Size(282, 29);
            this.btnXoaPTChon.TabIndex = 2;
            this.btnXoaPTChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPTChon.UseVisualStyleBackColor = true;
            this.btnXoaPTChon.Click += new System.EventHandler(this.btnXoaPTChon_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(6, 67);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(282, 29);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(6, 32);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(282, 29);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 451);
            this.Controls.Add(this.grbChucnang);
            this.Controls.Add(this.grbDSS);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.grbDSS.ResumeLayout(false);
            this.grbChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnUpdate;
        private Button btnKetThuc;
        private GroupBox grbDSS;
        private GroupBox grbChucnang;
        private System.Windows.Forms.ListBox lstDS;
        private Button btnChonLe;
        private Button btnChonChan;
        private Button btnThay;
        private Button btnTang;
        private Button btnXoaPTChon;
        private Button btnXoaDauCuoi;
        private Button btnTong;
    }
}