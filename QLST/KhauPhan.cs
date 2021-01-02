using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class KhauPhan
    {
        public string MaDongVat { get; set; }
        public string MaThucAn { get; set; }

        public KhauPhan(string MaDongVat, string MaThucAn)
        {
            this.MaDongVat = MaDongVat;
            this.MaThucAn = MaThucAn;
        }

        public KhauPhan(KhauPhan KP)
        {
            if (KP != null)
            {
                this.MaDongVat = KP.MaDongVat;
                this.MaThucAn = KP.MaThucAn;
            }
        }
    }
}