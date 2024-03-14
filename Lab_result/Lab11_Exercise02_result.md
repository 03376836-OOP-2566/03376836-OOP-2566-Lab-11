## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-4.png)

- ไม่สามารถ Build ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-5.png)

- ไม่สามารถ Run ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล

Calculated by method: public static long AddValues(int a, int b)
5
Calculated by method: public static long AddValues(int f, int g)  
5
Calculated by method: public static long AddValues(long h, long i)
5

## หลังแก้ไขโปรแกรม

![pic](/Pictures/pic-6.png)

![pic](/Pictures/pic-7.png)

![pic](/Pictures/pic-8.png)

- ลบ
```cs
    public static long AddValues(int c, int d)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int c, int d)");
        return c + d;
    }
```

- แก้ไข คลาสหรือโครงสร้างที่ซ้ำหรือลบไม่ให้ซ้ำกัน 
