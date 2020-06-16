using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    [TestFixture]
    class NhanVienTestInsert
    {
        [TestCase]
        //Trường hợp không nhập gì 
        public void InsertNV1()
        {
            DAL.NhanvienDAL dal = new DAL.NhanvienDAL();
            DTO.Nhanvien dto = new DTO.Nhanvien();
            Assert.IsFalse(dal.InsertNhanVien(dto));
        }
    }
}
