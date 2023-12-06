namespace kt7;

public abstract class Animal
{
    public string Name { get; set; }

    public abstract void SayHello();
}

public class Dog : Animal
{
    public override void SayHello()
    {
        Console.WriteLine("Woof! My name is " + Name);
    }
}

public class Cat : Animal
{
    public override void SayHello()
    {
        Console.WriteLine("Meow! My name is " + Name);
    }
}

public static class AnimalHelper
{
    public static void GreetAnimals(List<Animal> animals, Action<Animal> greetAction)
    {
        foreach (var animal in animals)
        {
            greetAction(animal);
        }
    }
}

public class Program
{
    public static void Main()
    {
        var animals = new List<Animal>
        {
            new Dog { Name = "Rex" },
            new Cat { Name = "Mittens" },
            
        };

       
        Action<Animal> greetCovariant = (Animal animal) =>
        {
            Console.WriteLine("Covariant Greeting:");
            animal.SayHello();
        };

       
        Action<object> greetContravariant = (object obj) =>
        {
            if (obj is Animal animal)
            {
                Console.WriteLine("Contravariant Greeting:");
                animal.SayHello();
            }
        };

        
        AnimalHelper.GreetAnimals(animals, greetCovariant);

        
        AnimalHelper.GreetAnimals(animals, greetContravariant);
    }
}