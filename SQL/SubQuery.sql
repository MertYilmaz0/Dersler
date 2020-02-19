--SubQuery - Alt Sorgular

/*
	T-Sql ile sorgu i�erisinde sorgular yazabiliriz. Baz� durumlarda filitreleme yapmak i�in veya select ifadesinde ba�ka bir tablodan s�tun ��kartmak kullan�l�r.
*/

--Fiyat� ortalama fiyat�n alt�nda olan �r�nleri listeleyin.

select ProductName  from Products where UnitPrice<AVG(UnitPrice)

select ProductName,UnitPrice  from Products where UnitPrice<(select AVG(unitprice) from Products)

-----------------------------------------------------------------------------------------

--�r�nler tablosunu tedarik�i ad�, kategori ad�, �r�n ad�, fiyat ve stok bilgileri ile listeleyin
select ProductName,UnitPrice,UnitsInStock,
(select c.CategoryName from Categories c where c.CategoryID=p.CategoryID) as 'Kategori Ad�',
(select CompanyName from Suppliers s where s.SupplierID=p.SupplierID) as 'Tedarik�i Ad�'
from Products p

---------------------------------------------------------------------------------------------

--Sat��lar tablosunu m��teri ad�, personel ad� ve soyad� ile birlikte listeleyin
select OrderID,
(select c.ContactName from Customers c where c.CustomerID=o.CustomerID) as 'M��teri Ad�',
(select (e.FirstName+' '+e.LastName) from Employees e where e.EmployeeID=o.EmployeeID) as '�al��an Ad� ve Soyad�'
from Orders o
--------------------------------------------------------------------------------------------

--�r�nler ile birlikte o �r�n�n toplam sat�� adet bilgisini listeleyin.

select ProductName,
(select SUM(Quantity) from [Order Details] od where od.ProductID=p.ProductID) as 'Toplam Sat��'
from Products p

--------------------------------------------------------------------------------

--Yap�lan sat��lar� maksimum sat�� fiyat� ile listeleyin.
select *,
(select MAX(od.UnitPrice) from [Order Details] od where o.OrderID=od.OrderID) as 'Maksimum Sat��'
from Orders o order by [Maksimum Sat��] desc

--------------------------------------------------------------------------------------

--�r�nlerle beraber �r�ne uygulanan maksimum indirim y�zdesi bilgisini listeleyin.
select ProductName,
(select MAX(od.Discount) from [Order Details] od where p.ProductID=od.ProductID) as '�ndirim Y�zdesi'
from Products p order by [�ndirim Y�zdesi] desc
----------------------------------------------------------------------------------------

--SubQuery Filitreleme ��lemleri

--Ad� Janet olan personelin yapm�� oldu�u sat��lar� listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet')

--Ad� janet veya nancy olan personellerin yapt��� sat��lar� listeleyin.

--I. Yol
select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet') or EmployeeID=(select EmployeeID from Employees where FirstName='nancy')

--II.Yol
select * from Orders where EmployeeID in (select EmployeeID from Employees where FirstName='janet' or FirstName='nancy')

---------------------------------------------------------------------------------------------

--Personel ad� steven olan ve nakliyesi "Federal Shipping" olan sat��lar� listeleyin.

select * from Orders where EmployeeID=(select employeeId from Employees where FirstName='steven') and ShipVia= (select ShipperID from Shippers where CompanyName='Federal Shipping')

---------------------------------------------------------------------------------------

--Bug�ne kadar chai �r�n�nden ne kadar k�r elde edilmi�tir g�sterin.

select ROUND(SUM(Quantity*UnitPrice*(1-Discount)),2) as 'Toplam' from [Order Details] where ProductID=(select ProductID from Products where ProductName='chai')

--------------------------------------------------------------------------
















 


