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
# เเก้ไข
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/fd7fbc19-581c-4a5f-b5c4-5a7ec9113f14)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/0009e9b4-b337-4358-a790-ea467ca353f7)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/159dd355-3712-43dc-9cbb-cbeae90e5190)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/bc1d6966-7f6e-4ea4-9415-29fb56d5e3cd)

7.อธิบายสิ่งที่พบในการทดลอง

แสดงผล

Derived_2.A()

Derived_2.A()

Derived_2.A()
