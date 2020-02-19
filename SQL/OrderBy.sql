--Order by

/*
	Order by komutu sorgu sonu�lar�n� s�ralamak i�in kullan�lan komuttur.
*/

--�r�nleri isimlerine g�re (A'dan Z'ye) s�ralay�n�z. 

select * from Products order by ProductName asc  -- ascending azdan �ok'a do�ru s�ralar.

select * from Products order by ProductName desc -- descending �ok'tan aza do�ru s�ralar.

--e�er order by sonras�nda asc veya desc komutlar�n� belirtmezeniz varsay�lan olarak artan s�ralama (asc) ger�ekle�tiri.

---------------------------------------------------------------------------------

select ProductName,UnitPrice,UnitsInStock from Products order by 3 desc -- alternatif olarak sorgudan d�nen kolon s�ra numaras�na g�re de s�ralama i�lemi ger�ekle�tirebilirsiniz (3. s�rada UnitsInStock kolonu bulunmaktad�r.)

--01.01.1996 ile 31.12.1996 tarihleri aras�ndaki sipari�lerin sipari�ID, sipari� tarihi, �ehir, ve �lke bilgilerini tarih kolonuna g�re �oktan aza do�ru s�ralay�n�z.

--I.Yol
select OrderID,OrderDate,ShipCity,ShipCountry from Orders 
where OrderDate>='01.01.1996' and OrderDate<='12.31.1996' 
order by OrderDate desc

--II.YOL
select OrderID,OrderDate,ShipCity,ShipCountry from Orders 
where YEAR(OrderDate)=1996 
order by OrderDate desc

---------------------------------------------------------------------------------------------

--�al��anlar�n isimlerini, soyisimlerini ve ya�lar�n� listeleyin. Ya�lar�n� azdan �ok'a do�ru listeleyin.
select FirstName,LastName, 
YEAR(GETDATE())-YEAR(Birthdate) as 'Ya�' 
from Employees 
order by Ya� desc

------------------------------------------------------------

--Janet ile Robert aras�nda olan isimleri azdan �ok'a do�ru s�ralay�n�z.

select FirstName,LastName from Employees
where FirstName between 'janet' and 'robert'
order by 1

-------------------------------------------------------------

--BONUS :)

--Japonca konu�an personelim kimdir?
select * from Employees where Notes like '%japan%'
-------------------------------------------------------------