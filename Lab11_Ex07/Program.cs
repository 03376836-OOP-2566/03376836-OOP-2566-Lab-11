// See https://aka.ms/new-console-template for more information
class Base
{
    public virtual void A()
    {
        System.Console.WriteLine("Base.A()");
    }
}
class Derived_1 : Base
{
    public override void A()
    {
        System.Console.WriteLine("Derived_1.A()");
    }
}
class Derived_2 : Derived_1
{
    // ไม่ต้อง override method A()
    // public override void A()
    // {
    // System.Console.WriteLine("Derived_2.A()");
    // }
}

class Program
{
    static void Main(string[] args)
    {
        Derived_2 d2 = new Derived_2();

        Base b = (Base)d2;
        b.A(); // "Base.A()"

        Derived_1 d1 = (Derived_1)d2;
        d1.A(); // "Derived_1.A()"

        d2.A(); // "Derived_1.A()"
    }
}
