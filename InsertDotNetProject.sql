﻿INSERT INTO SUBJECTT VALUES ('101',N'toán')
INSERT INTO SUBJECTT VALUES ('102',N'văn')
INSERT INTO SUBJECTT VALUES ('103',N'ngoại ngữ')
INSERT INTO SUBJECTT VALUES ('104',N'vật lí')
INSERT INTO SUBJECTT VALUES ('105',N'hóa học')
INSERT INTO SUBJECTT VALUES ('106',N'lịch sử')
INSERT INTO SUBJECTT VALUES ('107',N'địa lí')
INSERT INTO TEACHER VALUES ('1001','002204012',N'Nguyễn Thị Ánh','1999-04-02',N'AN Giang','0866123294',8000000,'102')
INSERT INTO TEACHER VALUES ('1002','002201020',N'Lê Văn Chương','1996-02-02',N'Hà Nội','0495837542',9000000,'101')
INSERT INTO TEACHER VALUES ('1003','001102010',N'Nguyễn Văn Huyên','1995-11-11',N'Vĩnh Phúc','0293821282',7500000,'101')
INSERT INTO COURSE VALUES ('121',N'12C1','1001')
INSERT INTO COURSE VALUES ('122',N'11B2','1002')

INSERT INTO STUDENT VALUES ('0001','002012010',N'Trần La Thăng','2007-06-04',N'Hà Giang','0987685949','2024-2025','121')
INSERT INTO STUDENT VALUES ('0002','020213932',N'Nguyễn Thị Định','2006-07-07',N'Bắc Ninh','0293929303','2024-2025','121')
INSERT INTO STUDENT VALUES ('0003','039293929',N'Lê Văn Lợi','2008-08-09',N'Bắc Ninh','0958697869','2022-2023','122')
SELECT * FROM STUDENT WHERE FULLNAME LIKE N'%định%'
SELECT * FROM STUDENT
SELECT * FROM COURSE
Select * from SUBJECTT
INSERT INTO GRADELIST VALUES ('0001','6.2','6','6','6','6','6','6','6')
INSERT INTO GRADELIST VALUES ('0002','8','8','8','8','8','8','8','8')
INSERT INTO GRADELIST VALUES ('0003','9','9','9','9','9','9','9','9')

Select * from GRADELIST

