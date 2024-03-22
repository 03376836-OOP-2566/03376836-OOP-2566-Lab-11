# Lab 11 Exercise 6

## Masking virtual member inheritance by keyword `new`

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex06
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/e2bd86e4-da02-4a98-9e00-1a6e60c24fd4)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/b14ef031-97c4-4836-879b-3261c9e4137f)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/e3af9d0f-ee6d-4524-9b4e-5d22961003af)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/9cfac614-bd9d-4f51-ab73-4f496c4adbc2)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/045fd4fe-7052-4e41-8828-3b381441c7d8)

7.อธิบายสิ่งที่พบในการทดลอง
