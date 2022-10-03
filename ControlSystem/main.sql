--�������� �������
/*
CREATE TABLE  AUTO 
(       REGNUM VARCHAR2(10) PRIMARY KEY, 
	MARK VARCHAR2(10), 
	COLOR VARCHAR2(15),
	RELEASEDT DATE, 
	PHONENUM VARCHAR2(15)
) 
/

CREATE TABLE  CITY 
   (	CITYCODE NUMBER PRIMARY KEY,
	CITYNAME VARCHAR2(50), 
	PEOPLES NUMBER 
   )
/

CREATE TABLE  MAN 
   (	PHONENUM VARCHAR2(15) PRIMARY KEY , 
	FIRSTNAME VARCHAR2(50),
	LASTNAME VARCHAR2(50),  
	CITYCODE NUMBER, 
	YEAROLD NUMBER	 
   )
/

 -- AUTO
INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111114,'LADA', '�������', date'2008-01-01', '9152222221')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111115,'VOLVO', '�������', date'2013-01-01', '9152222222')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111116,'BMW', '�����', date'2015-01-01', '9153333333')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111121,'AUDI', '�����', date'2009-01-01', '9173333334')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111122,'AUDI', '�����', date'2011-01-01', '9173333335')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111113,'BMW', '�������', date'2007-01-01', '9213333336')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111126,'LADA', '�������', date'2005-01-01', '9213333331')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111117,'BMW', '�����', date'2005-01-01', '9213333332')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111119,'LADA', '�����', date'2017-01-01', '9214444444')
/

 -- CITY
INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(1,'������', 10000000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(2,'��������', 500000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(3, '����', 300000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(4,'�����', 200000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(5, '������', 2000000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(7, '������', 110000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(8, '��������', 400000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(9, '���������', 500000)
/
-- MAN
INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9152222221','������','��������', 1, 22)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9152222222','������','��������', 1, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9153333333','����','�������', 3, 34)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9173333334','�����','������', 4, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9173333335','����','�������', 4, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333336','�������','������', 7, 25)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333331','������','��������', 2, 27)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333332','����','�������', 2, 21)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9214444444','�������','������', 1, 38)
/
*/



--��� 6
--������� 4, �������� ������� ��������
Create Table spare_parts 
(
    id_part NUMBER Primary Key
    ,auto_mark VARCHAR2 (50)
    ,name_part VARCHAR2 (50)
    ,count_part NUMBER
    ,cost_part NUMBER
);

--������� 4, �������� ������� ����
Create Table photo 
(
    name_photo VARCHAR2 (50)
    ,photo_size VARCHAR2 (9)
    ,autograph VARCHAR2 (50)
    ,create_date DATE
);

--������� 4, �������� ������� �������
Create Table lessons 
(
    name_lesson VARCHAR2 (50)
    ,lesson_date DATE
    ,lesson_start VARCHAR2 (50)
    ,lesson_end VARCHAR2 (50)
);
    
--��� 7
--������� 3, � ������� �������� �������� �������
Alter Table spare_parts ADD (part_weight NUMBER);

--������� 4, ������� �� ������� ����
Alter Table photo DROP COLUMN photo_size;

--������� 5, �������� ������� � ������� �������
Alter Table lessons ADD (name_teacher VARCHAR2 (50));

--������� 6, ������� ������� ����
Drop Table photo; --� �������� ������� �� �������, ������� ������ ������

--��� 8 
--������

--��� 9
--������� 1, �������� � ������� AUTO ������������ ��� ������� PHONENUM
Alter Table AUTO Modify PHONENUM UNIQUE;

--������� 2, �������� � ������� MAN ������ �� ���� ������ ����� � Y.O.
Alter Table MAN Modify YEAROLD NOT NULL;

--������� 3, �������� �������� �������� ��� MAN ������ 100 ��� (not dead)
Alter Table MAN ADD Constraint man_year_old Check (YEAROLD < 100);

--������� 4, ��������� ����������� ��� ������ AUTO � MAN
Alter Table AUTO ADD Constraint fk_auto_phone
    Foreign Key (PHONENUM)
    References MAN (PHONENUM);
  
    
--��� 10
--������� 3, ������� ������
Create index id_color on AUTO (COLOR);

--������� 4, ������� ������ ������
Create index year_rid on MAN (YEAROLD) reverse;


