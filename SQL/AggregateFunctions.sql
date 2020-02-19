--Aggregate Functions (Toplam fonksiyonlar, gruplama fonksiyonlarý)

/*
	Aggregate fonksiyonlarb select ifadesiyle beraber kullanýlan geriye tek satýr, tek sütun sonuç döndüren fonksiyonlardýr.

	1- Count() => toplam satýr adedini sayan fonksiyondur.
	2- Sum()=> Toplama iþlemi yapar.
	3- AVG()=> Ortalama alýr.
	4- MIN()=> minimum deðeri verir.
	5- MAX()=> maksimum deðeri verir.
*/

--COUNT()
select * from Products

--employee tablosunda toplam kaç kayýt vardýr?

select COUNT(*) as 'Toplam Çalýþan Sayýsý' from Employees

select COUNT(EmployeeID) as 'Çalýþan Sayýsý' from Employees

--Çalýþanlarýn  þehir sayýlarýný listeleyin.

select COUNT(City) from Employees--tanýmlý olan þehirlerin sayýsýný verir.

select COUNT(distinct City) from Employees--farklý olan þehirlerin sayýsýný verir.
--------------------------------------------------------------------------------------------

--SUM()
select * from Products

select SUM(ProductID) as 'Toplam Sonuç' from Products

--Çalýþanlarýn yaþlarýnýn toplamýný bulunuz.

select FirstName, LastName, BirthDate from Employees 

select YEAR(BirthDate) from Employees

--I. Yol
select SUM(YEAR(getdate())-YEAR(BirthDate)) as 'Yaþlarýn Toplamý' from Employees

--II.Yol
select SUM(Datediff(YY,Birthdate,getdate())) from Employees

--Datediff()=> iki tarih arasýndaki farký verir.

----------------------------------------------------------------------------------------------

--AVG()

--ürünlerin ortalama fiyatý nedir?

select AVG(UnitPrice) as OrtalamaFiyat from Products

--Çalýþanlarýn yaþlarýnýn ortalamasý nedir?
select AVG(DATEDIFF(yy,BirthDate,GETDATE())) as 'Yaþlarýn Ortalamasý' from Employees

--------------------------------------------------------------------------------------------

--Min()

--en düþük fiyatlý olan ürünün fiyatýný getirin
select MIN(UnitPrice) as 'Minimum Fiyat' from Products
--en yüksek fiyatlý olan ürünün fiyatýný getirin.
select MAX(UnitPrice) as 'Maksimum Fiyat' from Products

---------------------------------------------------------------------------------------------

--Þuana kadarki toplam ciroyu bulunuz.

--emirhan 56500 - 51317
--yavuz selim - 14377
-- ahmet ayzad - 1354458.59 - 1265793.03
--gülsen       - 1354458.59
--havva        - 1354458.59
--esat			- 1265793.03

--------------------------------------------------------------------------

--Þuana kadarki toplam ciroyu hesaplayýn
select SUM(UnitPrice*Quantity*(1-discount)) as 'Toplam Gelir' from [Order Details]

-------------------------------------------------------------------------



