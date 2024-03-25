### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![11-3 run1](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-11/assets/144196048/d01a7393-59ad-4b80-8e1a-4aa47b7df63a)

สามารถ build ได้ เพราะ การสร้างคลาส Animal และคลาสลูกของมันอย่าง Dog, Fish, และ Bird ซึ่งแต่ละคลาสลูกมีเมทอด Move ที่ได้รับการโอเวอร์ไรด์ (override) จากคลาส Animal โดยแต่ละเมทอด Move ของคลาสลูกจะแสดงข้อความที่บอกถึงวิธีการเคลื่อนที่ของสัตว์แต่ละชนิด และเรียกใช้เมทอด Move ของคลาสแม่ด้วยคำสั่ง base.Move()
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![11-3 run2](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-11/assets/144196048/a41fad1b-4ede-4427-bbf8-2cb69a764362)

สามารถ Run ได้ เพราะ ใช้เมทอดของคลาสเดียวกันในลักษณะที่แตกต่างกันขึ้นอยู่กับประเภทของวัตถุที่เรียกใช้เมทอดนั้น ๆ ซึ่งเป็นเหตุผลในการทำให้เราสามารถเรียกใช้เมทอด Move() ของคลาส Animal
### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

Dog: Running on the ground.

Move successfully.

Fish: Swimming in the water.

Move successfully.

Bird: Flying in the air.

Move successfully.
