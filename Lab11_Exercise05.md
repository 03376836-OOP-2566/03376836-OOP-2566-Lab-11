# Lab 11 Exercise 5

## Virtual member inheritance
![alt text](./Pictures/image01.png)

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex05
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
    public override void A()
    {
        System.Console.WriteLine("Derived_2.A()");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/57c7d8d6-0110-442e-af7c-a83d82b6d1ce)

สามารถ Build ได้ เพราะคลาส Base เป็นคลาสหลัก และมีคลาส Derived_1 และ Derived_2 ที่สืบทอดมาจาก Base โดยมีการโอเวอร์ไรด์ (override) เมทอด A() ของ Base ใน Derived_1 และ Derived_2

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/3419ca79-7536-4bf4-83a2-c034b2202708)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ คลาสที่สืบทอด และการอิงอ็อบเจกต์ด้วยประเภทของ Base Class ทำให้เราสามารถใช้งานหลายรูปแบบของอ็อบเจกต์ได้อย่างยืดหยุ่น

โปรแกรมจะแสดงผล

Derived_2.A()

Derived_2.A()

Derived_2.A()
