using System;

namespace OOPCat
{
    class Program
    {

        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
                Console.WriteLine($"The {color} cat {name} has been created.");
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                Console.WriteLine("Zzz");
                hunger += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("Meow!");
            }
        }

        
        static void Main(string[] args)
        {
            Cat myCat = new Cat("ScatMan", "Gray");

            while(myCat.Hunger != 1)
            {
                myCat.Sleep();
            }

            myCat.Meow();
        }
    }
}
