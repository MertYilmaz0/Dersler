--Order by

/*
	Order by komutu sorgu sonuçlarını sıralamak için kullanılan komuttur.
*/

--ürünleri isimlerine göre (A'dan Z'ye) sıralayınız. 

select * from Products order by ProductName asc  -- ascending azdan çok'a doğru sıralar.

select * from Products order by ProductName desc -- descending çok'tan aza doğru sıralar.

--eğer order by sonrasında asc veya desc komutlarını belirtmezeniz varsayılan olarak artan sıralama (asc) gerçekleştiri.

---------------------------------------------------------------------------------

select ProductName,UnitPrice,UnitsInStock from Products order by 3 desc -- alternatif olarak sorgudan dönen kolon sıra numarasına göre de sıralama işlemi gerçekleştirebilirsiniz (3. sırada UnitsInStock kolonu bulunmaktadır.)

--01.01.1996 ile 31.12.1996 tarihleri arasındaki siparişlerin siparişID, sipariş tarihi, şehir, ve ülke bilgilerini tarih kolonuna göre çoktan aza doğru sıralayınız.

--I.Yol
select OrderID,OrderDate,ShipCity,ShipCountry from Orders 
where OrderDate>='01.01.1996' and OrderDate<='12.31.1996' 
order by OrderDate desc

--II.YOL
select OrderID,OrderDate,ShipCity,ShipCountry from Orders 
where YEAR(OrderDate)=1996 
order by OrderDate desc

---------------------------------------------------------------------------------------------

--Çalışanların isimlerini, soyisimlerini ve yaşlarını listeleyin. Yaşlarını azdan çok'a doğru listeleyin.
select FirstName,LastName, 
YEAR(GETDATE())-YEAR(Birthdate) as 'Yaş' 
from Employees 
order by Yaş desc

------------------------------------------------------------

--Janet ile Robert arasında olan isimleri azdan çok'a doğru sıralayınız.

select FirstName,LastName from Employees
where FirstName between 'janet' and 'robert'
order by 1

-------------------------------------------------------------

--BONUS :)

--Japonca konuşan personelim kimdir?
select * from Employees where Notes like '%japan%'
-------------------------------------------------------------