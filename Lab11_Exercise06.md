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

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/1688d035-6e22-4a8d-a512-e0fe77d98ebd)


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/7f21ec86-b949-45af-8e9a-e2a991bf069a)


7.อธิบายสิ่งที่พบในการทดลอง

จากในการทดลองนี้เราได้ทดสอบการใช้งานการแปลงชนิด (casting) และการโอเวอร์ไรด์เมทอด (method overriding) ในการสืบทอดคลาสของภาษา C#

เราสร้างอ็อบเจกต์ d2 จากคลาส Derived_2 และทำการแปลงให้เป็นอ็อบเจกต์ของคลาส Base และ Derived_1 โดยใช้การ casting

เมื่อเรียกใช้งานเมทอด A() บนอ็อบเจกต์ b และ d1 ซึ่งเป็นอ็อบเจกต์ของคลาส Base และ Derived_1 ตามลำดับ จะเรียกใช้งานเมทอด A() ที่ถูกโอเวอร์ไรด์ในคลาสลูก

เมื่อเรียกใช้งานเมทอด A() บนอ็อบเจกต์ d2 ซึ่งเป็นอ็อบเจกต์ของคลาส Derived_2 จะเรียกใช้งาน A() ที่ถูกโอเวอร์ไรด์ในคลาส Derived_2

ผลลัพธ์ที่คาดหวังคือการแสดงผลลัพธ์ "Base.A()", "Derived_1.A()", และ "Derived_2.A()" ตามลำดับ เนื่องจากการโอเวอร์ไรด์เมทอดและลำดับการแปลงชนิดทำให้เมทอดที่ถูกเรียกใช้งานเป็นเมทอดของคลาสที่เหมาะสมในแต่ละกรณี ตามลำดับที่เราได้กำหนดไว้ในโค้ดการทดลองนี้

ดังแสดงผลในภาพด้านบน
