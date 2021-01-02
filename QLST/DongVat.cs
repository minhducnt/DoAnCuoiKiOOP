using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class DongVat
    {
        public string TenDongVat { get; set; }
        public string MaDongVat { get; set; }
        public string MaLoaiDongVat { get; set; }

        public DongVat(string TenDongVat, string MaDongVat, string MaLoaiDongVat)
        {
            this.TenDongVat = TenDongVat;
            this.MaDongVat = MaDongVat;
            this.MaLoaiDongVat = MaLoaiDongVat;
        }

        public DongVat(DongVat DV)
        {
            if (DV != null)
            {
                this.TenDongVat = DV.TenDongVat;
                this.MaDongVat = DV.MaDongVat;
                this.MaLoaiDongVat = DV.MaLoaiDongVat;
            }
        }
    }
}