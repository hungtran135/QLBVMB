using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class NhanvienBLL
    {
        DAL.NhanvienDAL dal = new DAL.NhanvienDAL();

        public bool Login(string _user, string _pass)
        {
            return dal.Login(_user, _pass);
        }


        public string Get_maNV(string _user, string _pass)
        {
            return dal.Get_maNV(_user, _pass);
        }


        public string Get_tenNV(string id)
        {
            return dal.Get_tenNV(id);
        }

        public DataTable Get_All(string manv)
        {
            return dal.Get_All(manv);
        }

        public bool UpdateNV(string _id, string _ten,  string _diachi, string _sdt, string _email, string _cmnd, string _chucvu)
        {
            return dal.UpdateNV(_id,_ten,_diachi, _sdt, _email, _cmnd, _chucvu);
        }

        public bool Update_Doi_Pass(string _pass, string _id )
        {
            return dal.Update_Doi_Pass(_pass, _id);
        }

        public DataTable Get_All_NV()
        {
            return dal.Get_All_NV();
        }

        public bool InsertNhanVien(DTO.Nhanvien _nv)
        {
            return dal.InsertNhanVien(_nv);
        }

        public bool UpdateNhanVien(DTO.Nhanvien _nv)
        {
            return dal.UpdateNhanVien(_nv);
        }

        public bool DeleteNhanVien(DTO.Nhanvien _nv)
        {
            return dal.DeleteNhanVien(_nv);
        }

        public bool check_trung_username(DTO.Nhanvien _nv)
        {
            return dal.check_trung_username(_nv);
        }

        public bool check_trung_username_insert(DTO.Nhanvien _nv)
        {
            return dal.check_trung_username_insert(_nv);
        }

        public bool Quen_Pass(string pass, string name)
        {
            return dal.Quen_Pass(pass, name);
        }

        public bool check_passlv2(string user, string pass2)
        {
            return dal.check_passlv2(user, pass2);
        }


        public string Encrypt(string mk)
        {
            return dal.Encrypt(mk);
        }

        public string Decrypt(string mk)
        {
            return dal.Decrypt(mk);
        }


    }
}
