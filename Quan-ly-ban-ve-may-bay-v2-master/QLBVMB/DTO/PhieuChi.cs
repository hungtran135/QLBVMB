using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class PhieuChi
    {

        
            public string mapc { set; get; }
            public string manv { set; get; }
            public string tenpc { set; get; }
            public decimal giapc { set; get; }
            public string noidung { set; get; }
            public DateTime thoigian { set; get; }



            public PhieuChi()
            {

            }

            public PhieuChi(string _mapc, string _manv, string _tenpc, decimal _giapc, string _noidung)
            {
                this.mapc = _mapc;
                this.manv = _manv;
                this.tenpc = _tenpc;
                this.giapc = _giapc;
                this.noidung = _noidung;
               
            }



    }
}
