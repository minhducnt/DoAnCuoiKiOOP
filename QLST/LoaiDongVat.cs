using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class LoaiDongVat
    {
        public string TenLoaiDongVat { get; set; }
        public string MaLoaiDongVat { get; set; }

        public LoaiDongVat(string TenLoaiDongVat, string MaLoaiDongVat)
        {
            this.TenLoaiDongVat = TenLoaiDongVat;
            this.MaLoaiDongVat = MaLoaiDongVat;
        }

        public LoaiDongVat(LoaiDongVat LDV)
        {
            if (LDV != null)
            {
                this.TenLoaiDongVat = LDV.TenLoaiDongVat;
                this.MaLoaiDongVat = LDV.MaLoaiDongVat;
            }
        }
    }
}