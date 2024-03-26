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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-11/assets/144195555/e60d8629-3c3a-4fbd-9248-a6421fb3e54c)
### สามารถ build ได้ เพราะ การสร้างคลาส Animal และคลาสลูกของมันอย่าง Dog, Fish, และ Bird ซึ่งแต่ละคลาสลูกมีเมทอด Move ที่ได้รับการโอเวอร์ไรด์ (override) จากคลาส Animal โดยแต่ละเมทอด Move ของคลาสลูกจะแสดงข้อความที่บอกถึงวิธีการเคลื่อนที่ของสัตว์แต่ละชนิด และเรียกใช้เมทอด Move ของคลาสแม่ด้วยคำสั่ง base.Move()
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-11/assets/144195555/3601a527-9e9c-4765-a9c0-7ce596ba12a8)
### สามารถ Run ได้ เพราะ ใช้เมทอดของคลาสเดียวกันในลักษณะที่แตกต่างกันขึ้นอยู่กับประเภทของวัตถุที่เรียกใช้เมทอดนั้น ๆ ซึ่งเป็นเหตุผลในการทำให้เราสามารถเรียกใช้เมทอด Move() ของคลาส Animal
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### Dog: Running on the ground.
### Move successfully.
### Fish: Swimming in the water.
### Move successfully.
### Bird: Flying in the air.
### Move successfully.
