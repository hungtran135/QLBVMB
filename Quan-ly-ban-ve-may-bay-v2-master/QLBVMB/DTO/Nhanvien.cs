using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Nhanvien
    {
        public string manv { set; get; }
        public string tennv { set; get; }
        public string diachi { set; get; }
        public string sdt { set; get; }
        public string email { set; get; }
        public string cmnd { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string loai { set; get; }
        public string passwordlv2 { set; get; }
       



        public Nhanvien()
        {

        }

        public Nhanvien(string _manv, string _tennv, string _diachi, string _sdt, 
            string _email, string _cmnd, string _username, string _password, string _loai, string _passwordlv2)
        {
            this.manv = _manv;
            this.tennv = _tennv;
            this.diachi = _diachi;
            this.sdt = _sdt;
            this.email = _email;
            this.cmnd = _cmnd;
            this.username = _username;
            this.password = _password;
            this.loai = _loai;
            this.passwordlv2 = _passwordlv2;
            
        }

    }
}
