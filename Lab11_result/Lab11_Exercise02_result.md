## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-11/assets/144197367/ee6b0382-b504-435d-a002-2278c6cd6bd4)


- ไม่สามารถ Build ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-11/assets/144197367/e62dc22e-c7d8-4179-9e85-314542f3dfef)

- ไม่สามารถ Run ได้ เพราะ คลาสหรือโครงสร้างที่กำหนดไว้ได้มีการประกาศเมทอดที่มีลำดับพารามิเตอร์ที่เหมือนกันซ้ำในระดับความสำคัญเดียวกันอยู่แล้ว

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล

- Calculated by method: public static long AddValues(int a, int b)

  5
- Calculated by method: public static long AddValues(int f, int g)  

  5
- Calculated by method: public static long AddValues(long h, long i)

  5

## หลังแก้ไขโปรแกรม

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-11/assets/144197367/d444adae-aa2d-4489-b966-cde33f9cea37)
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-11/assets/144197367/d5af9877-43e5-4307-ae82-03794a4de393)

- วิธีเเก้ไขคือการลบ
```cs
    public static long AddValues(int c, int d)
    {
        System.Console.WriteLine("Calculated by method: public static long AddValues(int c, int d)");
        return c + d;
    }
```

- แก้ไข คลาสหรือโครงสร้างที่ซ้ำหรือลบไม่ให้ซ้ำกัน 
