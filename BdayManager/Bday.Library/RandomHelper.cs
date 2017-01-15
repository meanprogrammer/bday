using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bday.Library
{
    public class RandomHelper
    {
        public static int GetRandomInteger(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);

            /*
            int value = 0;
            while(value < )
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Buffer storage.
                byte[] data = new byte[4];

                // Fill buffer.
                rng.GetBytes(data);

                // Convert to int 32.
                value = BitConverter.ToInt32(data, 0);
            }
            return value;
             */
        }
    }
}
