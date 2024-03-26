# Lab 11 Exercise 6

## Masking virtual member inheritance by keyword `new`

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex06
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Derived_2 d2 = new Derived_2();
Base b = (Base) d2;
Derived_1 d1 = (Derived_1) d2;


b.A();
d1.A();
d2.A();

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
    public new void A()
    {
        System.Console.WriteLine("Derived_2.A()");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="560" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/a98ebb50-0c73-481c-a714-6871e461cb12">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="433" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/9341d383-feb8-496f-b5dc-58c9e623a495">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
Derived_1.A()
Derived_1.A()
Derived_2.A()
