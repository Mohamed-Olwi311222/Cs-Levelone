using System.Security.Cryptography.X509Certificates;

namespace Section_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Army k1 = new Army("Captain","friend");
            k1.name = "mohamed";
            k1.armour = 150;
            k1.damage = 50;
            k1.health = 200;
            k1.status = true;
            k1.weapon = "Tommygun";
            Console.WriteLine(Army.counter);
            Army.printAllAttributes(k1);
            
        }
    }


    public class Army {
        //properties
        public string name;
        public string rank;    
        public double health;
        public double armour;
        public bool status;
        public double damage;
        public string weapon;
        public string type;
        
        public static int counter;

        //constructor
        public Army(string name)
        {
            this.name = name;
        }
        public Army(bool status)
        {
            this.status = status;
        }
        public Army(double health)
        {
            this.health = health;
            counter++;
        }
        public Army(string rank, string type)
        {
            this.rank = rank;
            this.type = type;
        }
        public Army(string weapon, double damage)
        {
            this.weapon = weapon;
            this.damage = damage;
        }
        //methods
        public void attack(Army obj1,Army obj2)
        {
            //if one of the objects attack and the two are different types(friend or foe) 
            if (obj1.type!=obj2.type)
            {
                obj1.health = obj1.health - obj2.damage;
            }            
        }
        public void regenerateHealth(Army obj1)
        {
            Console.WriteLine("pickup medkit? 1 for true and 0 for false");
            bool pickedup = Convert.ToBoolean(Console.ReadLine());
            if (pickedup == true)
            {
                obj1.health = 100;
            }
        }
         public void regenerateArmour(Army obj1)
        {
            Console.WriteLine("pickup armour? 1 for true and 0 for false");
            bool pickedup = Convert.ToBoolean(Console.ReadLine());
            if (pickedup == true)
            {
                obj1.armour = 150;
            }
        }

        public bool changeWeapon(Army obj)
        {
            Console.WriteLine("Change your weapon to AK-27? 1 for true and 0 for false" );
            bool pickedup=Convert.ToBoolean(Console.ReadLine()) ;
            string newweapon = "AK-27";
            if (pickedup == true)
            {
                obj.weapon = newweapon;
            }
            return pickedup;
        }
    

        public void changeTeam(Army obj)
        {
            Console.WriteLine("change your team to the opposite one? 1 for true and 0 for false");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == true)
            {
                obj.type = "foe";
            }
        }
        public static void printAllAttributes(Army obj)
        {
            Console.WriteLine($"health={obj.health} , name={obj.name} , rank={obj.rank} , type={obj.type} , damage={obj.damage}" );
        }


    }
}