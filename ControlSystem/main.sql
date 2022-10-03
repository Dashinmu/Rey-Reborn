--Создание таблицы
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
VALUES(111114,'LADA', 'КРАСНЫЙ', date'2008-01-01', '9152222221')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111115,'VOLVO', 'КРАСНЫЙ', date'2013-01-01', '9152222222')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111116,'BMW', 'СИНИЙ', date'2015-01-01', '9153333333')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111121,'AUDI', 'СИНИЙ', date'2009-01-01', '9173333334')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111122,'AUDI', 'СИНИЙ', date'2011-01-01', '9173333335')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111113,'BMW', 'ЗЕЛЕНЫЙ', date'2007-01-01', '9213333336')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111126,'LADA', 'ЗЕЛЕНЫЙ', date'2005-01-01', '9213333331')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111117,'BMW', 'СИНИЙ', date'2005-01-01', '9213333332')
/

INSERT INTO AUTO (REGNUM, MARK,	COLOR, RELEASEDT, PHONENUM )
VALUES(111119,'LADA', 'СИНИЙ', date'2017-01-01', '9214444444')
/

 -- CITY
INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(1,'Москва', 10000000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(2,'Владимир', 500000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(3, 'Орел', 300000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(4,'Курск', 200000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(5, 'Казань', 2000000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(7, 'Котлас', 110000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(8, 'Мурманск', 400000)
/

INSERT INTO CITY (CITYCODE,CITYNAME,PEOPLES)
VALUES(9, 'Ярославль', 500000)
/
-- MAN
INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9152222221','Андрей','Николаев', 1, 22)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9152222222','Максим','Москитов', 1, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9153333333','Олег','Денисов', 3, 34)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9173333334','Алиса','Никина', 4, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9173333335','Таня','Иванова', 4, 31)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333336','Алексей','Иванов', 7, 25)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333331','Андрей','Некрасов', 2, 27)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9213333332','Миша','Рогозин', 2, 21)
/

INSERT INTO MAN (PHONENUM,FIRSTNAME,LASTNAME,CITYCODE,YEAROLD)
VALUES('9214444444','Алексей','Галкин', 1, 38)
/
*/



--Шаг 6
--Задание 4, создание таблицы запчасти
Create Table spare_parts 
(
    id_part NUMBER Primary Key
    ,auto_mark VARCHAR2 (50)
    ,name_part VARCHAR2 (50)
    ,count_part NUMBER
    ,cost_part NUMBER
);

--Задание 4, создание таблицы фото
Create Table photo 
(
    name_photo VARCHAR2 (50)
    ,photo_size VARCHAR2 (9)
    ,autograph VARCHAR2 (50)
    ,create_date DATE
);

--Задание 4, создание таблицы занятия
Create Table lessons 
(
    name_lesson VARCHAR2 (50)
    ,lesson_date DATE
    ,lesson_start VARCHAR2 (50)
    ,lesson_end VARCHAR2 (50)
);
    
--Шаг 7
--Задание 3, к таблице запчасти добавить колонку
Alter Table spare_parts ADD (part_weight NUMBER);

--Задание 4, удалить из таблицы фото
Alter Table photo DROP COLUMN photo_size;

--Задание 5, добавить колонку в таблицу занятия
Alter Table lessons ADD (name_teacher VARCHAR2 (50));

--Задание 6, удалить таблицу фото
Drop Table photo; --В принципе таблица не связана, поэтому просто выкинём

--Шаг 8 
--Забить

--Шаг 9
--Задание 1, добавить к таблице AUTO уникальность для колонки PHONENUM
Alter Table AUTO Modify PHONENUM UNIQUE;

--Задание 2, добавить к таблице MAN запрет на ввод пустых чисел в Y.O.
Alter Table MAN Modify YEAROLD NOT NULL;

--Задание 3, добавить проверку возсрата для MAN младше 100 лет (not dead)
Alter Table MAN ADD Constraint man_year_old Check (YEAROLD < 100);

--Задание 4, ссылочная целостность для таблиц AUTO и MAN
Alter Table AUTO ADD Constraint fk_auto_phone
    Foreign Key (PHONENUM)
    References MAN (PHONENUM);
  
    
--Шаг 10
--Задание 3, Создать индекс
Create index id_color on AUTO (COLOR);

--Задание 4, Создать реверс индекс
Create index year_rid on MAN (YEAROLD) reverse;


--Шаг 11
--Задание 2, Выбрать из таблицы MAN (*) людей, где возраст (YEAROLD) человека больше 30 лет
SELECT * FROM MAN WHERE YEAROLD > 30;

--Задание 3,Выбрать из таблицы городов все колонки (*), где город (CITYNAME) называется Москва.
SELECT * FROM CITY WHERE CITYNAME = 'Москва';

--Задание 4, Выбрать названия (CITYNAME) городов CITY с населением (PEOPLES) больше миллиона человек.
SELECT CITYNAME FROM CITY WHERE PEOPLES > 1000000;

--Задание 5, Выбрать телефоны людей из MAN, чья фамилия (LASTNAME)не Денисов.
SELECT PHONENUM FROM MAN WHERE LASTNAME != 'Денисов';

--Задание 6, Выбрать информацию о машинах car (*) синего цвета (COLOR).
SELECT * FROM AUTO WHERE COLOR = 'СИНИЙ';


--Шаг 12
--Задание 2, Выберите из таблицы CITY (*) город, где 200 тысяч жителей (PEOPLES); город с наименованием Москва (CITYNAME
SELECT * FROM CITY WHERE (CITYNAME = 'Москва') or (PEOPLES = 200000);

--Задание 3, Выберите из таблицы CITY города с населением (PEOPLES) не 500 тысяч жителей.
SELECT CITYNAME FROM CITY WHERE PEOPLES != 500000;

--Задание 4, Выберите из таблицы AUTO (*) все синие AUDI (COLOR, MARK).
SELECT * FROM AUTO WHERE (MARK = 'AUDI' and COLOR = 'СИНИЙ');

--Задание 5, Выберите из таблицы AUTO номера (regnum) и марки (MARK) всех VOLVO и BMW.
SELECT REGNUM, MARK FROM AUTO WHERE (MARK = 'VOLVO' or MARK = 'BMW');

--Задание 6, Выберите из таблицы MAN имена, фамилии (FIRSTNAME, LASTNAME) и возраст людей (YEAROLD), которым больше 29 и меньше 35 лет.
SELECT FIRSTNAME, LASTNAME, YEAROLD FROM MAN WHERE (YEAROLD > 29 and YEAROLD < 35);


--Шаг 13
--Задание 1, читай задание
SELECT * FROM CITY WHERE CITYNAME LIKE '%а%' ORDER BY CITYNAME, PEOPLES DESC;
--Задание 2, повтори действие задания 1
SELECT * FROM AUTO ORDER BY COLOR, MARK DESC;


--Шаг 14
--Задание 2, Выведите на экран первые 3 строчки из таблицы CITY.
SELECT * FROM CITY WHERE ROWNUM < 4;
--Задание 3, Выведите на экран первые 4 строчки из таблицы CITY, отсортированные по количеству населения (PEOPLES).
SELECT * FROM CITY WHERE ROWNUM < 5 ORDER BY PEOPLES;
--Задание 4, Выведите на экран данные из таблицы MAN.
SELECT * FROM MAN;


--Шаг 15
--Задание 1, я пёс - гоняюсь за хвостом
INSERT INTO MAN (PHONENUM, FIRSTNAME, LASTNAME, CITYCODE, YEAROLD)
VALUES ('12012012','Максим','Леонидов',2,25);
Commit;

INSERT INTO AUTO (REGNUM, MARK, COLOR, RELEASEDT, PHONENUM)
VALUES ('12887', 'LADA', 'КРАСНЫЙ', date'2001-01-01', '');
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

--Задание 2, Добавьте в таблицу городов новый город; код города и название придумайте сами.
INSERT INTO CITY (CITYCODE, CITYNAME, PEOPLES)
VALUES (159, 'Березники', 150000);
Commit;

--Задание 3, В таблицу CITY1 добавьте все строки из CITY, где популяция меньше полумиллиона человек
INSERT INTO city1 (citycode, cityname, peoples)
SELECT CITYCODE, CITYNAME, PEOPLES FROM CITY WHERE PEOPLES < 500000;
Commit;

--Задание 4,таблицу AUTO добавьте новую машину 999999 ЛАДА, цвет зеленый, 1999 года выпуска.
INSERT INTO AUTO (REGNUM, MARK, COLOR, RELEASEDT, PHONENUM)
VALUES ('999999', 'LADA', 'ЗЕЛЁНЫЙ', date'1999-01-01', null);
Commit;


--Шаг 16
--Задание 2, добавить 1 к возрасту Андреев
UPDATE MAN SET YEAROLD = YEAROLD+1 WHERE FIRSTNAME = 'Андрей';

--Задание 3, Добавить 2 к возрасту людей (MAN), чей возраст больше 19 лет.
UPDATE MAN SET YEAROLD = YEAROLD + 2 WHERE YEAROLD > 19;

--Задание 4, имени людей (MAN), чей телефон содержит 915, добавить префикс 915.
UPDATE MAN SET FIRSTNAME = FIRSTNAME + '915' WHERE PHONENUM LIKE '%915%';

--Задание 5,У всех у людей (MAN) с телефоном, чей возраст больше 22 лет, поменять имя на Роман.
UPDATE MAN SET FIRSTNAME = 'Роман' WHERE (YEAROLD > 22 and PHONENUM IS NOT NULL);


--Шаг 17
--Задание 2, Напишите команду для удаления из таблицы AUTO таких записей, где дата выпуска авто больше 2018 года.
DELETE AUTO WHERE RELEASEDT > date'2018-01-01';

--Шаг 18
--Task 3, Выведите с помощью запроса SQL наименование города из таблицы CITY. Для таб-лицы задайте псевдоним GR, для колонки «наименования» задайте псевдоним NM.
SELECT cityname as nm FROM city gr;

--Task 4, Выведите количество жителей в городе Москва, для колонки PEOPLES задайте псевдоним CLZ, для таблицы задать псевдоним MS.
SELECT peoples as clz FROM city ms WHERE ms.cityname = 'Москва';


--Step 19
--Task 2, Выберите города с населением от 40 000 до 2 000 000 человек, напишите SQL-запрос.
SELECT cityname FROM city c WHERE c.peoples BETWEEN 40000 and 2000000;

--Task 3, Выберите города с населением НЕ в интервале 40 000 до 2 000 000 человек, напишите SQL-запрос.
SELECT cityname FROM city c WHERE c.peoples NOT BETWEEN 40000 and 2000000;

--Task 4,Выберите людей * с возрастом НЕ в интервале 25 до 28 лет, используйте NOT,
SELECT * FROM man m WHERE m.yearold NOT BETWEEN 25 and 28;

--Task 5, Выберите машины с годом выпуска от 2007 до 2011, напишите SQL-запрос
SELECT * FROM auto a WHERE a.releasedt BETWEEN date'2007-01-01' and date'2011-12-31';


--Step 20
--Task 2, Выведите из таблицы AUTO цвета автомобилей, исключите повторения, напишите
SELECT DISTINCT color FROM auto;

--Task 3, Выведите из таблицы MAN имена людей, исключите повторения
SELECT DISTINCT firstname FROM man;


--Step 21
--Task 1, Вывести из таблицы MAN имя, фамилию и квадратный корень 10.
SELECT firstname, lastname, sqrt(10) as sqr10 FROM man;

--Task 2, Вывести из таблицы MAN имя, фамилию и возраст человека, умноженный на cos (5).
SELECT firstname, lastname, yearold*cos(5) as yo_cos5 FROM man;

--Task 3, Вывести из таблицы CITY записи (*), где популяция делится без остатка на 10 000.
SELECT * FROM city c WHERE mod(c.peoples, 10000) = 0;

--Task 4, Вывести из таблицы CITY название города, квадратный корень от популяции, умноженный на 10, где значение кода города делится нацело на 3.
SELECT cityname, sqrt(peoples) * 10 as Whoa FROM city c WHERE mod(c.citycode, 3) = 0;


--Step 22
--Task 1, Вычислить значение площади квадрата со стороной 5 с помощью SELECT и DUAL.
SELECT 5*5 as space FROM dual;

--Task 2, Вычислить значение площади круга с радиусом 7 помощью SELECT и DUAL
SELECT 7*7*3.14 as space FROM dual;

--Task 3, Вычислить значение выражения 100*sIN (1) *cos (3) с помощью SELECT и DUAL
SELECT 100*sin(1) * cos(3) FROM dual;


--Step 23
--Task 3, Выберите телефоны из таблицы AUTO. Вместо пустых телефонов выведите: NO PHONE, нет.
SELECT NVL(phonenum, 'NO PHONE') FROM auto;


--Step 24
--Task 1, Выберите из таблицы MAN всех людей *, чьи фамилии не начинаются со слога «Ив»,
SELECT * FROM man m WHERE m.lastname NOT LIKE 'Ив%';

--Task 2, Выберите из таблицы MAN всех людей *, в чьих именах есть русская буква «е».
SELECT * FROM man m WHERE m.firstname LIKE '%е%';

--Task 3, Выберите из таблицы CITY города, где третья буква в наименовании «а».
SELECT cityname FROM city c WHERE c.cityname LIKE '__а%';


--Step 25
--Task 1, Вывести год, месяц, день производства авто из таблицы AUTO.
SELECT to_char(releasedt, 'YYYY.MM.DD') as release_date from auto;

--Task 2,  Вывести дату 30 дней назад.
SELECT sysdate-30 as thirty_day_before from dual;

--Task 3, Вывести последний день месяца 80 дней назад.
select last_day(sysdate-80) as cho from dual;

--Task 4, Преобразовать следующую строку к дате 01.11.2011 21:11.
select to_char(sysdate, 'DD.MM.YYYY hh24:mi') from dual;

--Task 5, Преобразовать дату 5 дней назад к строке DD.MM.YYYY hh24:mi.
select to_char(sysdate - 5, 'DD.MM.YYYY hh24:mi') from dual;

--Task 6,Вывести на экран дату и время 4 часа назад от текущего момента.
select to_char(sysdate-1/24*4, 'DD.MM.YYYY hh24:mi') as whoa from dual;


--Step 26
--Task 1, Найти записи из таблицы МAN, начинающиеся на Ан, использовать SUBSTR.
select * from man m where substr(m.firstname, 1, 2) = 'Ан' or substr(m.lastname, 1, 2) = 'Ан';

--Task 2, Найти записи из таблицы MAN, где количество символов в фамилии человека больше 10.
select * from man m where length(m.lastname) > 10;

--Task 3, Вывести из таблицы MAN имя, фамилию, количество символов в фамилии, где коли-чество символов в фамилии человека больше 5.
select firstname, lastname, length(lastname) from man m where length(m.lastname) > 5;

--Task 4, Заменить буквы «о» в слове «молоко» на @, вывести результат, использовать REPLACE и DUAL.
select replace('молоко', 'о' ,'@') from dual;

--Task 5, Подсчитать количество букв «о» в слове «молоко», вывести результат, использовать REPLACE, DUAL и математику.
select length('молоко') - length(replace('молоко', 'о')) as bb from dual;

--Task 6, Найти первое вхождение буквы «о» в городе с кодом 1 из таблицы CITY.
select instr(cityname, 'о', 1), cityname from city where citycode = 1;

--Task 7, Найти первое и последнее вхождения буквы «и» в городе с кодом 2 из таблицы CITY.
select instr(cityname, 'и', 1), instr(cityname, 'и', -1),  cityname from city where citycode = 2;


--Step 27
--Task 1, Вывести из таблицы MAN имя, фамилию и квадратный корень из 133.
select firstname, lastname, sqrt(133) as whoa from man;

--Task 2, Вывести из таблицы MAN имя, фамилию и возраст человека, умноженный на cos (5).
SELECT firstname, lastname, yearold*cos(5) as yo_cos5 FROM man;

--Task 3, Вывести из таблицы CITY записи (*), где популяция делится без остатка на 10 000.
select * from city c where mod(c.peoples, 10000) = 0;

--Task 4, Вывести из таблицы CITY название города, квадратный корень от популяции, умно-женный на 10, где значение кода города делится нацело на 5.
SELECT cityname, sqrt(peoples) * 10 as Whoa FROM city c WHERE mod(c.citycode, 5) = 0;


--Step 28
--Task 1, Выбрать из таблицы AUTO, где REGNUM – 111114, 111115, 111116.
select * from auto a where a.regnum in (111114, 111115, 111116);

--Task 2, Выбрать из таблицы MAN * людей с именами (FIRSTNAME) Андрей, Максим, Алиса.
select * from man m where m.firstname in ('Андрей', 'Максим', 'Алиса');

--Task 3, Выбрать из таблицы CITY * города (CITYNAME) Москва, Владимир, Казань
select * from city c where c.cityname in ('Москва', 'Владимир', 'Казань');

--Task 4, Выбрать из таблицы CITY * города с кодами (CITYCODE) 1, 3, 5, 7.
select * from city c where c.citycode in (1, 3, 5, 7);


--Step 29
--Task 2, Вывести все значения из таблицы MAN, из таблицы AUTO, объединить эти две таб-лицы посредством поля «номер телефона» (PHONENUM).
select * from man m, auto a where m.phonenum = a.phonenum;

--Task 3, Вывести все значения из таблицы MAN, из таблицы CITY, объединить таблицы по коду города.
select * from man m, city c where m.citycode = c.citycode;

--Task 4, Вывести имя и фамилию из таблицы MAN, а также марку из таблицы AUTO, объеди-нить две таблицы по номеру телефона (PHONENUM).
select m.firstname, m.lastname, a.mark from man m, auto a where m.phonenum = a.phonenum;


--Step 30
--Task 2, Используя RIGHT JOIN, выберите все записи из CITY и только совпадающие из MAN.
select * from man m right join city c on m.citycode = c.citycode;

--Task 3,Используя LEFT JOIN, выберите все записи из CITY и только совпадающие из MAN.
select * from city c left join man m on c.citycode = m.citycode;


--Step 31
--Task 2, Объедините таблицы AUTO, CITY, MAN; выведите следующие данные: марка авто-мобиля, цвет, имя владельца и город, где проживает владелец; отсортируйте результаты по колонке «название города».
select a.mark, a.color, m.firstname, c.cityname from auto a, man m, city c
    where (a.phonenum = m.phonenum) and (c.citycode = m.citycode)
        order by c.cityname;
        
--Task 3, Объедините таблицы AUTO, MAN; выведите следующие данные: марка автомобиля, цвет, имя владельца; отсортируйте результаты по колонке «марка автомобиля», «цвет автомо-биля» в обратном порядке.
select a.mark, a.color, m.firstname from auto a inner join man m on a.phonenum = m.phonenum
    order by a.mark, a.color desc;
    
--Task 4, Объедините таблицы CITY, MAN; выведите следующие данные: название города, имя; отсортируйте результаты по колонке «название города», используя левое объединение LEFT JOIN.
select c.cityname, m.firstname from city c left join man m on c.citycode = m.citycode
    order by c.cityname;
    

--Step 32
--Task 2, Выведите количество авто из AUTO, сгруппированных по марке (MARK) (то есть сколько BMW, сколько LADA…).
select mark, count(mark) from auto a group by mark;

--Task 3, Выведите количество синих (COLOR) автомобилей в таблице AUTO.
select count(color) from auto where color = 'СИНИЙ';

--Task 4, Выведите максимальную и минимальную численность населения (PEOPLES) во всех городах (CITY).
select max(peoples), min(peoples) from city;

--Task 5, Выведите средний возраст людей (MAN) и количество человек в группе, сгруппиро-ванных по ПЕРВОЙ БУКВЕ имени (FIRSTNAME).
select avg(yearold), count(firstname), substr(firstname, 1, 1) from man group by substr (firstname, 1, 1);


--Step 33
--Task 1, Выведите марки автомобилей из таблицы AUTO и найдите количество людей, купив-ших одну и ту же марку авто, не проживающих в одном и том же городе.
select a.mark, count(distinct m.citycode) from auto a inner join man m on a.phonenum = m.phonenum
    group by mark;
    
--Task 2, Выведите названия городов и сумму возрастов, средний возраст жителей этого города из таблицы MAN, отсортируйте данные по количеству жителей из таблицы MAN в каждом из городов.
select c.cityname, sum(m.yearold), avg(m.yearold) from city c inner join man m on c.citycode = m.citycode
    group by c.cityname
    order by count(m.phonenum);
    

--Step 34
--Task 1, Напишите запрос, который группирует автомобили по марке, находит количество авто каждой марки и выводит на экран только марки авто BMW, LADA – воспользуйтесь HAVING.
select count(mark), mark from auto group by mark having mark in ('BMW', 'LADA');

--Task 2,Напишите запрос, который бы выводил дублирующиеся строки из таблицы CITY.
select c.rowid from city c;

--Task 3, Напишите запрос, который бы удалял дубликаты строк из таблицы MAN.
delete man1 where rowid not in
(
    select max(rowid) from man
);


--Step 35
--Task 1, Выбрать все машины (AUTO), где имя владельца MAN (fIStNAME) начинается с буквы А, использовать IN с подзапросом.
select * from auto where phonenum in
(
    select phonenum from man where substr(firstname, 1, 1) = 'А'
);

--Task 2, Выбрать все города (CITY), где есть записи из таблицы MAN и людям больше 35 лет (YEAROLD), использовать IN с подзапросом.
select * from city where citycode in
(
    select citycode from man where yearold > 35
);

--Task 3, Выбрать все машины (AUTO), где возраст владельца больше 37 лет (YEAROLD) и длина имени больше пяти букв (FIRSTNAME), использовать IN с подзапросом
select * from auto where phonenum in
(
    select phonenum from man where (yearold > 37) and (length(firstname) > 5)
);


--Step 36
--Task 1, Вывести все автомобили из таблицы AUTO, для которых нет соответствующих записей в таблице MAN. Использовать EXISTS (связь по PHONENUM).
select * from auto a where not exists
(
    select 1 from man m where m.phonenum = a.phonenum
);

--Task 2, Вывести все автомобили из таблицы AUTO, где есть записи в таблице MAN, где возраст людей больше 35 лет, используя EXISTS (связь по PHONENUM).
select * from auto a where exists
(
    select 1 from man m where (m.phonenum = a.phonenum) and (m.yearold > 35)
);


--Step 37
--Task 1, Выбрать марку авто, цвет, имя человека, который владеет машиной, использовать подзапрос для новой колонки таблицы.
select mark, color, (select firstname from man m where m.phonenum = a.phonenum) as ownerName from auto a; 

--Task 2, Выбрать марку авто, цвет, имя человека, который владеет машиной, и в каком городе живет этот человек, использовать подзапрос для новой колонки таблицы
select 
    a.mark, 
    a.color, 
    (select firstname from man m where m.phonenum = a.phonenum) as ownerName, 
    (select cityname from city c where c.citycode in (select citycode from man m where m.phonenum = a.phonenum) ) as townName
from auto a;
    
--Task 3, Выбрать из MAN имя, фамилию и город проживания человека, сколько человек проживает в данном городе. Использовать подзапрос для новой колонки таблицы
select 
    firstname
    , lastname
    , (select cityname from city c where c.citycode = m.citycode) as cityName
    , (select peoples from city c where c.citycode = m.citycode) as cityPeoples
from man m;


--Step 38
--Task 1, Выбрать все автомобили BMW из AUTO, используя подзапрос как таблицу после FROM.
with t1s38 as
(
    select * from auto where mark = :param
)
select * from t1s38;

--Task 2, Выбрать все автомобили из AUTO и их владельцев, которым больше 25 лет, используя подзапрос как таблицу.
with t2s38 as
(
    select * from auto where phonenum in (select phonenum from man where yearold > 25)
)
select * from t2s38;

--Task 3, Выбрать все города, в которых больше миллиона жителей, используя подзапрос после FROM.
with t3s38 as
(
    select * from city where peoples > 1000000
)
select * from t3s38;


--Step 39
--Task 2, Перепишите запрос из примера 3 с использованием подзапроса EXISTS.
select mark, count(regnum) from auto a where exists
(
    select 1 from man m where (a.phonenum = m.phonenum) and exists
    (
        select 1 from city c where (c.citycode = m.citycode) and (c.peoples > 1000000)
    )
)
group by mark;

--Task 3, Выберите только те названия городов из таблицы CITY, где в таблице MAN не более одного человека, используйте EXISTS.
select cityname from city c where exists
(
    select count(citycode) from man m where c.citycode = m.citycode having count(citycode) < 2
);

--Task 4, Найдите количество автомобилей каждой марки, которые купили люди старше 29 лет. Используйте подзапрос с IN.
select mark, count(mark) from auto where phonenum in
(
    select phonenum from man where yearold > 29
) group by mark;


--Step 40
--Task 1, Вывести все автомобили AUTO *, которые приобрели люди, проживающие в городе (CITY) с населением (POPULATION) больше 1 миллиона человек. 
--Вывести как колонку, как дополнительное поле подзапрос «название города» (CITYNAME) рядом с маркой автомобиля.
select f1.*, (select cityname from city c where c.citycode = f1.citycode) as cName from 
( 
    select * from auto a inner join man m on m.phonenum = a.phonenum where m.citycode in 
    (
        select citycode from city where peoples > 1000000
    )
) f1;

--Task 2, не ну он как 1ый


--Step 41
--Task 2, Вывести все города, где количество проживающих людей больше, чем количество людей в городах с CITYCODE 5, 6, 7.
select * from city where peoples > any 
(
    select peoples from city where citycode = &p1 or citycode = &p2 or citycode = &p3
);

--Task 3, Вывести на экран с помощью SELECT всех людей из таблицы MAN, чей возраст меньше каждого человека, у которого автомобиль BMW.
select * from man where yearold < all
(
    select yearold from man where phonenum in
    (
        select phonenum from auto where mark = 'BMW'
    )
);


--Step 42
--Task 2, Показать текущий день недели.
select to_char(sysdate, 'dy') as dn from dual;

--Task 3, Показать вчерашнюю дату как в примере 22:10:2018 23-11-11.
select to_char(sysdate - 1, 'dd:mm:yyyy hh24-mi-ss') as dt from dual;

--Task 4, Показать вчерашнюю дату как в примере 22-10-18 23-11-11.
select to_char(sysdate - 1, 'dd-mm-yyyy hh24-mi-ss') as dt from dual;

--Task 5, Показать вчерашнюю дату как в примере 2018-10-22 23:11:11.
select to_char(sysdate - 1, 'dd-mm-yyyy hh24:mi:ss') as dt from dual;

--Task 6, Привести строку «20.01» к типу NUMBER.
select cast('20,01' as number) as num from dual;


--Step 43
--Task 1. Выбрать из таблицы CITY названия города, а также названия города, где код города = код текущего города +2.
select c1.cityname, c2.cityname from city c1 left join city c2 on c1.citycode + 2 = c2.citycode;

--Task 2. Выбрать из таблицы MAN имя, фамилию человека, а также имя и фамилию человека, который старше данного человека на три года.
select m1.firstname, m1.lastname, m2.firstname, m2.lastname from man m1 left join man m2 on m1.yearold + 3 = m2.yearold;

--Task 3. Выбрать из таблицы MAN имя, фамилию человека, а также имя и фамилию человека, который живет в том же городе.
select m1.firstname, m1.lastname, m2.firstname, m2.lastname from man m1 left join man m2 on m1.citycode = m2.citycode;


--Step 44
--Task 1. Используя UNION выведите из таблицы AUTO синие автомобили и зеленые автомобили из AUTO1.
select * from man where firstname = 'Максим' union select * from man1 where fn = 'Андрей';
--Task 2. Используя UNION ALL, выведите из таблицы AUTO все автомобили и зеленые автомобили AUTO.
select * from man where firstname = :fn1 union all select * from man1 where fn = :fn1;


--Step 45
--Task 1. Найдите, какие строки есть в AUTO, но нет в AUTO1. Используйте MINUS.
select * from man minus select * from man1;
--Task 2. Найдите совпадение из AUTO и AUTO1. Используйте INTERSECT
select * from man intersect select * from man1;

    


