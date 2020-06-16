using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class HanhLy
    {

        public string mahl { set; get; }
        public string mahk { set; get; }
        public string tenhl { set; get; }
        public float gia { set; get; }




        public HanhLy()
        {

        }

        public HanhLy(string _mahl, string _mahk, string _tenhl, float _gia)
        {
            this.mahl = _mahl;
            this.mahk = _mahk;
            this.tenhl = _tenhl;
            this.gia = _gia;


        }
    }

}



