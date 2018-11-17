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
            while ((grendal.Health > 0) && (yopapa.Health > 0))
            {
                double Damage = grendal.Attack(grendal.Armour);
                grendal.TakeDamage(Damage);
                Console.WriteLine($"Yopapa's health: {grendal.Health} Amrour:{grendal.Armour}");
                Damage = yopapa.Attack(yopapa.Armour);
                yopapa.TakeDamage(Damage);
                Console.WriteLine($"Yopapa's health: {yopapa.Health} Amrour:{yopapa.Armour}");
            }
            if (grendal.Health > 0)
            {
                Console.WriteLine($"Grendal Proves Victorious");
            }
            else
            {
                Console.WriteLine($"YoPapa Proves Victorious");
            }

        }
    }
}
