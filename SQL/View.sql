--View

/*
	Sql server ortamýnda sanal tablo olarak kullanýlan gerçek tablodan veriyi alarak özetleyen tablolardýr. Anlýk deðil kalýcý olarak saklanan sql server objeleridir. Viewler sonraki aþamalarda da kullanýlabilir. Sürekli yazmýþ olduðunuz sql sorgularýnýzý veya karmaþýk iç içe yazýlan (SubQuery) veya çok lu tablolarýmýzýn (joinler) ihtiyaç halinde sürekli yazmaktansa bir kere yazýp tekrar tekrar kullanmamýzý saðlar.
*/

--Bir sipariþin hangi çalýþan tarafýndan hangi müþteriye hangi kategorideki üründen hangi fiyattan kaç adet satýldýðýný listeleyiniz.
--Çalýþan adý ve soyadý, ünvaný, görevi, iþe baþlama tarihi,
--müþterinin firma adý, temsilcisini ve telefon numarasýný,
--ürünün adýný, stok miktarýný, birim fiyatýný,
--sipariþin adedi ve satýþ fiyatý
--kategorinin adýný getirin.


select e.FirstName,e.LastName,e.TitleOfCourtesy, e.Title,e.HireDate,c.CompanyName,c.ContactName,c.Phone,p.ProductName,p.UnitsInStock,p.UnitPrice,od.Quantity,od.UnitPrice,ca.CategoryName
from Employees as e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join Customers c on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Categories ca on ca.CategoryID=p.CategoryID

--DDL
	--Create
	--Alter
	--Drop

create view SatisRaporu 
as
select e.FirstName,e.LastName,e.TitleOfCourtesy, e.Title,e.HireDate,c.CompanyName,c.ContactName,c.Phone,p.ProductName,p.UnitsInStock,p.UnitPrice as 'Birim Fiyat',od.Quantity,od.UnitPrice as 'Satýþ Fiyat',ca.CategoryName
from Employees as e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join Customers c on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Categories ca on ca.CategoryID=p.CategoryID

--View kullanýmý
select FirstName,LastName from SatisRaporu
----------------------------------------------------------------------------------------

create view Kategoriler
as
	select CategoryName,Description from Categories

--View kullanýmý

select * from Kategoriler

insert into Categories values ('Yiyecek','sýcak ve soðuk yiyecekler',null)

insert into Kategoriler
values ('Ýçecekler','alkollü ve alkolsüz içecekler')

--Alter

alter view Kategoriler
as
	select CategoryID as 'Kategori Id', CategoryName as 'Kategori Adý', Description as 'Açýklama' from Categories

select * from Kategoriler

--Drop
drop view Kategoriler

----------------------------------------------------------------------------------------



