using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    public class CouponNumber
    {
        public int N;
        public static void Coupon(int N)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(random.Next());
            }
        }
    }
}
