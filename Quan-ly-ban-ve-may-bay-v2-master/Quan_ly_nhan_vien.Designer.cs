namespace QLBVMB
{
    partial class Quan_ly_nhan_vien
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
            this.label_close = new System.Windows.Forms.Label();
            this.dataGridView_nhan_vien = new System.Windows.Forms.DataGridView();
            this.comboBox_chucvu = new System.Windows.Forms.ComboBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_cmnd = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.label_chucvu = new System.Windows.Forms.Label();
            this.label_cmnd = new System.Windows.Forms.Label();
            this.label_sdt = new System.Windows.Forms.Label();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_manv = new System.Windows.Forms.Label();
            this.label_tennv = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_cap_nhat = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_passlv2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.textBox_tennv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(859, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(31, 29);
            this.label_close.TabIndex = 27;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // dataGridView_nhan_vien
            // 
            this.dataGridView_nhan_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhan_vien.Location = new System.Drawing.Point(25, 490);
            this.dataGridView_nhan_vien.Name = "dataGridView_nhan_vien";
            this.dataGridView_nhan_vien.ReadOnly = true;
            this.dataGridView_nhan_vien.Size = new System.Drawing.Size(851, 334);
            this.dataGridView_nhan_vien.TabIndex = 28;
            this.dataGridView_nhan_vien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhan_vien_CellClick);
            // 
            // comboBox_chucvu
            // 
            this.comboBox_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chucvu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chucvu.FormattingEnabled = true;
            this.comboBox_chucvu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.comboBox_chucvu.Location = new System.Drawing.Point(590, 366);
            this.comboBox_chucvu.Name = "comboBox_chucvu";
            this.comboBox_chucvu.Size = new System.Drawing.Size(121, 26);
            this.comboBox_chucvu.TabIndex = 41;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(590, 331);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(286, 27);
            this.textBox_email.TabIndex = 40;
            // 
            // textBox_cmnd
            // 
            this.textBox_cmnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cmnd.Location = new System.Drawing.Point(155, 366);
            this.textBox_cmnd.Name = "textBox_cmnd";
            this.textBox_cmnd.Size = new System.Drawing.Size(286, 27);
            this.textBox_cmnd.TabIndex = 39;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(155, 328);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(286, 27);
            this.textBox_sdt.TabIndex = 38;
            // 
            // textBox_manv
            // 
            this.textBox_manv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv.Location = new System.Drawing.Point(155, 215);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.ReadOnly = true;
            this.textBox_manv.Size = new System.Drawing.Size(286, 27);
            this.textBox_manv.TabIndex = 36;
            // 
            // label_chucvu
            // 
            this.label_chucvu.AutoSize = true;
            this.label_chucvu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chucvu.ForeColor = System.Drawing.Color.White;
            this.label_chucvu.Location = new System.Drawing.Point(499, 371);
            this.label_chucvu.Name = "label_chucvu";
            this.label_chucvu.Size = new System.Drawing.Size(73, 19);
            this.label_chucvu.TabIndex = 35;
            this.label_chucvu.Text = "Chức vụ:";
            // 
            // label_cmnd
            // 
            this.label_cmnd.AutoSize = true;
            this.label_cmnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cmnd.ForeColor = System.Drawing.Color.White;
            this.label_cmnd.Location = new System.Drawing.Point(78, 369);
            this.label_cmnd.Name = "label_cmnd";
            this.label_cmnd.Size = new System.Drawing.Size(59, 19);
            this.label_cmnd.TabIndex = 34;
            this.label_cmnd.Text = "CMND:";
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdt.ForeColor = System.Drawing.Color.White;
            this.label_sdt.Location = new System.Drawing.Point(92, 331);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(45, 19);
            this.label_sdt.TabIndex = 33;
            this.label_sdt.Text = "SĐT:";
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diachi.ForeColor = System.Drawing.Color.White;
            this.label_diachi.Location = new System.Drawing.Point(74, 292);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(63, 19);
            this.label_diachi.TabIndex = 32;
            this.label_diachi.Text = "Địa chỉ:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(518, 334);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(54, 19);
            this.label_email.TabIndex = 31;
            this.label_email.Text = "Email:";
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manv.ForeColor = System.Drawing.Color.White;
            this.label_manv.Location = new System.Drawing.Point(28, 222);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(109, 19);
            this.label_manv.TabIndex = 30;
            this.label_manv.Text = "Mã nhân viên:";
            // 
            // label_tennv
            // 
            this.label_tennv.AutoSize = true;
            this.label_tennv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tennv.ForeColor = System.Drawing.Color.White;
            this.label_tennv.Location = new System.Drawing.Point(21, 255);
            this.label_tennv.Name = "label_tennv";
            this.label_tennv.Size = new System.Drawing.Size(116, 19);
            this.label_tennv.TabIndex = 29;
            this.label_tennv.Text = "Tên nhân viên:";
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.IndianRed;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.White;
            this.button_xoa.Location = new System.Drawing.Point(555, 423);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(97, 38);
            this.button_xoa.TabIndex = 44;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_cap_nhat
            // 
            this.button_cap_nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(204)))));
            this.button_cap_nhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_cap_nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cap_nhat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cap_nhat.Location = new System.Drawing.Point(424, 423);
            this.button_cap_nhat.Name = "button_cap_nhat";
            this.button_cap_nhat.Size = new System.Drawing.Size(97, 38);
            this.button_cap_nhat.TabIndex = 43;
            this.button_cap_nhat.Text = "Cập nhật";
            this.button_cap_nhat.UseVisualStyleBackColor = false;
            this.button_cap_nhat.Click += new System.EventHandler(this.button_cap_nhat_Click);
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.PaleGreen;
            this.button_them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(300, 423);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(97, 38);
            this.button_them.TabIndex = 45;
            this.button_them.Text = "Thêm";
            this.toolTip1.SetToolTip(this.button_them, "Mã nhân viên sẽ tự động tạo ra không cần phải nhập vào");
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLBVMB.Properties.Resources.management;
            this.pictureBox2.Location = new System.Drawing.Point(400, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(590, 220);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(286, 27);
            this.textBox_user.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tài khoản:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(590, 256);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(286, 27);
            this.textBox_pass.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(501, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mật khẩu:";
            // 
            // textBox_passlv2
            // 
            this.textBox_passlv2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passlv2.Location = new System.Drawing.Point(590, 295);
            this.textBox_passlv2.Name = "textBox_passlv2";
            this.textBox_passlv2.Size = new System.Drawing.Size(286, 27);
            this.textBox_passlv2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(458, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mật khẩu cấp 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(334, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 33);
            this.label4.TabIndex = 53;
            this.label4.Text = "Quản lý nhân viên";
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diachi.Location = new System.Drawing.Point(155, 291);
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(242, 27);
            this.textBox_diachi.TabIndex = 55;
            // 
            // textBox_tennv
            // 
            this.textBox_tennv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tennv.Location = new System.Drawing.Point(155, 253);
            this.textBox_tennv.Name = "textBox_tennv";
            this.textBox_tennv.Size = new System.Drawing.Size(242, 27);
            this.textBox_tennv.TabIndex = 54;
            // 
            // Quan_ly_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(902, 844);
            this.Controls.Add(this.textBox_diachi);
            this.Controls.Add(this.textBox_tennv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_passlv2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_cap_nhat);
            this.Controls.Add(this.comboBox_chucvu);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_cmnd);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.textBox_manv);
            this.Controls.Add(this.label_chucvu);
            this.Controls.Add(this.label_cmnd);
            this.Controls.Add(this.label_sdt);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_manv);
            this.Controls.Add(this.label_tennv);
            this.Controls.Add(this.dataGridView_nhan_vien);
            this.Controls.Add(this.label_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quan_ly_nhan_vien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan_ly_nhan_vien";
            this.Load += new System.EventHandler(this.Quan_ly_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.DataGridView dataGridView_nhan_vien;
        private System.Windows.Forms.ComboBox comboBox_chucvu;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_cmnd;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Label label_chucvu;
        private System.Windows.Forms.Label label_cmnd;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.Label label_tennv;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_cap_nhat;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_passlv2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.TextBox textBox_tennv;
    }
}