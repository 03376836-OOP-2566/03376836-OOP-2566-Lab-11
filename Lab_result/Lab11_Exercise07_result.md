## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-17.png)

- ไม่สามารถ Build ได้ เพราะ Derived_2.A พยายามจะสืบทอดจาก Derived_1 แต่ถูกปิดกั้นด้วยคำสั่ง sealed

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-18.png)

- ไม่สามารถ Run ได้ เพราะ Derived_2.A พยายามจะสืบทอดจาก Derived_1 แต่ถูกปิดกั้นด้วยคำสั่ง sealed


## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- Derived_2.A()
- Derived_2.A()
- Derived_2.A()


## หลังแก้ไขโปรแกรม 

![pic](/Pictures/pic-19.png)

![pic](/Pictures/pic-20.png)

![pic](/Pictures/pic-21.png)

จาก public sealed override void A() แก้เป็น public override void A() เพื่อให้ Derived_2.A สามารถสืบทอด Derived_1 ได้
