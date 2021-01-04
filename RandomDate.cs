using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class RandomDate
    {
        public DateTime RandomDateTime(DateTime? min = null, DateTime? max = null)
        {
            System.Random Rnd = new System.Random();

            min = min ?? new DateTime(2019, 01, 01);
            max = max ?? new DateTime(2020, 12, 31);

            var range = max.Value - min.Value;
            var randomUpperBound = (Int32)range.TotalSeconds;
            if (randomUpperBound <= 0)
                randomUpperBound = Rnd.Next(1, Int32.MaxValue);

            var randTimeSpan = TimeSpan.FromSeconds((Int64)(range.TotalSeconds - Rnd.Next(0, randomUpperBound)));
            return min.Value.Add(randTimeSpan);
        }
    }
}