--Aggregate Functions (Toplam fonksiyonlar, gruplama fonksiyonlar�)

/*
	Aggregate fonksiyonlarb select ifadesiyle beraber kullan�lan geriye tek sat�r, tek s�tun sonu� d�nd�ren fonksiyonlard�r.

	1- Count() => toplam sat�r adedini sayan fonksiyondur.
	2- Sum()=> Toplama i�lemi yapar.
	3- AVG()=> Ortalama al�r.
	4- MIN()=> minimum de�eri verir.
	5- MAX()=> maksimum de�eri verir.
*/

--COUNT()
select * from Products

--employee tablosunda toplam ka� kay�t vard�r?

select COUNT(*) as 'Toplam �al��an Say�s�' from Employees

select COUNT(EmployeeID) as '�al��an Say�s�' from Employees

--�al��anlar�n  �ehir say�lar�n� listeleyin.

select COUNT(City) from Employees--tan�ml� olan �ehirlerin say�s�n� verir.

select COUNT(distinct City) from Employees--farkl� olan �ehirlerin say�s�n� verir.
--------------------------------------------------------------------------------------------

--SUM()
select * from Products

select SUM(ProductID) as 'Toplam Sonu�' from Products

--�al��anlar�n ya�lar�n�n toplam�n� bulunuz.

select FirstName, LastName, BirthDate from Employees 

select YEAR(BirthDate) from Employees

--I. Yol
select SUM(YEAR(getdate())-YEAR(BirthDate)) as 'Ya�lar�n Toplam�' from Employees

--II.Yol
select SUM(Datediff(YY,Birthdate,getdate())) from Employees

--Datediff()=> iki tarih aras�ndaki fark� verir.

----------------------------------------------------------------------------------------------

--AVG()

--�r�nlerin ortalama fiyat� nedir?

select AVG(UnitPrice) as OrtalamaFiyat from Products

--�al��anlar�n ya�lar�n�n ortalamas� nedir?
select AVG(DATEDIFF(yy,BirthDate,GETDATE())) as 'Ya�lar�n Ortalamas�' from Employees

--------------------------------------------------------------------------------------------

--Min()

--en d���k fiyatl� olan �r�n�n fiyat�n� getirin
select MIN(UnitPrice) as 'Minimum Fiyat' from Products
--en y�ksek fiyatl� olan �r�n�n fiyat�n� getirin.
select MAX(UnitPrice) as 'Maksimum Fiyat' from Products

---------------------------------------------------------------------------------------------

--�uana kadarki toplam ciroyu bulunuz.

--emirhan 56500 - 51317
--yavuz selim - 14377
-- ahmet ayzad - 1354458.59 - 1265793.03
--g�lsen       - 1354458.59
--havva        - 1354458.59
--esat			- 1265793.03

--------------------------------------------------------------------------

--�uana kadarki toplam ciroyu hesaplay�n
select SUM(UnitPrice*Quantity*(1-discount)) as 'Toplam Gelir' from [Order Details]

-------------------------------------------------------------------------



