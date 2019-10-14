using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FabricaDeChocolate
{
    public class ChocolateBoiler
    {
        public string Name { get; set; }
        private static ChocolateBoiler Instance { get; set; }

        private static readonly object chocolateBoilerLock = new object();

        private bool Empty { get; set; }
        private bool Boiled { get; set; }

        public static ChocolateBoiler GetInstace()
        {
            if (Instance == null)
            {
                lock(chocolateBoilerLock)
                {
                    if(Instance == null)
                    {
                        Console.WriteLine($"Instance ==> NULL");
                        Instance = new ChocolateBoiler();
                    }
                }
            }

            return Instance;
        }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public void Fill()
        {
            Console.WriteLine($"Fill", Instance.ToString());
            if(!isEmpty())
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            Console.WriteLine($"Drain", Instance.ToString());

            if (!isEmpty() && isBoiled())
            {
                Empty = true; 
            }
        }

        public void Boil()
        {
            Console.WriteLine($"Boil", Instance.ToString());

            if (!isEmpty() && isBoiled())
            {
                Boiled = true;
            }
        }

        public bool isEmpty()
        {
            Console.WriteLine($"isEmpty", Instance.ToString());

            return Empty;
        }
        public bool isBoiled()
        {
            Console.WriteLine($"isBoiled", Instance.ToString());

            return Boiled;
        }
    }
}
