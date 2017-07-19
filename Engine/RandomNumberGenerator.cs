using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class RandomNumberGenerator
    {
        private static Random _random = new Random();

        public static int NumberInBetween(int minimumValue, int maximiumValue)
        {
            return _random.Next(minimumValue, maximiumValue+1);
        }
    }
}
