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

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/746a3ee4-24ff-4df0-90f2-d019b033ea92)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/64bee1b1-e826-4c65-b767-5bea35eb957f)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/3787322b-f83d-4291-ad4b-7954242701b2)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-11/assets/144197034/eb9921b9-c554-4a5c-a51e-1bc8f0d92453)


7.อธิบายสิ่งที่พบในการทดลอง

ในโค้ดของคุณมีปัญหาด้านการโอเวอร์โหลด (overloading) เมทอด AddValues ในคลาส Calculator โดยมีเมทอดที่รับพารามิเตอร์เป็น int 2 จำนวนซ้ำกัน ซึ่งไม่ได้รับอนุญาตในภาษา C# โดยตรง เนื่องจากภาษา C# มีการรับฟังก์ชันโอเวอร์โหลดด้วยประเภทของพารามิเตอร์และจำนวนของพารามิเตอร์เท่านั้น แต่ไม่ได้รับอนุญาตในการโอเวอร์โหลดด้วยประเภทของค่าที่คืน (return type) หรือการโอเวอร์โหลดด้วยการแปลงชนิดของพารามิเตอร์ (parameter type conversion) ดังนั้นคุณจะต้องแก้ไขโค้ดเพื่อให้มีการโอเวอร์โหลดถูกต้อง โดยอาจจะลบเมทอดบางตัวที่ไม่ใช่เมทอดหลักที่ต้องการใช้งาน หรือเปลี่ยนชื่อเมทอดหรือประเภทของพารามิเตอร์เพื่อไม่ให้มีการโอเวอร์โหลดที่ไม่ถูกต้องนั้นเกิดขึ้น 

เมือแก้ไขโค้ดจะได้ การเรียก ใช้งานเมทอด AddValues ในคลาส Calculator และแสดงผลลัพธ์ออกทางคอนโซลด้วย System.Console.WriteLine() โดยใส่พารามิเตอร์ต่าง ๆ ตามลำดับและประเภทของพารามิเตอร์ที่เราต้องการ เมทอดที่ถูกเรียกใช้จะถูกเลือกตามลำดับและประเภทของพารามิเตอร์ที่ให้มา และจะแสดงข้อความตามที่กำหนดในเมทอดนั้น ๆ และคืนค่าตามประเภทของข้อมูลที่กำหนดไว้ในฟังก์ชันนั้น ๆ
เมื่อเราส่งพารามิเตอร์เป็น int เข้าไปในเมทอดที่รับ int 2 พารามิเตอร์ จะเรียกใช้เมทอดที่รับ int 2 พารามิเตอร์
