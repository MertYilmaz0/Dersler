--Group by

/*
	Group by komutu tablodaki ortak verilerin gruplanarak d�nmesini sa�lar. Group by kullan�m�ndan �nce gruplanacak olan alanlar belirlenip daha sonra o alana g�re bir select i�lemi yap�l�r.
*/

--Hangi kategoride ka� adet �r�n bulunmaktad�r?
select 
CategoryID,COUNT(CategoryID) as '�r�n Adet' 
from Products group by CategoryID

--�lkelere g�re �al��an say�s�n� listeleyin.
select 
country, COUNT(Country) as '�lke' 
from Employees 
group by Country
----------------------------------------------

--Stokta hangi kategoriden toplam ne kadarl�k �r�n vard�r?
select CategoryID,SUM(UnitPrice*UnitsInStock) as 'Toplam Fiyat' 
from Products 
group by CategoryID
------------------------------------------------------------

--Hangi personel hangi m��teriye ka� adet sat�� yapm��t�r?

select EmployeeID,CustomerID,COUNT(OrderID) as 'Sat�� Adet' from Orders group by EmployeeID,CustomerID

-------------------------------------------------------------
