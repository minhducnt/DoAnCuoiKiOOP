using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class PhongBan
    {
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string DiaDiem { get; set; }

        public PhongBan(string MaPhongBan, string TenPhongBan, string DiaDiem)
        {
            this.MaPhongBan = MaPhongBan;
            this.TenPhongBan = TenPhongBan;
            this.DiaDiem = DiaDiem;
        }

        public PhongBan(PhongBan PB)
        {
            if (PB != null)
            {
                this.MaPhongBan = PB.MaPhongBan;
                this.TenPhongBan = PB.TenPhongBan;
                this.DiaDiem = PB.DiaDiem;
            }
        }
    }
}