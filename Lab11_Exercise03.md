# Lab 11 Exercise 3

## Runtime polymorphism

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex03
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
   public virtual void Move()
   {
    System.Console.WriteLine("Move successfully.");
   } 
}

class Dog:Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Running on the ground.");
        base.Move();
    }
}
class Fish: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Swimming in the water.");
        base.Move();
    }
}

class Bird: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: Flying in the air.");
        base.Move();
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/342512a2-a7e3-4d2a-8eb2-992f81b8b9ca)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/ac4a5cf1-674f-482c-a73d-b5db7779e775)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ runtime polymorphism ช่วยให้สามารเรียกใช้เมทอดที่ถูก override ในคลาสลูก
- สร้างคลาส Animal ซึ่งมีเมทอด Move() เป็นเมทอดที่มีการประกาศเป็น virtual สามารถ override ได้ในคลาสลูกทั้งหมด
- สร้างคลาสลูกอื่น ๆ เช่น Dog, Fish, และ Bird โดยทุกคลาสลูก override เมทอด Move() เพื่อให้เหมาะกับพฤติกรรมของแต่ละสัตว์
- สร้างอ็อบเจกต์ animalA, animalB, และ animalC ขึ้นมาแล้ว แต่ละอ็อบเจกต์ถูกสร้างด้วยคลาสลูกของ Animal คือ Dog, Fish, และ Bird ตามลำดับ
เมื่อเรียกใช้เมทอด Move() บนแต่ละอ็อบเจกต์ โปรแกรมจะเรียกใช้เมทอด Move() ของคลาสลูกที่มีการ override โดยเมทอดที่ถูกเรียกใช้จะขึ้นอยู่กับประเภทของอ็อบเจกต์ที่ถูกสร้างขึ้นมา