--��� 11
--������� 2, ������� �� ������� MAN (*) �����, ��� ������� (YEAROLD) �������� ������ 30 ���
SELECT * FROM MAN WHERE YEAROLD > 30;

--������� 3,������� �� ������� ������� ��� ������� (*), ��� ����� (CITYNAME) ���������� ������.
SELECT * FROM CITY WHERE CITYNAME = '������';

--������� 4, ������� �������� (CITYNAME) ������� CITY � ���������� (PEOPLES) ������ �������� �������.
SELECT CITYNAME FROM CITY WHERE PEOPLES > 1000000;

--������� 5, ������� �������� ����� �� MAN, ��� ������� (LASTNAME)�� �������.
SELECT PHONENUM FROM MAN WHERE LASTNAME != '�������';

--������� 6, ������� ���������� � ������� car (*) ������ ����� (COLOR).
SELECT * FROM AUTO WHERE COLOR = '�����';


--��� 12
--������� 2, �������� �� ������� CITY (*) �����, ��� 200 ����� ������� (PEOPLES); ����� � ������������� ������ (CITYNAME
SELECT * FROM CITY WHERE (CITYNAME = '������') or (PEOPLES = 200000);

--������� 3, �������� �� ������� CITY ������ � ���������� (PEOPLES) �� 500 ����� �������.
SELECT CITYNAME FROM CITY WHERE PEOPLES != 500000;

--������� 4, �������� �� ������� AUTO (*) ��� ����� AUDI (COLOR, MARK).
SELECT * FROM AUTO WHERE (MARK = 'AUDI' and COLOR = '�����');

--������� 5, �������� �� ������� AUTO ������ (regnum) � ����� (MARK) ���� VOLVO � BMW.
SELECT REGNUM, MARK FROM AUTO WHERE (MARK = 'VOLVO' or MARK = 'BMW');

--������� 6, �������� �� ������� MAN �����, ������� (FIRSTNAME, LASTNAME) � ������� ����� (YEAROLD), ������� ������ 29 � ������ 35 ���.
SELECT FIRSTNAME, LASTNAME, YEAROLD FROM MAN WHERE (YEAROLD > 29 and YEAROLD < 35);


--��� 13
--������� 1, ����� �������
SELECT * FROM CITY WHERE CITYNAME LIKE '%�%' ORDER BY CITYNAME, PEOPLES DESC;
--������� 2, ������� �������� ������� 1
SELECT * FROM AUTO ORDER BY COLOR, MARK DESC;


--��� 14
--������� 2, �������� �� ����� ������ 3 ������� �� ������� CITY.
SELECT * FROM CITY WHERE ROWNUM < 4;
--������� 3, �������� �� ����� ������ 4 ������� �� ������� CITY, ��������������� �� ���������� ��������� (PEOPLES).
SELECT * FROM CITY WHERE ROWNUM < 5 ORDER BY PEOPLES;
--������� 4, �������� �� ����� ������ �� ������� MAN.
SELECT * FROM MAN;


--��� 15
--������� 1, � �� - ������� �� �������
INSERT INTO MAN (PHONENUM, FIRSTNAME, LASTNAME, CITYCODE, YEAROLD)
VALUES ('12012012','������','��������',2,25);
Commit;

INSERT INTO AUTO (REGNUM, MARK, COLOR, RELEASEDT, PHONENUM)
VALUES ('12887', 'LADA', '�������', date'2001-01-01', '');
Commit;

CREATE TABLE city1
(
    citycode NUMBER PRIMARY KEY,
	cityname VARCHAR2(50), 
	peoples NUMBER
);
INSERT INTO city1 (citycode, cityname, peoples)
SELECT CITYCODE, CITYNAME, PEOPLES FROM CITY WHERE PEOPLES > 1000000;
Commit;


CREATE TABLE man1
(
    phonenum VARCHAR2(15) PRIMARY KEY , 
	fn VARCHAR2(50),
	ln VARCHAR2(50),  
	citycode NUMBER, 
	yo NUMBER
);
INSERT INTO man1 (phonenum, fn, ln, citycode, yo)
SELECT PHONENUM, FIRSTNAME, LASTNAME, CITYCODE, YEAROLD FROM MAN;
Commit;

--������� 2, �������� � ������� ������� ����� �����; ��� ������ � �������� ���������� ����.
INSERT INTO CITY (CITYCODE, CITYNAME, PEOPLES)
VALUES (159, '���������', 150000);
Commit;

--������� 3, � ������� CITY1 �������� ��� ������ �� CITY, ��� ��������� ������ ������������ �������
INSERT INTO city1 (citycode, cityname, peoples)
SELECT CITYCODE, CITYNAME, PEOPLES FROM CITY WHERE PEOPLES < 500000;
Commit;

--������� 4,������� AUTO �������� ����� ������ 999999 ����, ���� �������, 1999 ���� �������.
INSERT INTO AUTO (REGNUM, MARK, COLOR, RELEASEDT, PHONENUM)
VALUES ('999999', 'LADA', '��˨���', date'1999-01-01', null);
Commit;


--��� 16
--������� 2, �������� 1 � �������� �������
UPDATE MAN SET YEAROLD = YEAROLD+1 WHERE FIRSTNAME = '������';

--������� 3, �������� 2 � �������� ����� (MAN), ��� ������� ������ 19 ���.
UPDATE MAN SET YEAROLD = YEAROLD + 2 WHERE YEAROLD > 19;

--������� 4, ����� ����� (MAN), ��� ������� �������� 915, �������� ������� 915.
UPDATE MAN SET FIRSTNAME = FIRSTNAME + '915' WHERE PHONENUM LIKE '%915%';

--������� 5,� ���� � ����� (MAN) � ���������, ��� ������� ������ 22 ���, �������� ��� �� �����.
UPDATE MAN SET FIRSTNAME = '�����' WHERE (YEAROLD > 22 and PHONENUM IS NOT NULL);


--��� 17
--������� 2, �������� ������� ��� �������� �� ������� AUTO ����� �������, ��� ���� ������� ���� ������ 2018 ����.
DELETE AUTO WHERE RELEASEDT > date'2018-01-01';

--��� 18
--Task 3, �������� � ������� ������� SQL ������������ ������ �� ������� CITY. ��� ���-���� ������� ��������� GR, ��� ������� �������������� ������� ��������� NM.
SELECT cityname as nm FROM city gr;

--Task 4, �������� ���������� ������� � ������ ������, ��� ������� PEOPLES ������� ��������� CLZ, ��� ������� ������ ��������� MS.
SELECT peoples as clz FROM city ms WHERE ms.cityname = '������';


--Step 19
--Task 2, �������� ������ � ���������� �� 40 000 �� 2 000 000 �������, �������� SQL-������.
SELECT cityname FROM city c WHERE c.peoples BETWEEN 40000 and 2000000;

--Task 3, �������� ������ � ���������� �� � ��������� 40 000 �� 2 000 000 �������, �������� SQL-������.
SELECT cityname FROM city c WHERE c.peoples NOT BETWEEN 40000 and 2000000;

--Task 4,�������� ����� * � ��������� �� � ��������� 25 �� 28 ���, ����������� NOT,
SELECT * FROM man m WHERE m.yearold NOT BETWEEN 25 and 28;

--Task 5, �������� ������ � ����� ������� �� 2007 �� 2011, �������� SQL-������
SELECT * FROM auto a WHERE a.releasedt BETWEEN date'2007-01-01' and date'2011-12-31';


--Step 20
--Task 2, �������� �� ������� AUTO ����� �����������, ��������� ����������, ��������
SELECT DISTINCT color FROM auto;

--Task 3, �������� �� ������� MAN ����� �����, ��������� ����������
SELECT DISTINCT firstname FROM man;


--Step 21
--Task 1, ������� �� ������� MAN ���, ������� � ���������� ������ 10.
SELECT firstname, lastname, sqrt(10) as sqr10 FROM man;

--Task 2, ������� �� ������� MAN ���, ������� � ������� ��������, ���������� �� cos (5).
SELECT firstname, lastname, yearold*cos(5) as yo_cos5 FROM man;

--Task 3, ������� �� ������� CITY ������ (*), ��� ��������� ������� ��� ������� �� 10 000.
SELECT * FROM city c WHERE mod(c.peoples, 10000) = 0;

--Task 4, ������� �� ������� CITY �������� ������, ���������� ������ �� ���������, ���������� �� 10, ��� �������� ���� ������ ������� ������ �� 3.
SELECT cityname, sqrt(peoples) * 10 as Whoa FROM city c WHERE mod(c.citycode, 3) = 0;


--Step 22
--Task 1, ��������� �������� ������� �������� �� �������� 5 � ������� SELECT � DUAL.
SELECT 5*5 as space FROM dual;

--Task 2, ��������� �������� ������� ����� � �������� 7 ������� SELECT � DUAL
SELECT 7*7*3.14 as space FROM dual;

--Task 3, ��������� �������� ��������� 100*sIN (1) *cos (3) � ������� SELECT � DUAL
SELECT 100*sin(1) * cos(3) FROM dual;


--Step 23
--Task 3, �������� �������� �� ������� AUTO. ������ ������ ��������� ��������: NO PHONE, ���.
SELECT NVL(phonenum, 'NO PHONE') FROM auto;


--Step 24
--Task 1, �������� �� ������� MAN ���� ����� *, ��� ������� �� ���������� �� ����� ���,
SELECT * FROM man m WHERE m.lastname NOT LIKE '��%';

--Task 2, �������� �� ������� MAN ���� ����� *, � ���� ������ ���� ������� ����� ��.
SELECT * FROM man m WHERE m.firstname LIKE '%�%';

--Task 3, �������� �� ������� CITY ������, ��� ������ ����� � ������������ ��.
SELECT cityname FROM city c WHERE c.cityname LIKE '__�%';


--Step 25
--Task 1, ������� ���, �����, ���� ������������ ���� �� ������� AUTO.
SELECT to_char(releasedt, 'YYYY.MM.DD') as release_date from auto;

--Task 2,  ������� ���� 30 ���� �����.
SELECT sysdate-30 as thirty_day_before from dual;

--Task 3, ������� ��������� ���� ������ 80 ���� �����.
select last_day(sysdate-80) as cho from dual;

--Task 4, ������������� ��������� ������ � ���� 01.11.2011 21:11.
select to_char(sysdate, 'DD.MM.YYYY hh24:mi') from dual;

--Task 5, ������������� ���� 5 ���� ����� � ������ DD.MM.YYYY hh24:mi.
select to_char(sysdate - 5, 'DD.MM.YYYY hh24:mi') from dual;

--Task 6,������� �� ����� ���� � ����� 4 ���� ����� �� �������� �������.
select to_char(sysdate-1/24*4, 'DD.MM.YYYY hh24:mi') as whoa from dual;


--Step 26
--Task 1, ����� ������ �� ������� �AN, ������������ �� ��, ������������ SUBSTR.
select * from man m where substr(m.firstname, 1, 2) = '��' or substr(m.lastname, 1, 2) = '��';

--Task 2, ����� ������ �� ������� MAN, ��� ���������� �������� � ������� �������� ������ 10.
select * from man m where length(m.lastname) > 10;

--Task 3, ������� �� ������� MAN ���, �������, ���������� �������� � �������, ��� ����-������ �������� � ������� �������� ������ 5.
select firstname, lastname, length(lastname) from man m where length(m.lastname) > 5;

--Task 4, �������� ����� �� � ����� ������� �� @, ������� ���������, ������������ REPLACE � DUAL.
select replace('������', '�' ,'@') from dual;

--Task 5, ���������� ���������� ���� �� � ����� �������, ������� ���������, ������������ REPLACE, DUAL � ����������.
select length('������') - length(replace('������', '�')) as bb from dual;

--Task 6, ����� ������ ��������� ����� �� � ������ � ����� 1 �� ������� CITY.
select instr(cityname, '�', 1), cityname from city where citycode = 1;

--Task 7, ����� ������ � ��������� ��������� ����� �� � ������ � ����� 2 �� ������� CITY.
select instr(cityname, '�', 1), instr(cityname, '�', -1),  cityname from city where citycode = 2;


--Step 27
--Task 1, ������� �� ������� MAN ���, ������� � ���������� ������ �� 133.
select firstname, lastname, sqrt(133) as whoa from man;

--Task 2, ������� �� ������� MAN ���, ������� � ������� ��������, ���������� �� cos (5).
SELECT firstname, lastname, yearold*cos(5) as yo_cos5 FROM man;

--Task 3, ������� �� ������� CITY ������ (*), ��� ��������� ������� ��� ������� �� 10 000.
select * from city c where mod(c.peoples, 10000) = 0;

--Task 4, ������� �� ������� CITY �������� ������, ���������� ������ �� ���������, ����-������ �� 10, ��� �������� ���� ������ ������� ������ �� 5.
SELECT cityname, sqrt(peoples) * 10 as Whoa FROM city c WHERE mod(c.citycode, 5) = 0;


--Step 28
--Task 1, ������� �� ������� AUTO, ��� REGNUM � 111114, 111115, 111116.
select * from auto a where a.regnum in (111114, 111115, 111116);

--Task 2, ������� �� ������� MAN * ����� � ������� (FIRSTNAME) ������, ������, �����.
select * from man m where m.firstname in ('������', '������', '�����');

--Task 3, ������� �� ������� CITY * ������ (CITYNAME) ������, ��������, ������
select * from city c where c.cityname in ('������', '��������', '������');

--Task 4, ������� �� ������� CITY * ������ � ������ (CITYCODE) 1, 3, 5, 7.
select * from city c where c.citycode in (1, 3, 5, 7);


--Step 29
--Task 2, ������� ��� �������� �� ������� MAN, �� ������� AUTO, ���������� ��� ��� ���-���� ����������� ���� ������ �������� (PHONENUM).
select * from man m, auto a where m.phonenum = a.phonenum;

--Task 3, ������� ��� �������� �� ������� MAN, �� ������� CITY, ���������� ������� �� ���� ������.
select * from man m, city c where m.citycode = c.citycode;

--Task 4, ������� ��� � ������� �� ������� MAN, � ����� ����� �� ������� AUTO, ������-���� ��� ������� �� ������ �������� (PHONENUM).
select m.firstname, m.lastname, a.mark from man m, auto a where m.phonenum = a.phonenum;


--Step 30
--Task 2, ��������� RIGHT JOIN, �������� ��� ������ �� CITY � ������ ����������� �� MAN.
select * from man m right join city c on m.citycode = c.citycode;

--Task 3,��������� LEFT JOIN, �������� ��� ������ �� CITY � ������ ����������� �� MAN.
select * from city c left join man m on c.citycode = m.citycode;


--Step 31
--Task 2, ���������� ������� AUTO, CITY, MAN; �������� ��������� ������: ����� ����-������, ����, ��� ��������� � �����, ��� ��������� ��������; ������������ ���������� �� ������� ��������� ������.
select a.mark, a.color, m.firstname, c.cityname from auto a, man m, city c
    where (a.phonenum = m.phonenum) and (c.citycode = m.citycode)
        order by c.cityname;
        
--Task 3, ���������� ������� AUTO, MAN; �������� ��������� ������: ����� ����������, ����, ��� ���������; ������������ ���������� �� ������� ������ �����������, ����� ������-����� � �������� �������.
select a.mark, a.color, m.firstname from auto a inner join man m on a.phonenum = m.phonenum
    order by a.mark, a.color desc;
    
--Task 4, ���������� ������� CITY, MAN; �������� ��������� ������: �������� ������, ���; ������������ ���������� �� ������� ��������� ������, ��������� ����� ����������� LEFT JOIN.
select c.cityname, m.firstname from city c left join man m on c.citycode = m.citycode
    order by c.cityname;
    

--Step 32
--Task 2, �������� ���������� ���� �� AUTO, ��������������� �� ����� (MARK) (�� ���� ������� BMW, ������� LADA�).
select mark, count(mark) from auto a group by mark;

--Task 3, �������� ���������� ����� (COLOR) ����������� � ������� AUTO.
select count(color) from auto where color = '�����';

--Task 4, �������� ������������ � ����������� ����������� ��������� (PEOPLES) �� ���� ������� (CITY).
select max(peoples), min(peoples) from city;

--Task 5, �������� ������� ������� ����� (MAN) � ���������� ������� � ������, ���������-������ �� ������ ����� ����� (FIRSTNAME).
select avg(yearold), count(firstname), substr(firstname, 1, 1) from man group by substr (firstname, 1, 1);


--Step 33
--Task 1, �������� ����� ����������� �� ������� AUTO � ������� ���������� �����, �����-��� ���� � �� �� ����� ����, �� ����������� � ����� � ��� �� ������.
select a.mark, count(distinct m.citycode) from auto a inner join man m on a.phonenum = m.phonenum
    group by mark;
    
--Task 2, �������� �������� ������� � ����� ���������, ������� ������� ������� ����� ������ �� ������� MAN, ������������ ������ �� ���������� ������� �� ������� MAN � ������ �� �������.
select c.cityname, sum(m.yearold), avg(m.yearold) from city c inner join man m on c.citycode = m.citycode
    group by c.cityname
    order by count(m.phonenum);
    

--Step 34
--Task 1, �������� ������, ������� ���������� ���������� �� �����, ������� ���������� ���� ������ ����� � ������� �� ����� ������ ����� ���� BMW, LADA � �������������� HAVING.
select count(mark), mark from auto group by mark having mark in ('BMW', 'LADA');

--Task 2,�������� ������, ������� �� ������� ������������� ������ �� ������� CITY.
select c.rowid from city c;

--Task 3, �������� ������, ������� �� ������ ��������� ����� �� ������� MAN.
delete man1 where rowid not in
(
    select max(rowid) from man
);


--Step 35
--Task 1, ������� ��� ������ (AUTO), ��� ��� ��������� MAN (fIStNAME) ���������� � ����� �, ������������ IN � �����������.
select * from auto where phonenum in
(
    select phonenum from man where substr(firstname, 1, 1) = '�'
);

--Task 2, ������� ��� ������ (CITY), ��� ���� ������ �� ������� MAN � ����� ������ 35 ��� (YEAROLD), ������������ IN � �����������.
select * from city where citycode in
(
    select citycode from man where yearold > 35
);

--Task 3, ������� ��� ������ (AUTO), ��� ������� ��������� ������ 37 ��� (YEAROLD) � ����� ����� ������ ���� ���� (FIRSTNAME), ������������ IN � �����������
select * from auto where phonenum in
(
    select phonenum from man where (yearold > 37) and (length(firstname) > 5)
);


--Step 36
--Task 1, ������� ��� ���������� �� ������� AUTO, ��� ������� ��� ��������������� ������� � ������� MAN. ������������ EXISTS (����� �� PHONENUM).
select * from auto a where not exists
(
    select 1 from man m where m.phonenum = a.phonenum
);

--Task 2, ������� ��� ���������� �� ������� AUTO, ��� ���� ������ � ������� MAN, ��� ������� ����� ������ 35 ���, ��������� EXISTS (����� �� PHONENUM).
select * from auto a where exists
(
    select 1 from man m where (m.phonenum = a.phonenum) and (m.yearold > 35)
);


--Step 37
--Task 1, ������� ����� ����, ����, ��� ��������, ������� ������� �������, ������������ ��������� ��� ����� ������� �������.
select mark, color, (select firstname from man m where m.phonenum = a.phonenum) as ownerName from auto a; 

--Task 2, ������� ����� ����, ����, ��� ��������, ������� ������� �������, � � ����� ������ ����� ���� �������, ������������ ��������� ��� ����� ������� �������
select 
    a.mark, 
    a.color, 
    (select firstname from man m where m.phonenum = a.phonenum) as ownerName, 
    (select cityname from city c where c.citycode in (select citycode from man m where m.phonenum = a.phonenum) ) as townName
from auto a;
    
--Task 3, ������� �� MAN ���, ������� � ����� ���������� ��������, ������� ������� ��������� � ������ ������. ������������ ��������� ��� ����� ������� �������
select 
    firstname
    , lastname
    , (select cityname from city c where c.citycode = m.citycode) as cityName
    , (select peoples from city c where c.citycode = m.citycode) as cityPeoples
from man m;


--Step 38
--Task 1, ������� ��� ���������� BMW �� AUTO, ��������� ��������� ��� ������� ����� FROM.
with t1s38 as
(
    select * from auto where mark = :param
)
select * from t1s38;

--Task 2, ������� ��� ���������� �� AUTO � �� ����������, ������� ������ 25 ���, ��������� ��������� ��� �������.
with t2s38 as
(
    select * from auto where phonenum in (select phonenum from man where yearold > 25)
)
select * from t2s38;

--Task 3, ������� ��� ������, � ������� ������ �������� �������, ��������� ��������� ����� FROM.
with t3s38 as
(
    select * from city where peoples > 1000000
)
select * from t3s38;


--Step 39
--Task 2, ���������� ������ �� ������� 3 � �������������� ���������� EXISTS.
select mark, count(regnum) from auto a where exists
(
    select 1 from man m where (a.phonenum = m.phonenum) and exists
    (
        select 1 from city c where (c.citycode = m.citycode) and (c.peoples > 1000000)
    )
)
group by mark;

--Task 3, �������� ������ �� �������� ������� �� ������� CITY, ��� � ������� MAN �� ����� ������ ��������, ����������� EXISTS.
select cityname from city c where exists
(
    select count(citycode) from man m where c.citycode = m.citycode having count(citycode) < 2
);

--Task 4, ������� ���������� ����������� ������ �����, ������� ������ ���� ������ 29 ���. ����������� ��������� � IN.
select mark, count(mark) from auto where phonenum in
(
    select phonenum from man where yearold > 29
) group by mark;


--Step 40
--Task 1, ������� ��� ���������� AUTO *, ������� ��������� ����, ����������� � ������ (CITY) � ���������� (POPULATION) ������ 1 �������� �������. 
--������� ��� �������, ��� �������������� ���� ��������� ��������� ������ (CITYNAME) ����� � ������ ����������.
select f1.*, (select cityname from city c where c.citycode = f1.citycode) as cName from 
( 
    select * from auto a inner join man m on m.phonenum = a.phonenum where m.citycode in 
    (
        select citycode from city where peoples > 1000000
    )
) f1;

--Task 2, �� �� �� ��� 1��


--Step 41
--Task 2, ������� ��� ������, ��� ���������� ����������� ����� ������, ��� ���������� ����� � ������� � CITYCODE 5, 6, 7.
select * from city where peoples > any 
(
    select peoples from city where citycode = &p1 or citycode = &p2 or citycode = &p3
);

--Task 3, ������� �� ����� � ������� SELECT ���� ����� �� ������� MAN, ��� ������� ������ ������� ��������, � �������� ���������� BMW.
select * from man where yearold < all
(
    select yearold from man where phonenum in
    (
        select phonenum from auto where mark = 'BMW'
    )
);


--Step 42
--Task 2, �������� ������� ���� ������.
select to_char(sysdate, 'dy') as dn from dual;

--Task 3, �������� ��������� ���� ��� � ������� 22:10:2018 23-11-11.
select to_char(sysdate - 1, 'dd:mm:yyyy hh24-mi-ss') as dt from dual;

--Task 4, �������� ��������� ���� ��� � ������� 22-10-18 23-11-11.
select to_char(sysdate - 1, 'dd-mm-yyyy hh24-mi-ss') as dt from dual;

--Task 5, �������� ��������� ���� ��� � ������� 2018-10-22 23:11:11.
select to_char(sysdate - 1, 'dd-mm-yyyy hh24:mi:ss') as dt from dual;

--Task 6, �������� ������ �20.01� � ���� NUMBER.
select cast('20,01' as number) as num from dual;


--Step 43
--Task 1. ������� �� ������� CITY �������� ������, � ����� �������� ������, ��� ��� ������ = ��� �������� ������ +2.
select c1.cityname, c2.cityname from city c1 left join city c2 on c1.citycode + 2 = c2.citycode;

--Task 2. ������� �� ������� MAN ���, ������� ��������, � ����� ��� � ������� ��������, ������� ������ ������� �������� �� ��� ����.
select m1.firstname, m1.lastname, m2.firstname, m2.lastname from man m1 left join man m2 on m1.yearold + 3 = m2.yearold;

--Task 3. ������� �� ������� MAN ���, ������� ��������, � ����� ��� � ������� ��������, ������� ����� � ��� �� ������.
select m1.firstname, m1.lastname, m2.firstname, m2.lastname from man m1 left join man m2 on m1.citycode = m2.citycode;


--Step 44
--Task 1. ��������� UNION �������� �� ������� AUTO ����� ���������� � ������� ���������� �� AUTO1.
select * from man where firstname = '������' union select * from man1 where fn = '������';
--Task 2. ��������� UNION ALL, �������� �� ������� AUTO ��� ���������� � ������� ���������� AUTO.
select * from man where firstname = :fn1 union all select * from man1 where fn = :fn1;


--Step 45
--Task 1. �������, ����� ������ ���� � AUTO, �� ��� � AUTO1. ����������� MINUS.
select * from man minus select * from man1;
--Task 2. ������� ���������� �� AUTO � AUTO1. ����������� INTERSECT
select * from man intersect select * from man1;

    


