using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    class MainClass
    {
        interface IItem
        {
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }

        class Sword : IItem
        {
            public string name { get; set; }
            public int goldValue { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
            }
            public void Equip ()
            {
                Console.WriteLine(name + " equipped.");
            }
            public void Sell ()
            {
                Console.WriteLine(name + " sold for " + goldValue + " imaginary dollars!");
            }
        }
        public static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.Sell();
            Console.ReadKey();
        }
    }
}
