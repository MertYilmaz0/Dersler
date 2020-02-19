--Group by

/*
	Group by komutu tablodaki ortak verilerin gruplanarak dönmesini saðlar. Group by kullanýmýndan önce gruplanacak olan alanlar belirlenip daha sonra o alana göre bir select iþlemi yapýlýr.
*/

--Hangi kategoride kaç adet ürün bulunmaktadýr?
select 
CategoryID,COUNT(CategoryID) as 'Ürün Adet' 
from Products group by CategoryID

--Ülkelere göre çalýþan sayýsýný listeleyin.
select 
country, COUNT(Country) as 'Ülke' 
from Employees 
group by Country
----------------------------------------------

--Stokta hangi kategoriden toplam ne kadarlýk ürün vardýr?
select CategoryID,SUM(UnitPrice*UnitsInStock) as 'Toplam Fiyat' 
from Products 
group by CategoryID
------------------------------------------------------------

--Hangi personel hangi müþteriye kaç adet satýþ yapmýþtýr?

select EmployeeID,CustomerID,COUNT(OrderID) as 'Satýþ Adet' from Orders group by EmployeeID,CustomerID

-------------------------------------------------------------
