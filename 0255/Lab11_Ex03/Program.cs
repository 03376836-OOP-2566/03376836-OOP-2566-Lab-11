var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
   public virtual void Move()
   {
    System.Console.WriteLine("Move successfully.");
   } 
}

class Dog:Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Running on the ground.");
        base.Move();
    }
}
class Fish: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Swimming in the water.");
        base.Move();
    }
}

class Bird: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Flying in the air.");
        base.Move();
    }
}