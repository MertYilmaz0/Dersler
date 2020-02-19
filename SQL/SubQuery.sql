--SubQuery - Alt Sorgular

/*
	T-Sql ile sorgu içerisinde sorgular yazabiliriz. Bazý durumlarda filitreleme yapmak için veya select ifadesinde baþka bir tablodan sütun çýkartmak kullanýlýr.
*/

--Fiyatý ortalama fiyatýn altýnda olan ürünleri listeleyin.

select ProductName  from Products where UnitPrice<AVG(UnitPrice)

select ProductName,UnitPrice  from Products where UnitPrice<(select AVG(unitprice) from Products)

-----------------------------------------------------------------------------------------

--Ürünler tablosunu tedarikçi adý, kategori adý, ürün adý, fiyat ve stok bilgileri ile listeleyin
select ProductName,UnitPrice,UnitsInStock,
(select c.CategoryName from Categories c where c.CategoryID=p.CategoryID) as 'Kategori Adý',
(select CompanyName from Suppliers s where s.SupplierID=p.SupplierID) as 'Tedarikçi Adý'
from Products p

---------------------------------------------------------------------------------------------

--Satýþlar tablosunu müþteri adý, personel adý ve soyadý ile birlikte listeleyin
select OrderID,
(select c.ContactName from Customers c where c.CustomerID=o.CustomerID) as 'Müþteri Adý',
(select (e.FirstName+' '+e.LastName) from Employees e where e.EmployeeID=o.EmployeeID) as 'Çalýþan Adý ve Soyadý'
from Orders o
--------------------------------------------------------------------------------------------

--Ürünler ile birlikte o ürünün toplam satýþ adet bilgisini listeleyin.

select ProductName,
(select SUM(Quantity) from [Order Details] od where od.ProductID=p.ProductID) as 'Toplam Satýþ'
from Products p

--------------------------------------------------------------------------------

--Yapýlan satýþlarý maksimum satýþ fiyatý ile listeleyin.
select *,
(select MAX(od.UnitPrice) from [Order Details] od where o.OrderID=od.OrderID) as 'Maksimum Satýþ'
from Orders o order by [Maksimum Satýþ] desc

--------------------------------------------------------------------------------------

--ürünlerle beraber ürüne uygulanan maksimum indirim yüzdesi bilgisini listeleyin.
select ProductName,
(select MAX(od.Discount) from [Order Details] od where p.ProductID=od.ProductID) as 'Ýndirim Yüzdesi'
from Products p order by [Ýndirim Yüzdesi] desc
----------------------------------------------------------------------------------------

--SubQuery Filitreleme Ýþlemleri

--Adý Janet olan personelin yapmýþ olduðu satýþlarý listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet')

--Adý janet veya nancy olan personellerin yaptýðý satýþlarý listeleyin.

--I. Yol
select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet') or EmployeeID=(select EmployeeID from Employees where FirstName='nancy')

--II.Yol
select * from Orders where EmployeeID in (select EmployeeID from Employees where FirstName='janet' or FirstName='nancy')

---------------------------------------------------------------------------------------------

--Personel adý steven olan ve nakliyesi "Federal Shipping" olan satýþlarý listeleyin.

select * from Orders where EmployeeID=(select employeeId from Employees where FirstName='steven') and ShipVia= (select ShipperID from Shippers where CompanyName='Federal Shipping')

---------------------------------------------------------------------------------------

--Bugüne kadar chai ürününden ne kadar kÂr elde edilmiþtir gösterin.

select ROUND(SUM(Quantity*UnitPrice*(1-Discount)),2) as 'Toplam' from [Order Details] where ProductID=(select ProductID from Products where ProductName='chai')

--------------------------------------------------------------------------
















 


