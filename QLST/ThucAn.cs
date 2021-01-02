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

        public ThucAn(string TenThucAn, string MaThucAn)
        {
            this.TenThucAn = TenThucAn;
            this.MaThucAn = MaThucAn;
        }

        public ThucAn(ThucAn TA)
        {
            if (TA != null)
            {
                this.TenThucAn = TA.TenThucAn;
                this.MaThucAn = TA.MaThucAn;
            }
        }
    }
}