### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
แก้ไขแล้ว
![11-7 run1](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-11/assets/144196048/815a4151-36df-42c7-9a18-ca924f7281f8)

ไม่สามารถ Build ได้ เพราะ Derived_2.A พยายามจะสืบทอดจาก Derived_1 แต่ถูกปิดกั้นด้วยคำสั่ง sealed แก้โดยลบส่วนการทำงานของclass Derived_2 : Derived_1 ออก
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
แก้ไขแล้ว
![11-7 run2](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-11/assets/144196048/52bd2c85-56f9-4872-9b0b-b9c4be73c5d5)

ไม่สามารถ Run ได้ เพราะ Derived_2.A พยายามจะสืบทอดจาก Derived_1 แต่ถูกปิดกั้นด้วยคำสั่ง sealed แก้โดยลบส่วนการทำงานของclass Derived_2 : Derived_1 ออก
### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

Derived_1.A()

Derived_1.A()

Derived_1.A()
