using FabricaDeChocolate;
using System;
using System.Threading.Tasks;

namespace FabricaDeChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100000, i =>
            {
                ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstace();
            });
        }
    }
}