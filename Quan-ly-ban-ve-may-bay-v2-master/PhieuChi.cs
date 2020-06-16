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
    public partial class PhieuChi : Form
    {
        BLL.PhieuChiBLL bllPC;
        string ID_nv;
        string name;

        public PhieuChi(string manv, string tennv)
        {
            bllPC = new BLL.PhieuChiBLL();
            InitializeComponent();
            name = tennv;
            ID_nv = manv;
        }

        public void ShowAllPC()
        {
            DataTable dt = bllPC.Get_All_PC();
            dataGridView_pc.DataSource = dt;
        }

      

        private void PhieuChi_Load(object sender, EventArgs e)
        {
            textBox_manv.Text = ID_nv;
            textBox_tenNV.Text = name;
            ShowAllPC();
        }

        public bool CheckData()
        {
            if(textBox_sotien.Text==""||textBox_lido.Text==""||textBox_noidung.Text=="")
            {
                return false;
            }
            return true;
        }


        private void button_them_Click(object sender, EventArgs e)
        {


            if (CheckData())
            {
                DTO.PhieuChi pc = new DTO.PhieuChi();
                //sb.masb = textBox_masb.Text;
                pc.manv = textBox_manv.Text;
                pc.tenpc = textBox_lido.Text;
                pc.giapc = Convert.ToDecimal(textBox_sotien.Text.ToString());
                pc.noidung = textBox_noidung.Text;
                pc.thoigian = DateTime.Now;



                if (bllPC.InsertPhieuChi(pc))
                {
                    MessageBox.Show("Thêm phiếu chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllPC();
                    textBox_lido.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_sotien.Clear();
                    textBox_noidung.Clear();
                  
                   

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }


        }




        

        private void label_tenpc_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
