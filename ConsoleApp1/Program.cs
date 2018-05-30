using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog woofy = new Dog(15, 120, 900, 0);
            woofy.Run();
            Dog spot = new Dog();
            spot.RunningSpeed = 25;
            spot.Run();
            woofy.RunningSpeed = 100;
            woofy.Run();
            spot.Run();
        }
    }
}
