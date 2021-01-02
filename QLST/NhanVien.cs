using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaPhongBan { get; set; }
        public string ChucVu { get; set; }

        public NhanVien(string MaNhanVien, string TenNhanVien, string MaPhongBan, string ChucVu)
        {
            this.MaPhongBan = MaPhongBan;
            this.MaNhanVien = MaNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.ChucVu = ChucVu;
        }

        public NhanVien(NhanVien NV)
        {
            if (NV != null)
            {
                this.MaPhongBan = NV.MaPhongBan;
                this.MaNhanVien = NV.MaNhanVien;
                this.TenNhanVien = NV.TenNhanVien;
                this.ChucVu = NV.ChucVu;
            }
        }
    }
}