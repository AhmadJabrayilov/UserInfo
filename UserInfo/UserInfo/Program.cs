using System;
using UserInfo.Models;
namespace UserInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User();
            usr1.age = 15;
            Console.WriteLine($"Istifadecinin Yashi: {usr1.age}");
            usr1.password = "pAssw0rd";
            Console.WriteLine($"istifadeci passwordu: {usr1.password}");
            

        }
    }
}
