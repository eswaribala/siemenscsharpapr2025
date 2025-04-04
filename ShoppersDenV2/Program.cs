// See https://aka.ms/new-console-template for more information
using ShoppersDenV2.Models;

namespace ShoppersDenV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OTPGenerator otpGenerator = new OTPGenerator();
            Console.WriteLine($"Generated OTP={otpGenerator.GenerateOTP(1000, 9999)}");
            
        }
    }
}
