namespace PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.picHa = new System.Windows.Forms.PictureBox();
            this.picNang = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblPNTG = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(41, 25);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(82, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Nhập tên: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(41, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(337, 27);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkMusic.Location = new System.Drawing.Point(306, 21);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(72, 24);
            this.chkMusic.TabIndex = 2;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = false;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // picHa
            // 
            this.picHa.Image = ((System.Drawing.Image)(resources.GetObject("picHa.Image")));
            this.picHa.Location = new System.Drawing.Point(38, 96);
            this.picHa.Name = "picHa";
            this.picHa.Size = new System.Drawing.Size(340, 231);
            this.picHa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHa.TabIndex = 3;
            this.picHa.TabStop = false;
            this.picHa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picNang
            // 
            this.picNang.Image = ((System.Drawing.Image)(resources.GetObject("picNang.Image")));
            this.picNang.Location = new System.Drawing.Point(38, 96);
            this.picNang.Name = "picNang";
            this.picNang.Size = new System.Drawing.Size(340, 231);
            this.picNang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNang.TabIndex = 4;
            this.picNang.TabStop = false;
            this.picNang.Click += new System.EventHandler(this.picNang_Click);
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClick.Location = new System.Drawing.Point(41, 342);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(337, 58);
            this.btnClick.TabIndex = 5;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblPNTG
            // 
            this.lblPNTG.AutoSize = true;
            this.lblPNTG.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPNTG.Location = new System.Drawing.Point(41, 445);
            this.lblPNTG.Name = "lblPNTG";
            this.lblPNTG.Size = new System.Drawing.Size(62, 20);
            this.lblPNTG.TabIndex = 6;
            this.lblPNTG.Text = "@PNTG";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(173, 412);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(73, 62);
            this.lblCount.TabIndex = 7;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Gray;
            this.lblThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblThoat.Location = new System.Drawing.Point(328, 445);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(50, 20);
            this.lblThoat.TabIndex = 8;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(423, 492);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPNTG);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.picNang);
            this.Controls.Add(this.picHa);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tập luyện thể thao - Nâng cao sức khỏe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private CheckBox chkMusic;
        private System.Windows.Forms.PictureBox picHa;
        private System.Windows.Forms.PictureBox picNang;
        private Button btnClick;
        private Label lblPNTG;
        private Label lblCount;
        private Label lblThoat;
    }
}