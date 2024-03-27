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

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/362790d2-cee6-4528-a5bd-3e44bf2079c7)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-11/assets/144195611/77973b9f-cf9b-4883-b4b3-8e78a5a29ba9)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้งานเมทอดที่มีชื่อเหมือนกันแต่มีลักษณะการทำงานหรือพารามิเตอร์ที่แตกต่างกัน
- เรียกใช้เมทอด AddValues กับพารามิเตอร์ที่ต่างกัน เช่น AddValues(2, 3), AddValues(2, 3, 4), AddValues(2.5f, 3.7f), AddValues(2L, 3L) โปรแกรมจะเรียกใช้เมทอดที่ตรงกับพารามิเตอร์ที่รับเข้ามาให้ และส่งค่าคำตอบกลับออกมาผ่านทาง System.Console.WriteLine() 
