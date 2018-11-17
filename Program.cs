using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf yopapa = new Elf("YoPapa", 100);
            Console.WriteLine($"YoPapa has {yopapa.Health}");
            Orc grendal = new Orc("Grendal", 85);
            Console.WriteLine($"Grendal has {grendal.Health}");
            int Round = 0;
            while ((grendal.Health > 0) && (yopapa.Health > 0))
            {
                Round++;
                double Damage = grendal.Attack(grendal.Armour);
                grendal.TakeDamage(Damage);
                Console.WriteLine($"Round: {Round}"); 
                Console.WriteLine($"Grendal's health: {grendal.Health} Amrour:{grendal.Armour}");
                Damage = yopapa.Attack(yopapa.Armour);
                yopapa.TakeDamage(Damage);
                Console.WriteLine($"Yopapa's health: {yopapa.Health} Amrour:{yopapa.Armour}" + "\n");
            }
            if (grendal.Health > 0)
            {
                Console.WriteLine($"Press F to pay respects to Yopapa");
            }
            else
            {
                Console.WriteLine($"YoPapa Proves Victorious!");
            }

        }
    }
}
