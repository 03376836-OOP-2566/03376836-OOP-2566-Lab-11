# Lab 11 Exercise 2

## Method overloading (Compile time polymorphism)

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
System.Console.WriteLine(Calculator.AddValues(2, 3));
System.Console.WriteLine(Calculator.AddValues(2.0f, 3.0f));
System.Console.WriteLine(Calculator.AddValues(2L, 3L));

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int a, int b)");
        return a + b;
    }
    public static long AddValues(int c, int d)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int c, int d)");
        return c + d;
    }
    public static float AddValues(int f, int g)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int f, int g)");
        return (long) (f + g);
    }
   public static long AddValues(long h, long i)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return (long) (h + i);
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![2](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/bd2a201a-59a3-440a-85b5-fdd1741524bc)

ไม่สามารถ Build ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว แก้ไขจากลบคลาสหรือโครงสร้างที่ซ้ำ

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![2 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-11/assets/144195995/f8b3c247-6cba-4ab0-89ad-e9a3823528d4)

7.อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว แก้ไขจากลบคลาสหรือโครงสร้างที่ซ้ำ

โปรแกรมจะแสดงผล
Calculated by method: public static long AddValues(int a, int b)
5
Calculated by method: public static long AddValues(int f, int g)
5
Calculated by method: public static long AddValues(long h, long i)
5
