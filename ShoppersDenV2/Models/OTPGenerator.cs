using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV2.Models
{
    sealed class OTPGenerator
    {

        public int GenerateOTP(int min,int max)
        {
            return Faker.RandomNumber.Next(min, max);
        }
    }
}
