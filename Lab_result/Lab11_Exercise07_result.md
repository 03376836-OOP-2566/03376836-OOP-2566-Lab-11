## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-11/assets/144196505/ddcbd813-f143-41ee-a97b-17ae411ae133)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-11/assets/144196505/63ca180e-b37d-4659-b5b4-fe671a670b16)

## อธิบายสิ่งที่พบในการทดลอง
### คีย์เวิร์ด sealed ใช้ในการป้องกันการสืบทอด (inheritance) ของคลาส 
### Error เนื่องจาก Derived_2 พยายามจะ override เมทอด A() ใน Derived_1 ซึ่งถูกปิดกั้นแล้วด้วยคำสั่ง sealed ซึ่งไม่อนุญาตให้มีการ override 

## หลังแก้ไขโค้ด โดย ลบคำสั่ง sealed ออกจากเมทอด A() ในคลาส Derived_1
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-11/assets/144196505/eaa0fc7e-a422-4c72-ac94-d1ffe98220df)
