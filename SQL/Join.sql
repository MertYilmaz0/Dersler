--Join (Dahil etme)

--syntax

/*
	select
	<tabloAdi1>.<kolonAdi>
	<tabloAdi2>.<kolonAdi>
	from <tabloAdi1> inner join <tabloAdi2> on <tabloAdi1>.<KolonAdi>=<tabloAdi2>.<kolonAdi>
*/

--inner join ifadesi her iki tabloda null olmayan kay�tlar� getirir.

--�al��anlar�n Id'lerine g�re �al��anlar�n alm�� olduklar� sipari�lerin say�s�n� yine sipari� say�s�na g�re �oktan aza do�ru listeleyin.

select employeeId, COUNT(OrderID) as 'Sipari� Say�s�' from Orders group by EmployeeID order by 2 desc

--Raporlama yaparken Id bilgileri anlaml� bilgiler de�illerdir. ��nk� kim olduklar� belli de�ildir. Bu y�zden isim soyisim yaz�lmas� daha anla��l�r hale gelecektir. Tablolar� birbirlerine referans olarak join ile beraber ba�lamam�z gerekmektedir.

select 
e.FirstName,e.LastName,COUNT(o.OrderID) as 'Sipari� Say�s�'
from Orders o 
inner join Employees e
on o.EmployeeID=e.EmployeeID
--buraya dilerseniz farkl� tablolar� yine inner join <tabloAdi> ile dahil edebilirsiniz.
--on <tabloAdi>.<kolonAdi>=<tabloAdi>.<kolonAdi>
group by e.FirstName,e.LastName
order by [Sipari� Say�s�] desc

----------------------------------------------------------------------------------------

--Federal Shipping ile ta��nm�� ve nancy �zerine kay�tl� olan sipari�lerin �al��an Id'si, �al��an ad� ve soyad�, �irket ad�, sipari� Id'si, sipari� tarihi ve kargo �cretini listeleyin.

--Shippers
--Employees
--Orders
--Customers

select 
e.EmployeeID, e.FirstName+' '+e.LastName as '�al��an Ad� ve Soyad�',c.CompanyName as '�irket Ad�',o.OrderID as 'Sipari� ID', o.OrderDate as 'Sipari� Tarihi', o.Freight as 'Kargo �creti'
from Orders o 
inner join Shippers s
on o.ShipVia=s.ShipperID
inner join Customers c
on o.CustomerID=c.CustomerID
inner join Employees e
on o.EmployeeID=e.EmployeeID
where  s.CompanyName='Federal Shipping' and e.FirstName='Nancy'

--------------------------------------------------------------------------------------

--En �ok �r�n al�nan tedarik�iyi alm�� olunan �r�n miktar�na g�re listeleyin.
select s.SupplierID, s.CompanyName as 'Tedarik�i Ad�', SUM(p.UnitsInStock) as 'Al�nan Toplam �r�n' from Products p
inner join Suppliers s
on p.SupplierID=s.SupplierID
group by s.SupplierID, s.CompanyName
order by [Al�nan Toplam �r�n] desc

---------------------------------------------------------------------------------------

--Hangi �lkelere toplam ne kadarl�k sat�� yap�lm��t�r?  11/7



select o.ShipCountry as '�lke', ROUND(SUM(od.UnitPrice*od.Quantity*(1-Discount)),2) as 'Toplam Sat��' from Orders o
inner join [Order Details] od
on o.OrderID=od.OrderID
group by o.ShipCountry
order by [Toplam Sat��] desc

---------------------------------------------------------------------------------------

--Her bir �r�nden toplam ne kadarl�k sat�� yap�lm��t�r ve o �r�n hangi kategoriye aittir?

select top 5 p.ProductName,c.CategoryName, ROUND(SUM(od.UnitPrice*od.Quantity*(1-Discount)),2) 
from [Order Details] od
inner join Products p
on od.ProductID=p.ProductID
inner join Categories c
on p.CategoryID=c.CategoryID
group by p.ProductName,c.CategoryName
order by 3 desc

--top komutu ka� adet sorgunun listelenece�ini belirler. �rn. Top 3 yaz�ld��� 3 kay�t teslim edilir. top komutu select ifadesinden hemen sonra yaz�lmal�d�r.
-----------------------------------------------------------------------------------------

--Hangi personel hangi kategoriden toplamda ka� adet �r�n sat��� yapm��t�r?

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

--Hangi �al��an hangi �al��ana ba�l�d�r?
select calisan.FirstName as '�al��an', mudur.FirstName as 'M�d�r' from Employees calisan
inner join Employees mudur
on calisan.ReportsTo=mudur.EmployeeID

----------------------------------------------------------------------------------------
















