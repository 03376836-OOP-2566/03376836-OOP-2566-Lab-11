# Lab 11 Exercise 3

## Runtime polymorphism

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/68fcacf6-a3de-47d7-bc9d-47d6eb3dcbc7)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/9e0c7df6-a3e2-47af-85ac-e13ed257734b)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/9e3bfdf5-1e4c-4dcc-821b-d7596548a766)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/35ebc500-692d-49ed-8638-bd8392a8ee0b)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/dc16ac23-ab1c-42f1-b744-5f955b9e38c4)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/5284ce2c-fcca-4889-9358-dc210381814c)

7.อธิบายสิ่งที่พบในการทดลอง
