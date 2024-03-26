# Lab 11 Exercise 7

## Prevent inheritance by keyword `sealed`

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex07
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
    public sealed override void A()
    {
        System.Console.WriteLine("Derived_1.A()");
    }
}
class Derived_2 : Derived_1
{
    public override void A()
    {
        System.Console.WriteLine("Derived_2.A()");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

แก้ไขไม่ได้
<img width="691" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/2d5651cc-47a7-4cc2-85fe-e51f80d94957">


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="690" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/6778622e-2f89-4d6d-90b6-02485e1ccb07">

7.อธิบายสิ่งที่พบในการทดลอง

หากโปรแกรมทำงานได้จะแสดงผล
Derived_1.A()
Derived_1.A()
Derived_1.A()
