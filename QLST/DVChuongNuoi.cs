using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class DVChuongNuoi
    {
        public string MaChuong { get; set; }
        public string MaDongVat { get; set; }
        public RandomDate NgayVaoChuong { get; set; }
        public string TGRaChuong { get; set; }

        public DVChuongNuoi(string MaDongVat, string MaChuong, RandomDate NgayVaoChuong, string TGRaChuong)
        {
            this.MaDongVat = MaDongVat;
            this.MaChuong = MaChuong;
            this.NgayVaoChuong = NgayVaoChuong;
            this.TGRaChuong = TGRaChuong;
        }

        public DVChuongNuoi(DVChuongNuoi DVCN)
        {
            if (DVCN != null)
            {
                this.MaDongVat = DVCN.MaDongVat;
                this.MaChuong = DVCN.MaChuong;
                this.NgayVaoChuong = DVCN.NgayVaoChuong;
                this.TGRaChuong = DVCN.TGRaChuong;
            }
        }
    }
}