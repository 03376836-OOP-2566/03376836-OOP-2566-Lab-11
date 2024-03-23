# Lab 11 Exercise 1

## Method overloading

1.สร้าง console application project

```cmd
dotnet new console --name Lab11_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/e4bb4dc6-2ca1-4c9a-b2d5-0f94b5819b30)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/7911330d-168a-435c-8516-5414a5a86211)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/abbc4521-cb6e-4f52-aa3f-9fdcaaf1cb0e)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab11_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/f71cf91b-368c-4348-9559-00c0fb37cab4)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab11_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/ae42a7bd-865e-4ed2-9287-159bafbb2c59)

7.อธิบายสิ่งที่พบในการทดลอง

จากกาทดลอง เรามีคลาส Calculator ซึ่งเป็นคลาสที่มีเมทอดต่าง ๆ เพื่อทำการบวกเลขกันในรูปแบบต่าง ๆ ดังนี้ 

public static long AddValues(int a, int b) เป็นเมทอดที่รับพารามิเตอร์เป็นจำนวนเต็ม 2 จำนวน และทำการบวกจำนวนทั้งสองเข้าด้วยกัน

public static long AddValues(int c, int d, int e)  เป็นเมทอดที่รับพารามิเตอร์เป็นจำนวนเต็ม 3 จำนวน และทำการบวกจำนวนทั้งสามเข้าด้วยกัน

public static long AddValues(float f, float g) เป็นเมทอดที่รับพารามิเตอร์เป็นเลขทศนิยม 2 จำนวน และทำการบวกจำนวนทั้งสองเข้าด้วยกัน

public static long AddValues(long h, long i) เป็นเมทอดที่รับพารามิเตอร์เป็นจำนวนเต็ม 2 จำนวน และทำการบวกจำนวนทั้งสองเข้าด้วยกัน

จากการเรียกใช้เมทอด AddValues จะต้องแปลงพารามิเตอร์ที่ใช้ให้ตรงกับลำดับและประเภทของพารามิเตอร์ในเมทอดที่เราต้องการเรียกใช้ และโปรแกรมจะเลือกใช้เมทอดที่ตรงตามลำดับและประเภทของพารามิเตอร์ที่ให้มากับการเรียกใช้ เมื่อเมทอดถูกเรียกใช้ จะแสดงข้อความที่ระบุว่าได้ถูกคำนวณโดยเมทอดที่ใช้ เช่น "Calculated by method: public static long AddValues(int a, int b)" และจะแสดงผลลัพธ์ของการคำนวณออกทางคอนโซลด้วย System.Console.WriteLine() ตามที่แสดงในการทดลองด้านบน 

การแสดงผลดังภาพด้านบน




