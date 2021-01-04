using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class CongTyBanVe
    {
        public string MaCongTy { get; set; }
        public string TenCongTy { get; set; }
        public int SoLuongVeMua { get; set; }
        public int SoLuongVeBan { get; set; }
        public RandomDate NgayMua { get; set; }

        public CongTyBanVe(string MaCongTy, string TenCongTy, int SoLuongVeMua, int SoLuongVeBan, RandomDate NgayMua)
        {
            this.MaCongTy = MaCongTy;
            this.TenCongTy = TenCongTy;
            this.SoLuongVeMua = SoLuongVeMua;
            this.SoLuongVeBan = SoLuongVeBan;
            this.NgayMua = NgayMua;
        }

        public CongTyBanVe(CongTyBanVe CTY)
        {
            if (CTY != null)
            {
                this.MaCongTy = CTY.MaCongTy;
                this.TenCongTy = CTY.TenCongTy;
                this.SoLuongVeMua = CTY.SoLuongVeMua;
                this.SoLuongVeBan = CTY.SoLuongVeBan;
                this.NgayMua = CTY.NgayMua;
            }
        }
    }
}