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
    public partial class Quan_ly_account : Form
    {
        BLL.NhanvienBLL bllNV;
        DataTable infor;
        string ma_nv;

        public Quan_ly_account(string _manv)
        {
          
            InitializeComponent();
            bllNV = new BLL.NhanvienBLL();

            
            ma_nv = _manv;
           
        }

        void ReLoad()
        {
            infor = bllNV.Get_All(ma_nv);
 
            textBox_tennv.Text = infor.Rows[0][1].ToString();
            textBox_manv.Text = infor.Rows[0][0].ToString();
           
            textBox_diachi.Text = infor.Rows[0][2].ToString();
            textBox_sdt.Text = infor.Rows[0][3].ToString();
            textBox_email.Text = infor.Rows[0][4].ToString();
            textBox_cmnd.Text = infor.Rows[0][5].ToString();
            textBox_chucvu.Text = infor.Rows[0][8].ToString();
        }

        private void button_cap_nhat_Click(object sender, EventArgs e)
        {
           if( bllNV.UpdateNV(textBox_manv.Text.ToString(), textBox_tennv.Text.ToString(),
                textBox_diachi.Text.ToString(), textBox_sdt.Text.ToString(), textBox_email.Text.ToString(), textBox_cmnd.Text.ToString(), textBox_chucvu.Text.ToString()))
           {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Quan_ly_account_Load(sender,e);
           }
           else
           {
                MessageBox.Show("Có lỗi xảy ra, cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Quan_ly_account_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void button_doi_pass_Click(object sender, EventArgs e)
        {
            if(textBox_pass.Text==textBox_repass.Text)
            {
                if(bllNV.Update_Doi_Pass(textBox_pass.Text,textBox_manv.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu chưa trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }









    }
}
