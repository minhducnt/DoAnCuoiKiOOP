using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class Ve
    {
        public string MaVe { get; set; }
        public string MaKhach { get; set; }
        public string MaNhanVienBanVe { get; set; }
        public string NgayBan { get; set; }

        public Ve(string MaVe, string MaKhach, string MaNhanVienBanVe, string NgayBan)
        {
            this.MaVe = MaVe;
            this.MaKhach = MaKhach;
            this.MaNhanVienBanVe = MaNhanVienBanVe;
            this.NgayBan = NgayBan;
        }

        public Ve(Ve V)
        {
            if (V != null)
            {
                this.MaNhanVienBanVe = V.MaNhanVienBanVe;
                this.MaVe = V.MaVe;
                this.MaKhach = V.MaKhach;
                this.NgayBan = V.NgayBan;
            }
        }
    }
}