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
เนื่องจาก คลาส Calculator มีเมทอดชื่อ AddValues ที่ถูกกำหนดซ้ำกันในโค้ด  
# แก้ไข
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/8beb9d42-27a6-499d-bc3d-1d4078716626)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/711f3796-7813-49f1-bf46-44bf1fc431fd)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-11/assets/144195708/8d2f55e3-d87a-4a20-970e-bdf1e4cb27fb)

7.อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

- Calculated by method: public static long AddValues(int a, int b)

  5
- Calculated by method: public static long AddValues(int f, int g)  

  5
- Calculated by method: public static long AddValues(long h, long i)

  5
