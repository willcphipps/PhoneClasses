using System;
using PhoneAssignment.Models;

namespace PhoneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone apple = new IPhone("6", 75, "AT&T","de-de-de de di-du-de dedidu de dudu de-de");
            Galaxy android = new Galaxy("S.4", 15, "Ting", "Ringggg, Ring Ring RRIIIBriinNGN!");
            Console.WriteLine(apple.Ring());
            Console.WriteLine(apple.Unlock());
            apple.DisplayInfo();

            Console.WriteLine("------------------");

            Console.WriteLine(android.Ring());
            Console.WriteLine(android.Unlock());
            android.DisplayInfo();


        }
    }
}
