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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/dc7664a3-d8de-4cd5-88a7-fb4f669a7da9)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/6198bd4f-066b-494a-980c-df0fe1d76e1e)

## โค้ดผิดพลาดมีการแก้ไข 
```
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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/a733502d-771d-45fd-b18c-a935646607d5)
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/2acbac83-e2c0-49ce-8720-f96a90bfaa73)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ sealed เพื่อป้องกันการสืบทอดจากคลาส Derived_1 โดยไม่อนุญาตให้คลาสไหนสืบทอดมาจาก Derived_1 เพิ่มเติม 
และข้อผิดพลาดคือ ต้องลบคำ sealed ออกจากเมทอด A() ในคลาส Derived_1
