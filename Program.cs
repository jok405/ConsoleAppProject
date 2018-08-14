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

        interface IDamagable
        {
            int durability { get; set; }
            void TakeDamage(int _amount);
        }

        interface IPartOfQuest
        {
            void TurnIn();
        }

        class Sword : IItem, IDamagable, IPartOfQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 30;
            }
            public void Equip ()
            {
                Console.WriteLine(name + " equipped.");
            }
            public void Sell ()
            {
                Console.WriteLine(name + " sold for " + goldValue + " imaginary dollars!");
            }
            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " took damage by" + _dmg + ". It now has a durability of " + durability);
            }
            public void TurnIn()
            {
                Console.WriteLine(name + "Turn in (it was an axe ).");
            }
        }

            class Axe : IItem, IDamagable
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Axe(string _name)
            {
                name = _name;
                goldValue = 70;
                durability = 50;
            }
            public void Equip()
            {
                Console.WriteLine(name + " equipped.");
            }
            public void Sell()
            {
                Console.WriteLine(name + " sold for " + goldValue + " imaginary dollars!");
            }
            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " took damage by" + _dmg + ". It now has a durability of " + durability);
            }
        }
        public static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.Sell();

            Axe axe = new Axe("Fury Axe");
            axe.Equip();
            axe.Sell();

            // Create an inventory
            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            // Loop through and turn in all quest items
            for (int i = 0; i < inventory.Length; i++)
            {
                IPartOfQuest questItem = inventory[i] as IPartOfQuest;
                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }
            Console.ReadKey();
        }
    }
}
