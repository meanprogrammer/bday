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
        public static int GetRandomInteger()
        {
            int value = 0;
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
        }
    }
}
