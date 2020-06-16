using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class Quen_pass : Form
    {
        int _clr_u=1;
        int _clr_plv2=1;
        int _clr_p=1;
        int _clr_rp=1;
        BLL.NhanvienBLL bllNV;


        public Quen_pass()
        {
            bllNV = new BLL.NhanvienBLL();
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_user_Click(object sender, EventArgs e)
        {

            if (_clr_u == 1)
            {
                textBox_user.Clear();
                _clr_u = 0;
            }
        }

        private void textBox_pass_lv2_Click(object sender, EventArgs e)
        {
            if (_clr_plv2 == 1)
            {
                textBox_pass_lv2.Clear();
                textBox_pass_lv2.PasswordChar = '*';
                _clr_plv2 = 0;
            }
        }

        private void textBox_pass_Click(object sender, EventArgs e)
        {
            if (_clr_p == 1)
            {
                textBox_pass.Clear();
                textBox_pass.PasswordChar = '*';
                _clr_p = 0;
            }
        }

        private void textBox_repass_Click(object sender, EventArgs e)
        {
            if (_clr_rp == 1)
            {
                textBox_repass.Clear();
                textBox_repass.PasswordChar = '*';
                _clr_rp = 0;
            }
        }

        private void button_dat_lai_pass_Click(object sender, EventArgs e)
        {

            if (textBox_user.Text == "" || textBox_user.Text == "Tên đăng nhập"
               || textBox_pass_lv2.Text == "" || textBox_pass_lv2.Text == "Mật khẩu cấp 2" ||
               textBox_pass.Text == "" || textBox_pass.Text == "Mật khẩu mới" ||
               textBox_repass.Text == "" || textBox_repass.Text == "Nhập lại mật khẩu mới")
            {
                label_check.Text = "Bạn chưa nhập đầy đủ thông tin!";
            }

            if (bllNV.Quen_Pass(textBox_pass.Text,textBox_user.Text))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_user.Clear();
                textBox_pass.Clear();
                textBox_repass.Clear();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
