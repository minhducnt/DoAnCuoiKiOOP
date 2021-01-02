using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class KhachXem
    {
        public string TenKhach { get; set; }
        public string MaKhach { get; set; }
        public string MaVe { get; set; }
        public RandomDate NgayVaoXem { get; set; }

        public KhachXem(string TenKhach, string MaKhach, string MaVe, RandomDate NgayVaoXem)
        {
            this.TenKhach = TenKhach;
            this.MaKhach = MaKhach;
            this.MaVe = MaVe;
            this.NgayVaoXem = NgayVaoXem;
        }

        public KhachXem(KhachXem KX)
        {
            if (KX != null)
            {
                this.TenKhach = KX.TenKhach;
                this.MaKhach = KX.MaKhach;
                this.MaVe = KX.MaVe;
                this.NgayVaoXem = KX.NgayVaoXem;
            }
        }
    }
}