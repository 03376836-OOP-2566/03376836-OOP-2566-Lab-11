# Lab 11 Exercise 7

## Prevent inheritance by keyword `sealed`

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/beb61e21-a03f-480e-9c6b-74f2e3ba1931)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/e9339c16-7e4a-4d00-a97e-11bb00815b5a)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/b603e3c6-9b11-44e3-aefe-6376082d4a83)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/516c7e3c-b1e8-4810-b2a4-1d4d8d79da14)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/a4575d78-82f0-4f24-adde-c3c4c01574a6)

7.อธิบายสิ่งที่พบในการทดลอง
