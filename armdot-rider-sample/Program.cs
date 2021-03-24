using System;
using System.Security.Cryptography;
using System.Text;

namespace armdot_rider_sample
{
    class Program
    {
        [ArmDot.Client.VirtualizeCode]
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password and press ENTER");

            if (CheckPassword(Console.ReadLine()))
                Console.WriteLine("The password is correct");
            else
                Console.WriteLine("The password is not correct");
        }

        [ArmDot.Client.VirtualizeCode]
        static bool CheckPassword(string value)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));
                return "mZfua8BSQJP337Kuj4Cpl9dVBL/S6Cn1SioM0xcq2tg=" == Convert.ToBase64String(hashValue);
            }
        }
    }
}