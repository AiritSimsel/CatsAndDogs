using System;

namespace CatsAndDogsOop
{
    class Program
    {
        class Pet
        {
            public string name;
            public string colour;
            public int levelOfHappiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Colour: {colour}");
                Console.WriteLine($"Happiness: {levelOfHappiness}");
            }

        }

        class Dog: Pet
        {
            public Dog(string _name, string _colour)
            {
                name = _name;
                colour = _colour;
                levelOfHappiness = 0;
            }

            public void WaveTail()
            {
                levelOfHappiness += 1;
            }
            public bool Bark()
            {
                Console.WriteLine("Woof-Woof");
                return true;
            }
        }
        class Cat: Pet
        {
            public Cat (string _name, string _colour)
            {
                name = _name;
                colour = _colour;
                levelOfHappiness = 10;
            }

            public void HearTheDog()
            {
                levelOfHappiness = 0;
            }
            public void Hiss ()
            {
                Console.WriteLine("Hsssssssss!");
            }
        }

        static void Main(string[] args)
        {
            Dog Rex = new Dog("Rex","black & white");
            Rex.PrintPetInfo();
            Cat Garfield = new Cat("Garfield", "ginger");
            Garfield.PrintPetInfo();

            
            for (int i = 0; i < 10; i++)
            {
                Rex.WaveTail();
            }
            
            if (Rex.Bark())
            {
                Garfield.HearTheDog();
            }
            if (Garfield.levelOfHappiness == 0)
            {
                Garfield.Hiss();
            }
            Garfield.PrintPetInfo();

        }
    }
}
