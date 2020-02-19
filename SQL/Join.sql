--Join (Dahil etme)

--syntax

/*
	select
	<tabloAdi1>.<kolonAdi>
	<tabloAdi2>.<kolonAdi>
	from <tabloAdi1> inner join <tabloAdi2> on <tabloAdi1>.<KolonAdi>=<tabloAdi2>.<kolonAdi>
*/

--inner join ifadesi her iki tabloda null olmayan kayýtlarý getirir.

--Çalýþanlarýn Id'lerine göre çalýþanlarýn almýþ olduklarý sipariþlerin sayýsýný yine sipariþ sayýsýna göre çoktan aza doðru listeleyin.

select employeeId, COUNT(OrderID) as 'Sipariþ Sayýsý' from Orders group by EmployeeID order by 2 desc

--Raporlama yaparken Id bilgileri anlamlý bilgiler deðillerdir. Çünkü kim olduklarý belli deðildir. Bu yüzden isim soyisim yazýlmasý daha anlaþýlýr hale gelecektir. Tablolarý birbirlerine referans olarak join ile beraber baðlamamýz gerekmektedir.

select 
e.FirstName,e.LastName,COUNT(o.OrderID) as 'Sipariþ Sayýsý'
from Orders o 
inner join Employees e
on o.EmployeeID=e.EmployeeID
--buraya dilerseniz farklý tablolarý yine inner join <tabloAdi> ile dahil edebilirsiniz.
--on <tabloAdi>.<kolonAdi>=<tabloAdi>.<kolonAdi>
group by e.FirstName,e.LastName
order by [Sipariþ Sayýsý] desc

----------------------------------------------------------------------------------------

--Federal Shipping ile taþýnmýþ ve nancy üzerine kayýtlý olan sipariþlerin çalýþan Id'si, çalýþan adý ve soyadý, þirket adý, sipariþ Id'si, sipariþ tarihi ve kargo ücretini listeleyin.

--Shippers
--Employees
--Orders
--Customers

select 
e.EmployeeID, e.FirstName+' '+e.LastName as 'Çalýþan Adý ve Soyadý',c.CompanyName as 'Þirket Adý',o.OrderID as 'Sipariþ ID', o.OrderDate as 'Sipariþ Tarihi', o.Freight as 'Kargo Ücreti'
from Orders o 
inner join Shippers s
on o.ShipVia=s.ShipperID
inner join Customers c
on o.CustomerID=c.CustomerID
inner join Employees e
on o.EmployeeID=e.EmployeeID
where  s.CompanyName='Federal Shipping' and e.FirstName='Nancy'

--------------------------------------------------------------------------------------

--En çok ürün alýnan tedarikçiyi almýþ olunan ürün miktarýna göre listeleyin.
select s.SupplierID, s.CompanyName as 'Tedarikçi Adý', SUM(p.UnitsInStock) as 'Alýnan Toplam Ürün' from Products p
inner join Suppliers s
on p.SupplierID=s.SupplierID
group by s.SupplierID, s.CompanyName
order by [Alýnan Toplam Ürün] desc

---------------------------------------------------------------------------------------

--Hangi ülkelere toplam ne kadarlýk satýþ yapýlmýþtýr?  11/7



select o.ShipCountry as 'Ülke', ROUND(SUM(od.UnitPrice*od.Quantity*(1-Discount)),2) as 'Toplam Satýþ' from Orders o
inner join [Order Details] od
on o.OrderID=od.OrderID
group by o.ShipCountry
order by [Toplam Satýþ] desc

---------------------------------------------------------------------------------------

--Her bir üründen toplam ne kadarlýk satýþ yapýlmýþtýr ve o ürün hangi kategoriye aittir?

select top 5 p.ProductName,c.CategoryName, ROUND(SUM(od.UnitPrice*od.Quantity*(1-Discount)),2) 
from [Order Details] od
inner join Products p
on od.ProductID=p.ProductID
inner join Categories c
on p.CategoryID=c.CategoryID
group by p.ProductName,c.CategoryName
order by 3 desc

--top komutu kaç adet sorgunun listeleneceðini belirler. Örn. Top 3 yazýldýðý 3 kayýt teslim edilir. top komutu select ifadesinden hemen sonra yazýlmalýdýr.
-----------------------------------------------------------------------------------------

--Hangi personel hangi kategoriden toplamda kaç adet ürün satýþý yapmýþtýr?

select e.FirstName,c.CategoryName,SUM(od.Quantity) as 'Adet' from Employees e
inner join Orders o
on e.EmployeeID=o.EmployeeID
inner join [Order Details] od
on o.OrderID=od.OrderID
inner join Products p
on od.ProductID=p.ProductID
inner join Categories c
on p.CategoryID=c.CategoryID
group by e.FirstName,c.CategoryName order by Adet desc

---------------------------------------------------------------------------------------

--Hangi çalýþan hangi çalýþana baðlýdýr?
select calisan.FirstName as 'Çalýþan', mudur.FirstName as 'Müdür' from Employees calisan
inner join Employees mudur
on calisan.ReportsTo=mudur.EmployeeID

----------------------------------------------------------------------------------------
















