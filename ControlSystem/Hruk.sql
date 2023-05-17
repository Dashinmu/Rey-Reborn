--1. В схеме HR написать запрос для создания двух иерархий, с использованием START WITH (manager_id = null )
--и без использования данной конструкции, объяснить разницу.
--(Можно использовать дополнительные столбцы)
select employee_id, manager_id from employees
start with manager_id is null
connect by prior employee_id = manager_id;

--2. Используя любую иерархию из п.1 вывести пути «Фамилия менеджера/фамилия подчинённого/ фамилия подчинённого и т.д.» 
--где в иерархии будет минимум 3 фамилии.
--НЕ ИСПОЛЬЗОВАТЬ разделитель «/», придумать свой
select sys_connect_by_path(first_name, '/hryak/') as qua from employees
where level > 2
connect by prior employee_id = manager_id;

--3. Создать иерархию на основе таблицы employees. Иерархия должна содержать ФИО сотрудника, id департамента.
--После этого, создайте иерархию, используя полученный запрос и таблицу departments, связь по id департаментов. 
--Выведите данные в формате «Название департамента / ФИО сотрудника»
select count(*) from (select d.department_name, jija.first_name, jija.last_name
from
(
    select first_name, last_name, department_id
    from employees 
    connect by prior employee_id = manager_id
) jija inner join departments d on d.department_id = jija.department_id) t; 

--4. Материализуйте первую иерархию из п2, перепишите запрос без использования иерархий 
--(вывести данные формате «Название департамента / ФИО сотрудника» используя материализованную иерархию), 
--сравните план запроса (выделить запрос НЕ ВЫДЕЛЯЯ символ «;», после этого нажать F10 или кнопку explain plan
create table jija as 
(
    select first_name, last_name, department_id
    from employees 
    connect by prior employee_id = manager_id
);
select count(*) from (select d.department_name, jija.first_name, jija.last_name
from departments d inner join jija on jija.department_id = d.department_id) t;

--5. Получить список пропущенных ID сотрудников используя иерархию.
--С помощью иерархии составить список ID от 1. PRIOR использовать не нужно, объясните почему.
--После получения иерархии сравнить её с таблицей сотрудников, вывести ID которых нет в таблице сотрудников
select 