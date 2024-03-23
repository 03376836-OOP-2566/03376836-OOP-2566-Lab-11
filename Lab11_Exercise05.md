# Lab 11 Exercise 5

## Virtual member inheritance
![alt text](./Pictures/image01.png)

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex05
```



![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/9e4782f3-8551-4de8-8d77-fcaf55edb328)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/abf03ac7-0f3c-49ca-a3a9-0505e8e678fc)


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



![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/33b547e8-b479-4032-84e8-17e6be51ba43)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/db8cf8bc-408f-40f9-98bc-fa4ff2bc2dba)


3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/87260f63-c5ca-4aa8-abdb-46443d632c44)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/5c88c408-c3e0-49d0-83f1-cd17dd74931a)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้ เรามีการสร้างอ็อบเจกต์ d2 จากคลาส Derived_2 และเรียกใช้งานเมทอด A() ของ d2 โดยตรง ซึ่งคาดว่าจะแสดงผลลัพธ์ "Derived_2.A()" เนื่องจาก Derived_2 ได้โอเวอร์ไรด์เมทอด A() จาก Derived_1 และ Base ตามลำดับ

หลังจากนั้น เรามีการแปลงอ็อบเจกต์ d2 เป็นอ็อบเจกต์ของคลาส Base และ Derived_1 โดยใช้การ casting โดย Base b = (Base) d2; และ Derived_1 d1 = (Derived_1) d2; ตามลำดับ

หลังจากนั้น เรามีการเรียกใช้งานเมทอด A() บนอ็อบเจกต์ b และ d1 ซึ่งถูกแปลงมาจากอ็อบเจกต์ d2 ที่มีชนิดเป็น Base และ Derived_1 ตามลำดับ และเรียกใช้งานเมทอด A() บน d2 โดยตรง

ผลลัพธ์ที่คาดหวังจากการทดลองนี้คือ
เมื่อเรียกใช้งาน A() บน b (ที่มีชนิดเป็น Base) จะแสดงผลลัพธ์ "Base.A()" เนื่องจากอ็อบเจกต์ b เป็นอ็อบเจกต์ของ Base และไม่มีการโอเวอร์ไรด์เมทอด A() ใน Base ซึ่งไม่ถูกเรียกใช้งาน

เมื่อเรียกใช้งาน A() บน d1 (ที่มีชนิดเป็น Derived_1) จะแสดงผลลัพธ์ "Derived_1.A()" เนื่องจากอ็อบเจกต์ d1 เป็นอ็อบเจกต์ของ Derived_1 ซึ่งมีการโอเวอร์ไรด์เมทอด A() จาก Derived_1

เมื่อเรียกใช้งาน A() บน d2 (ที่มีชนิดเป็น Derived_2) จะแสดงผลลัพธ์ "Derived_2.A()" เนื่องจาก d2 เป็นอ็อบเจกต์ของ Derived_2 และมีการโอเวอร์ไรด์เมทอด A() จาก Derived_2

ดังนั้นผลลัพธ์ที่ได้จะเป็นดังนี้ 

Base.A()

Derived_1.A()

Derived_2.A()

ซึ่งจะแสดงลำดับการเรียกใช้งานของเมทอด A() ตามลำดับ

จะแสดงผลเหมือนภาพด้านบน

