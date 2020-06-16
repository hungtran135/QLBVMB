namespace QLBVMB
{
    partial class PhieuChi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuChi));
            this.textBox_lido = new System.Windows.Forms.TextBox();
            this.textBox_sotien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tenpc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_noidung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenNV = new System.Windows.Forms.TextBox();
            this.dataGridView_pc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_lido
            // 
            this.textBox_lido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lido.Location = new System.Drawing.Point(523, 296);
            this.textBox_lido.Name = "textBox_lido";
            this.textBox_lido.Size = new System.Drawing.Size(241, 30);
            this.textBox_lido.TabIndex = 1;
            this.textBox_lido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_sotien
            // 
            this.textBox_sotien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sotien.Location = new System.Drawing.Point(522, 249);
            this.textBox_sotien.Name = "textBox_sotien";
            this.textBox_sotien.Size = new System.Drawing.Size(242, 30);
            this.textBox_sotien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên nhân viên:";
            // 
            // label_tenpc
            // 
            this.label_tenpc.AutoSize = true;
            this.label_tenpc.BackColor = System.Drawing.Color.Transparent;
            this.label_tenpc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenpc.ForeColor = System.Drawing.Color.White;
            this.label_tenpc.Location = new System.Drawing.Point(447, 304);
            this.label_tenpc.Name = "label_tenpc";
            this.label_tenpc.Size = new System.Drawing.Size(57, 23);
            this.label_tenpc.TabIndex = 4;
            this.label_tenpc.Text = "Lí do:";
            this.label_tenpc.Click += new System.EventHandler(this.label_tenpc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiền:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QLBVMB.Properties.Resources.Receipt_512;
            this.pictureBox1.Location = new System.Drawing.Point(400, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.Salmon;
            this.button_them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(417, 474);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(109, 38);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã nhân viên:";
            // 
            // textBox_manv
            // 
            this.textBox_manv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv.Location = new System.Drawing.Point(164, 299);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.ReadOnly = true;
            this.textBox_manv.Size = new System.Drawing.Size(242, 30);
            this.textBox_manv.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nội dung:";
            // 
            // textBox_noidung
            // 
            this.textBox_noidung.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_noidung.Location = new System.Drawing.Point(164, 342);
            this.textBox_noidung.Multiline = true;
            this.textBox_noidung.Name = "textBox_noidung";
            this.textBox_noidung.Size = new System.Drawing.Size(600, 117);
            this.textBox_noidung.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(338, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quảng lí phiếu chi";
            // 
            // textBox_tenNV
            // 
            this.textBox_tenNV.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenNV.Location = new System.Drawing.Point(164, 249);
            this.textBox_tenNV.Name = "textBox_tenNV";
            this.textBox_tenNV.ReadOnly = true;
            this.textBox_tenNV.Size = new System.Drawing.Size(242, 30);
            this.textBox_tenNV.TabIndex = 55;
            // 
            // dataGridView_pc
            // 
            this.dataGridView_pc.AllowUserToAddRows = false;
            this.dataGridView_pc.AllowUserToDeleteRows = false;
            this.dataGridView_pc.BackgroundColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pc.Location = new System.Drawing.Point(93, 537);
            this.dataGridView_pc.Name = "dataGridView_pc";
            this.dataGridView_pc.ReadOnly = true;
            this.dataGridView_pc.Size = new System.Drawing.Size(729, 239);
            this.dataGridView_pc.TabIndex = 56;
            // 
            // PhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 809);
            this.Controls.Add(this.dataGridView_pc);
            this.Controls.Add(this.textBox_tenNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_noidung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_manv);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_tenpc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sotien);
            this.Controls.Add(this.textBox_lido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Chi";
            this.Load += new System.EventHandler(this.PhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_lido;
        private System.Windows.Forms.TextBox textBox_sotien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tenpc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_noidung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenNV;
        private System.Windows.Forms.DataGridView dataGridView_pc;
    }
}