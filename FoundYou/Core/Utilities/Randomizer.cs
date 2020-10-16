using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FoundYou.Core.Utilities
{
    public static class Randomizer
    {
        private static readonly RNGCryptoServiceProvider Generator = new RNGCryptoServiceProvider();

        private static Random Generate()
        {
            var buffer = new byte[4];
            Generator.GetBytes(buffer);
            return new Random(BitConverter.ToInt32(buffer, 0));
        }

        public static Random Instance => _rand ?? (_rand = Generate());
        [ThreadStatic] private static Random _rand;
    }
}
