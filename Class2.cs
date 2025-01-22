using System;


public class Exercise11
{
    
    public static void Main()
    {
       class Car
    {
        public string brand = "Toyota";

        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.brand); 
            myCar.Honk();
        }
    }


    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.MakeSound(); 
            myDog.Bark();
        }
    }
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "John";
            Console.WriteLine(p.Name); 
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal myCat = new Cat();
            myCat.Speak(); 
        }
    }
    
    try
{
    int a = 10, b = 0;
    int result = a / b;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("End of try-catch");
}

}
}
