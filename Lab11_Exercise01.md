# Lab 11 Exercise 1

## Method overloading

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
System.Console.WriteLine(Calculator.AddValues(2, 3));
System.Console.WriteLine(Calculator.AddValues(2, 3, 4));
System.Console.WriteLine(Calculator.AddValues(2.5f, 3.7f));
System.Console.WriteLine(Calculator.AddValues(2L, 3L));

public static class Calculator
{
    public static long AddValues(int a, int b)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int a, int b)");
        return a + b;
    }
    public static long AddValues(int c, int d, int e)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int c, int d, int e)");
        return c + d + e;
    }
    public static long AddValues(float f, float g)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(float f, float g)");
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
dotnet build  Lab11_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="653" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/4dbae804-5ea8-48e6-9d9b-ed9a77e0e0dc">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="665" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/6fce51ca-f647-46ca-879f-37b2bd34fa2f">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
Calculated by method: public static long AddValues(int a, int b)
5
Calculated by method: public static long AddValues(int c, int d, int e)
9
Calculated by method: public static long AddValues(float f, float g)
6
Calculated by method: public static long AddValues(long h, long i)
5
