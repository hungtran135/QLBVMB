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
    public partial class Dang_Nhap : Form
    {
        BLL.NhanvienBLL bllNV;
        int _clr_u = 1;
        int _clr_p = 1;

        public Dang_Nhap()
        {
            InitializeComponent();
            bllNV = new BLL.NhanvienBLL();
        }

        private void Dang_Nhap_Load(object sender, EventArgs e)
        {

        }


        private void textBox_user_Click(object sender, EventArgs e)
        {
            if (_clr_u == 1)
            {
                textBox_user.Clear();
                _clr_u = 0;
            }
            pictureBox_user.Image = Properties.Resources.useri2;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            textBox_user.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox_pass.Image = Properties.Resources.pass2;
            panel2.ForeColor = Color.WhiteSmoke;
            textBox_pass.ForeColor = Color.WhiteSmoke;
        }

        private void textBox_pass_Click(object sender, EventArgs e)
        {
            if (_clr_p == 1)
            {
                textBox_pass.Clear();
                textBox_pass.PasswordChar = '*';
                _clr_p = 0;
            }
            pictureBox_pass.Image = Properties.Resources.pass3;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            textBox_pass.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox_user.Image = Properties.Resources.useri;
            panel1.ForeColor = Color.WhiteSmoke;
            textBox_user.ForeColor = Color.WhiteSmoke;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.LightCoral;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }
        
        private void button_dang_nhap_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text == "" || textBox_user.Text == "Tên đăng nhập"
                || textBox_pass.Text == "" || textBox_pass.Text == "Mật khẩu")
            {
                label_check.Text = "Bạn chưa nhập tên đăng nhập \r\nhoặc mật khẩu!";
            }
            else
            {
                if (bllNV.Login(textBox_user.Text.ToString(), textBox_pass.Text.ToString()))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var Menu = new Menu(bllNV.Get_maNV(textBox_user.Text.ToString(), textBox_pass.Text.ToString()));
                    Menu.Closed += (s, args) => this.Close();
                    Menu.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void button_quen_mk_Click(object sender, EventArgs e)
        {
            Quen_pass frm = new Quen_pass();
            frm.ShowDialog();
        }

        public string Str(string str)
        {
            str = str.Trim();
            String ho = str.Substring(0, str.IndexOf(' '));
            string td = str.Substring(str.IndexOf(' ') + 1, str.LastIndexOf(' ') - ho.Length - 1);
            string ten = str.Substring(str.LastIndexOf(' ') + 1);
    
            return ten;
        }

     




    }
}
