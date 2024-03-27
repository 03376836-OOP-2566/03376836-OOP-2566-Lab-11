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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/0dc30e80-c2d0-4d6d-932c-c18e1a048254)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/a4f5e997-beee-4b47-812f-cedafa0ab65c)

## โค้ดมีข้อผิดพลาดมีการแแก้ไขโค้ดดังนี้ 
- *แก้ไขในส่วน
```
public static class Calculator
{
    public static long AddValues(int a, int b)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int a, int b)");
        return a + b;
    }

    public static long AddValues(float c, float d)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(float c, float d)");
        return (long)(c + d);
    }

    public static long AddValues(long e, long f)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(long e, long f)");
        return e + f;
    }
}
```
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/d4bdaa63-a74e-46df-a028-849209acdc68)

7.อธิบายสิ่งที่พบในการทดลอง
- มีข้อผิดพลาดในการ overloading ของเมทอด AddValues(int c, int d) ซึ่งมี signature เหมือนกับเมทอด AddValues(int a, int b) ดังนั้นคอมไพเลอร์จะไม่ยอมรับเนื่องจากมีเมทอดที่มี signature ซ้ำกัน
