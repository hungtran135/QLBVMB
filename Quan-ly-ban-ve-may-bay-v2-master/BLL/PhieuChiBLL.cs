using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class PhieuChiBLL
    {


        DAL.PhieuChiDAL dalPC;
        public PhieuChiBLL()
        {
            dalPC = new DAL.PhieuChiDAL();
        }

        public bool InsertPhieuChi(DTO.PhieuChi pc)
        {
            return dalPC.InsertPhieuChi(pc);
        }

        public DataTable Get_All_PC()
        {
            return dalPC.Get_All_PC();
        }


    }
}
