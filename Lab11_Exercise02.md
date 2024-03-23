# Lab 11 Exercise 2

## Method overloading (Compile time polymorphism)

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/fb17fdba-c429-42fa-97b5-eb308e362411)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/783982c7-5b02-4ab3-bf51-31acdc263933)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/b736e338-499c-400f-abac-022378491373)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/50266215-982c-429a-b7f4-ccabfdc26dd1)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/e0bae0be-77f4-4d57-af02-e29e898b6084)

7.อธิบายสิ่งที่พบในการทดลอง
