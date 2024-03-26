### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-11/assets/144195555/1de82127-7e3b-40fe-93c0-05bde90176dc)
สามารถ build ได้ เพราะ การสร้างคลาส Animal และคลาสลูกของมันอย่าง Dog, Fish, และ Bird ซึ่งแต่ละคลาสลูกมีเมทอด Move ที่ได้รับการโอเวอร์ไรด์ (override) จากคลาส Animal โดยแต่ละเมทอด Move ของคลาสลูกจะแสดงข้อความที่บอกถึงวิธีการเคลื่อนที่ของสัตว์แต่ละชนิด และเรียกใช้เมทอด Move ของคลาสแม่ด้วยคำสั่ง base.Move()
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-11/assets/144195555/cbe6f96d-08d3-481e-8aed-b087567c7349)
สามารถ Run ได้ เพราะ ใช้เมทอดของคลาสเดียวกันในลักษณะที่แตกต่างกันขึ้นอยู่กับประเภทของวัตถุที่เรียกใช้เมทอดนั้น ๆ ซึ่งเป็นเหตุผลในการทำให้เราสามารถเรียกใช้เมทอด Move() ของคลาส Animal
### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

Dog: Running on the ground.

Move successfully.

Fish: Swimming in the water.

Move successfully.

Bird: Flying in the air.

Move successfully.





