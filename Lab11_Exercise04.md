# Lab 11 Exercise 4

## Virtual member inheritance
![alt text](./Pictures/image01.png)

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex04
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var b = new Base();
var d1 = new Derived_1();
var d2 = new Derived_2();

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
dotnet build  Lab11_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/190e0f26-2bfd-4cd9-aa72-f7d4f31a5d11)

สามารถ Build ได้ เพราะ เมทอด virtual ถูกโอเวอร์ไรด์ในคลาสลูกทำให้เราสามารถเรียกใช้เมทอดของคลาสลูกได้โดยใช้ตัวแปรของคลาสแม่

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/61baaf5e-385a-4895-8f72-4ca1be389703)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ virtual ซึ่งหมายความว่าคลาสลูกสามารถโอเวอร์ไรด์เมทอด A() ได้ และในที่นี้ Derived_1 และ Derived_2 ได้โอเวอร์ไรด์เมทอด A() นี้ตามลำดับ

โปรแกรมจะแสดงผล
Base.A()

Derived_1.A()

Derived_2.A()
