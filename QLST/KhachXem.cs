using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class KhachXem
    {
        public string MaKhach { get; set; }
        public string tenkhach { get; set; }
        public string MaVe { get; set; }
        public string NgayVaoXem { get; set; }

        public KhachXem(string MaKhach,string tenkhach, string MaVe, string NgayVaoXem)
        {
            this.MaKhach = MaKhach;
            this.tenkhach = tenkhach;
            this.MaVe = MaVe;
            this.NgayVaoXem = NgayVaoXem;
        }

        public KhachXem(KhachXem KX)
        {
            if (KX != null)
            {
                this.MaKhach = KX.MaKhach;
                this.tenkhach = KX.tenkhach;
                this.MaVe = KX.MaVe;
                this.NgayVaoXem = KX.NgayVaoXem;
            }
        }
    }
}