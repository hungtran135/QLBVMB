using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    [TestFixture]
    class NhanVienTest
    {
        private DAL.NhanvienDAL dal;
        private Quan_ly_nhan_vien fm;
        private DTO.Nhanvien dto;
        [SetUp]
        public void Setup()
        {
            dal = new DAL.NhanvienDAL();
            fm = new Quan_ly_nhan_vien();
            dto = new DTO.Nhanvien(null, null, null, null, null, null, null, null, null, null);
        }
        [TestCase]
        //Trường hợp nhập tài khoản và mật khẩu đúng
        public void LoginTest1()
        {         
            Assert.IsTrue(dal.Login("admin", "1"));
        }
        [TestCase]
        //Trường hợp nhập tài khoản đúng và nhập mật khẩu sai
        public void LoginTest2()
        {
            Assert.IsFalse(dal.Login("admin", "3"));
        }
        [TestCase]
        //Trường hợp nhập tài khoản sai và nhập mật khẩu đúng
        public void LoginTest3()
        {
            Assert.IsFalse(dal.Login("a", "1"));
        }
        [TestCase]
        //Trường hợp nhập tài khoản và mật khẩu sai
        public void LoginTest4()
        {
            Assert.IsFalse(dal.Login("a", "3"));
        }
        [TestCase]
        //Trường hợp không nhập tài khoản và mật khẩu
        public void LoginTest5()
        {
            Assert.IsFalse(dal.Login(null, null));
        }
        [TestCase]
        //Trường hợp nhập tài khoản nhưng không nhập mật khẩu
        public void LoginTest6()
        {
            Assert.IsFalse(dal.Login("a", null));
        }
        [TestCase]
        //Trường hợp nhập mật khẩu nhưng không nhập tài khoản
        public void LoginTest7()
        {
            Assert.IsFalse(dal.Login(null, "1"));
        }
        [TestCase]
        //Trường hợp đăng nhập với tài khoản quản lí
        public void LoginTest8()
        {
            Assert.IsTrue(dal.Login("admin", "1"));
        }
        [TestCase]
        //Trường hợp đăng nhập với tài khoản nhân viên
        public void LoginTest9()
        {
            Assert.IsTrue(dal.Login("user", "1234"));
        }

        [TestCase]
        //Trường hợp không nhập gì 
        public void InsertNV1()
        {
      
            bool result;
            if (fm.CheckDataNV(dto) == false)
                result = false;
            else
            {
                result = dal.InsertNhanVien(dto);
            }
            Assert.IsFalse(result);
        }

    }
}
