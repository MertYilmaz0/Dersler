--View

/*
	Sql server ortam�nda sanal tablo olarak kullan�lan ger�ek tablodan veriyi alarak �zetleyen tablolard�r. Anl�k de�il kal�c� olarak saklanan sql server objeleridir. Viewler sonraki a�amalarda da kullan�labilir. S�rekli yazm�� oldu�unuz sql sorgular�n�z� veya karma��k i� i�e yaz�lan (SubQuery) veya �ok lu tablolar�m�z�n (joinler) ihtiya� halinde s�rekli yazmaktansa bir kere yaz�p tekrar tekrar kullanmam�z� sa�lar.
*/

--Bir sipari�in hangi �al��an taraf�ndan hangi m��teriye hangi kategorideki �r�nden hangi fiyattan ka� adet sat�ld���n� listeleyiniz.
--�al��an ad� ve soyad�, �nvan�, g�revi, i�e ba�lama tarihi,
--m��terinin firma ad�, temsilcisini ve telefon numaras�n�,
--�r�n�n ad�n�, stok miktar�n�, birim fiyat�n�,
--sipari�in adedi ve sat�� fiyat�
--kategorinin ad�n� getirin.


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
select e.FirstName,e.LastName,e.TitleOfCourtesy, e.Title,e.HireDate,c.CompanyName,c.ContactName,c.Phone,p.ProductName,p.UnitsInStock,p.UnitPrice as 'Birim Fiyat',od.Quantity,od.UnitPrice as 'Sat�� Fiyat',ca.CategoryName
from Employees as e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join Customers c on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Categories ca on ca.CategoryID=p.CategoryID

--View kullan�m�
select FirstName,LastName from SatisRaporu
----------------------------------------------------------------------------------------

create view Kategoriler
as
	select CategoryName,Description from Categories

--View kullan�m�

select * from Kategoriler

insert into Categories values ('Yiyecek','s�cak ve so�uk yiyecekler',null)

insert into Kategoriler
values ('��ecekler','alkoll� ve alkols�z i�ecekler')

--Alter

alter view Kategoriler
as
	select CategoryID as 'Kategori Id', CategoryName as 'Kategori Ad�', Description as 'A��klama' from Categories

select * from Kategoriler

--Drop
drop view Kategoriler

----------------------------------------------------------------------------------------



