using System;

namespace OOPPart1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");
            }

            //getters for class properties
            public string Name
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-Woof!");
                happiness += 0.2;
            }

            public void WagTail()
            {
                Console.WriteLine("Wiggle-Wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }

        }

        static void Main(string[] args)
        {
            Dog myDog = new Dog("Doggo", 15);
            //myDog.happiness = 10;
            //myDog.name = "Pablo";
            
            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }

            myDog.WagTail();
            Console.WriteLine("Rename your dog:");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);

            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level of happiness: {myDog.Happiness}");
        }
    }
}
