
--Like Komutu

--�r�nlerimin �r�n ad�n�n herhangi bir yerinde i harfi ge�en �r�nleri listeleyin.

select * from Products where ProductName like '%i%'--% i�areti hepsini temsil eder e�er 2 % i�areti ve aras�nda kelime/karakter varsa �ncesi ve sonras� �nemli de�il i�inde belirtilen kelime/karakter ge�enleri getirir.

--�al��anlar tablosundan a harfi ile ba�layan �al��anlar� listeleyin.
select * from Employees where FirstName like 'a%'

--3. karakteri a olan �r�nleri listeleyin
select * from Products where ProductName like '__a%'

--3. karakteri a olmayan �r�nleri listeleyinn.

--I.Yol
select * from Products where ProductName not like '__a%'

--II.Yol

select * from Products where ProductName like '__[^a]%'

--3. karakteri a olmayan ve 2. karakteri c olan �r�nleri listeleyin.
select * from Products where ProductName like '_c[^a]%'

select * from Products where ProductName not like '__a%' and ProductName like '_c%'

