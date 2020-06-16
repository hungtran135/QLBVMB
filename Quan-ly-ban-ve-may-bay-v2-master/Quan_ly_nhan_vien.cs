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
    public partial class Quan_ly_nhan_vien : Form
    {
        BLL.NhanvienBLL bllNV;


        public Quan_ly_nhan_vien()
        {
            bllNV = new BLL.NhanvienBLL();
            InitializeComponent();
        }


        public void ShowAllNhanVien()
        {
            DataTable dt = bllNV.Get_All_NV();
            dataGridView_nhan_vien.DataSource = dt;
        }

        private void Quan_ly_nhan_vien_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
        }

        private void dataGridView_nhan_vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                textBox_manv.Text = dataGridView_nhan_vien.Rows[index].Cells["Mã nhân viên"].Value.ToString();
                textBox_tennv.Text = dataGridView_nhan_vien.Rows[index].Cells["Tên nhân viên"].Value.ToString();
                textBox_diachi.Text = dataGridView_nhan_vien.Rows[index].Cells["Địa chỉ"].Value.ToString();
                textBox_sdt.Text = dataGridView_nhan_vien.Rows[index].Cells["Số điện thoại"].Value.ToString();
                textBox_cmnd.Text = dataGridView_nhan_vien.Rows[index].Cells["CMND"].Value.ToString();
                textBox_user.Text = dataGridView_nhan_vien.Rows[index].Cells["Tài khoản"].Value.ToString();
                textBox_pass.Text = dataGridView_nhan_vien.Rows[index].Cells["Mật khẩu"].Value.ToString();
                textBox_passlv2.Text = dataGridView_nhan_vien.Rows[index].Cells["Mật khẩu cấp 2"].Value.ToString();
                textBox_email.Text = dataGridView_nhan_vien.Rows[index].Cells["Email"].Value.ToString();
                comboBox_chucvu.Text = dataGridView_nhan_vien.Rows[index].Cells["Chức vụ"].Value.ToString();
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool CheckData()
        {
            if (!string.IsNullOrEmpty(textBox_manv.Text))
            {
                MessageBox.Show("Hãy bỏ chọn nhân viên hiện tại và nhấn vào khoảng trống ở bảng dưới để điền thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
           
                //False statement


                //if (string.IsNullOrEmpty(textBox_masb.Text) || string.IsNullOrEmpty(textBox_tensb.Text))
                if (string.IsNullOrEmpty(textBox_tennv.Text) || string.IsNullOrEmpty(textBox_diachi.Text) || string.IsNullOrEmpty(textBox_sdt.Text) ||
                     string.IsNullOrEmpty(textBox_cmnd.Text) || string.IsNullOrEmpty(textBox_user.Text) || string.IsNullOrEmpty(textBox_pass.Text) ||
                      string.IsNullOrEmpty(textBox_passlv2.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(comboBox_chucvu.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_tennv.Focus(); //để con trỏ vào đây
                    return false;
                }
                return true;
            
        }

        bool check_null()
        {
            if (string.IsNullOrEmpty(textBox_tennv.Text) || string.IsNullOrEmpty(textBox_diachi.Text) || string.IsNullOrEmpty(textBox_sdt.Text) ||
                    string.IsNullOrEmpty(textBox_cmnd.Text) || string.IsNullOrEmpty(textBox_user.Text) || string.IsNullOrEmpty(textBox_pass.Text) ||
                     string.IsNullOrEmpty(textBox_passlv2.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(comboBox_chucvu.Text))
            {

                 MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_tennv.Focus(); //để con trỏ vào đây
                return false;
            }
            return true;
        }


        private void button_them_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                DTO.Nhanvien nv = new DTO.Nhanvien();
                //sb.masb = textBox_masb.Text;
                nv.tennv = textBox_tennv.Text;
                nv.diachi = textBox_diachi.Text;
                nv.sdt = textBox_sdt.Text;
                nv.cmnd = textBox_cmnd.Text;
                nv.username = textBox_user.Text;
                nv.password = textBox_pass.Text;
                nv.passwordlv2 = textBox_passlv2.Text;
                nv.email = textBox_email.Text;
                nv.loai = comboBox_chucvu.Text;

                if (bllNV.check_trung_username_insert(nv))
                {

                    if (bllNV.InsertNhanVien(nv))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllNhanVien();
                        textBox_tennv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                        textBox_diachi.Clear();
                        textBox_sdt.Clear();
                        textBox_cmnd.Clear();
                        textBox_user.Clear();
                        textBox_pass.Clear();
                        textBox_passlv2.Clear();
                        textBox_email.Clear();
                        comboBox_chucvu.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return ;
                }

            }
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Maroon;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void button_cap_nhat_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                DTO.Nhanvien nv = new DTO.Nhanvien();
                nv.manv = textBox_manv.Text;
                nv.tennv = textBox_tennv.Text;
                nv.diachi = textBox_diachi.Text;
                nv.sdt = textBox_sdt.Text;
                nv.cmnd = textBox_cmnd.Text;
                nv.username = textBox_user.Text;
                nv.password = textBox_pass.Text;
                nv.passwordlv2 = textBox_passlv2.Text;
                nv.email = textBox_email.Text;
                nv.loai = comboBox_chucvu.Text;

                if (bllNV.check_trung_username(nv))
                {

                    if (bllNV.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllNhanVien();
                        textBox_tennv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                        textBox_diachi.Clear();
                        textBox_sdt.Clear();
                        textBox_cmnd.Clear();
                        textBox_user.Clear();
                        textBox_pass.Clear();
                        textBox_passlv2.Clear();
                        textBox_email.Clear();
                        comboBox_chucvu.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản trùng với tên tài khoản khác!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            DTO.Nhanvien nv = new DTO.Nhanvien();

            nv.manv = textBox_manv.Text;

            if (bllNV.DeleteNhanVien(nv))
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllNhanVien();
                textBox_tennv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                textBox_diachi.Clear();
                textBox_sdt.Clear();
                textBox_cmnd.Clear();
                textBox_user.Clear();
                textBox_pass.Clear();
                textBox_passlv2.Clear();
                textBox_email.Clear();
                comboBox_chucvu.Text = "";

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
