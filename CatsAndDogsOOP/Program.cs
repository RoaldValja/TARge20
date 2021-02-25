using System;

namespace CatsAndDogsOOP
{
    class Program
    {
        class Pet
        {
            public string name;
            public string color;
            public int levelOfHappiness;
            public void PrintPetInfo()
            {
                string animal = "";
                if (GetType() == typeof(Cat))
                {
                    animal = "cat";
                }
                else
                {
                    animal = "dog";
                }
                Console.WriteLine($"animal type: {animal}");
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"color: {color}");
                Console.WriteLine($"level of happiness: {levelOfHappiness}");
            }
        }
        class Dog : Pet
        {
            public Dog(string name, string color)
            {
                this.name = name;
                this.color = color;
                levelOfHappiness = 0;
            }
            public void waveTail()
            {
                levelOfHappiness += 1;
            }
            public bool Bark()
            {
                Console.WriteLine("woof woof");
                return true;
            }
        }
        class Cat : Pet
        {
            public Cat(string name, string color)
            {
                this.name = name;
                this.color = color;
                levelOfHappiness = 10;
            }
            public void HearTheDog()
            {
                levelOfHappiness = 0;
            }
            public void Hiss()
            {
                Console.WriteLine("Hssssssssss");
            }
        }

        static void Main(string[] args)
        {
            Cat miisu = new Cat("Miisu", "black");
            Dog rex = new Dog("Rex", "brown");
            rex.PrintPetInfo();
            miisu.PrintPetInfo();
            rex.waveTail();

            for (int i = 0; i < 10; i++)
            {
                rex.waveTail();
            }
            rex.PrintPetInfo();
            if (rex.Bark())
            {
                miisu.HearTheDog();
            }
            if (miisu.levelOfHappiness == 0)
            {
                miisu.Hiss();
            }
        }
    }
}
