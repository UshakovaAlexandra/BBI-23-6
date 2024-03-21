// КР 
//6.2
using System;
abstract class Animal
{
protected string name;
protected string dietType;
public string DietType { get { return dietType; } }
public Animal(string name, string dietType)
{
this.name = name;
this.dietType = dietType;
}
public abstract void MakeSound();
public void PrintInfo()
{
Console.WriteLine( "Name: name", this.name);
Console.WriteLine("DietType: dietType " , this.dietType);
Console.Write("Sound: ");
MakeSound();
Console.WriteLine();
}
}
class Giraffe : Animal
{
public Giraffe(string name) : base(name , "Herbivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Giraffe: *silence*");
}
}
class Pig : Animal
{
public Pig(string name) : base(name, "Omnivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Pig: Oink oink!");
}
}
class Elephant : Animal
{
public Elephant(string name) : base(name, "Herbivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Elephant: Trumpet!");
}
}
class Lion : Animal
{
public Lion(string name) : base(name, "Carnivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Lion: Roar!");
}
}
class Tiger : Animal
{
public Tiger(string name) : base(name, "Carnivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Tiger: Growl!");
}
}
class Monkey : Animal
{
public Monkey(string name) : base(name, "Omnivore")
{
}
public override void MakeSound()
{
Console.WriteLine("Monkey: Ooh ooh aah aah!");
}
}
class Program
{
static void Main()
{
Animal[] animals = new Animal[]
{
new Giraffe("Giraffe1"), new Giraffe("Giraffe2"), new Giraffe ("Giraffe3"),
new Pig("Pig1"), new Pig("Pig2"), new Pig("Pig3"),
new Elephant("Elephant1"), new Elephant("Elephant2"), new Elephant("Elephant3"),
new Lion("Lion1"), new Lion("Lion2"), new Lion("Lion3"),
new Tiger("Tiger1"), new Tiger("Tiger2"), new Tiger("Tiger3"),
new Monkey("Monkey1"), new Monkey("Monkey2"), new Monkey("Monkey3")
};
Console.WriteLine("Herbivores:");
PrintAnimalsByDietType(animals, "Herbivore");
Console.WriteLine("Carnivores:");
PrintAnimalsByDietType(animals, "Carnivore");
Console.WriteLine("Omnivores:");
PrintAnimalsByDietType(animals, "Omnivore");
Console.ReadKey();
}
static void PrintAnimalsByDietType(Animal[] animals, string dietType)
{
foreach (Animal animal in animals)
{
if (animal.DietType == dietType)
{
animal.PrintInfo();
}
}
}
}
