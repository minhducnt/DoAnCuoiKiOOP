using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class ThucAn
    {
        public string TenThucAn { get; set; }
        public string MaThucAn { get; set; }

        public ThucAn(string MaThucAn, string TenThucAn)
        {
            this.MaThucAn = MaThucAn;
            this.TenThucAn = TenThucAn;
        }

        public ThucAn(ThucAn TA)
        {
            if (TA != null)
            {
                this.MaThucAn = TA.MaThucAn;
                this.TenThucAn = TA.TenThucAn;
            }
        }
    }
}