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
    public partial class Menu : Form
    {
        string _manv;

        BLL.NhanvienBLL bllNV;
        DataTable _nhanvien;

        public string Tach_ten(string str)
        {
            str = str.Trim();
           
            string ten = str.Substring(str.LastIndexOf(' ') + 1);

            return ten;
        }


        public Menu( string manv)
        {
            InitializeComponent();
            bllNV = new BLL.NhanvienBLL();
            label_hello.Text = "Chào " + Tach_ten(bllNV.Get_tenNV(manv));
            _manv = manv;
            _nhanvien = bllNV.Get_All(_manv);
            if(_nhanvien.Rows[0][8].ToString()!="Quản lý")
            {
                quảnLýNhânViênToolStripMenuItem.Enabled = false;
            }
        }

        

        private void sânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Sanbay frmSanbay = new QL_Sanbay();
            frmSanbay.ShowDialog();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {

            label_time.Text = DateTime.Now.ToString("HH:mm");
            label_time2.Text = DateTime.Now.ToString("ss");
            label_date.Text = DateTime.Now.ToString("MMMM dd yyyy");
            label_day.Text = DateTime.Now.ToString("dddd");

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            timerClock.Start();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nhậnLịchChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NhanLichChuyenBay frm = new NhanLichChuyenBay();
            frm.ShowDialog();
        }

        private void bánVéĐặtVéTraCứuChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banve frm = new Banve(_manv);
            frm.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thaydoiquydinh frm = new Thaydoiquydinh();
            frm.ShowDialog();
        }

        private void báoCáoDoanhThuThángChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao_Thang frm = new Baocao_Thang();
            frm.ShowDialog();
        }

        private void báoCáoDoanhThuNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao_Nam frm = new Baocao_Nam();
            frm.ShowDialog();
        }

        private void quảnLýSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Sanbay frm = new QL_Sanbay();
            frm.ShowDialog();
        }

        private void quảnLýHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Hangve frm = new QL_Hangve();
            frm.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan_ly_account frm = new Quan_ly_account(_manv);
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dangnhap = new Dang_Nhap();
            Dangnhap.Closed += (s, args) => this.Close();
            Dangnhap.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan_ly_nhan_vien frm = new Quan_ly_nhan_vien();
            frm.ShowDialog();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void quảnLíPhiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuChi frm = new PhieuChi(_manv, bllNV.Get_tenNV(_manv));
            frm.ShowDialog();
        }
    }
}
