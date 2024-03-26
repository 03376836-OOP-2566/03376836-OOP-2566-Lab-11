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

<img width="606" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/2eaa4272-3dbe-4657-be4c-1d3e332be7a6">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="605" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-11/assets/144195963/18196b1e-3243-4f37-a40f-f0f2296b8d31">

7.อธิบายสิ่งที่พบในการทดลอง

Calculated by method: public static long AddValues(int a, int b)
5
Calculated by method: public static long AddValues(int c, int d)
5
Calculated by method: public static long AddValues(long f, long g)
5
