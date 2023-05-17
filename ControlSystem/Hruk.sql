--1. � ����� HR �������� ������ ��� �������� ���� ��������, � �������������� START WITH (manager_id = null )
--� ��� ������������� ������ �����������, ��������� �������.
--(����� ������������ �������������� �������)
select employee_id, manager_id from employees
start with manager_id is null
connect by prior employee_id = manager_id;

--2. ��������� ����� �������� �� �.1 ������� ���� �������� ���������/������� �����������/ ������� ����������� � �.�.� 
--��� � �������� ����� ������� 3 �������.
--�� ������������ ����������� �/�, ��������� ����
select sys_connect_by_path(first_name, '/hryak/') as qua from employees
where level > 2
connect by prior employee_id = manager_id;

--3. ������� �������� �� ������ ������� employees. �������� ������ ��������� ��� ����������, id ������������.
--����� �����, �������� ��������, ��������� ���������� ������ � ������� departments, ����� �� id �������������. 
--�������� ������ � ������� ��������� ������������ / ��� ����������
select count(*) from (select d.department_name, jija.first_name, jija.last_name
from
(
    select first_name, last_name, department_id
    from employees 
    connect by prior employee_id = manager_id
) jija inner join departments d on d.department_id = jija.department_id) t; 

--4. �������������� ������ �������� �� �2, ���������� ������ ��� ������������� �������� 
--(������� ������ ������� ��������� ������������ / ��� ���������� ��������� ����������������� ��������), 
--�������� ���� ������� (�������� ������ �� ������� ������ �;�, ����� ����� ������ F10 ��� ������ explain plan
create table jija as 
(
    select first_name, last_name, department_id
    from employees 
    connect by prior employee_id = manager_id
);
select count(*) from (select d.department_name, jija.first_name, jija.last_name
from departments d inner join jija on jija.department_id = d.department_id) t;

--5. �������� ������ ����������� ID ����������� ��������� ��������.
--� ������� �������� ��������� ������ ID �� 1. PRIOR ������������ �� �����, ��������� ������.
--����� ��������� �������� �������� � � �������� �����������, ������� ID ������� ��� � ������� �����������
select 