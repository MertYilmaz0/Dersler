
--Like Komutu

--ürünlerimin ürün adýnýn herhangi bir yerinde i harfi geçen ürünleri listeleyin.

select * from Products where ProductName like '%i%'--% iþareti hepsini temsil eder eðer 2 % iþareti ve arasýnda kelime/karakter varsa öncesi ve sonrasý önemli deðil içinde belirtilen kelime/karakter geçenleri getirir.

--Çalýþanlar tablosundan a harfi ile baþlayan çalýþanlarý listeleyin.
select * from Employees where FirstName like 'a%'

--3. karakteri a olan ürünleri listeleyin
select * from Products where ProductName like '__a%'

--3. karakteri a olmayan ürünleri listeleyinn.

--I.Yol
select * from Products where ProductName not like '__a%'

--II.Yol

select * from Products where ProductName like '__[^a]%'

--3. karakteri a olmayan ve 2. karakteri c olan ürünleri listeleyin.
select * from Products where ProductName like '_c[^a]%'

select * from Products where ProductName not like '__a%' and ProductName like '_c%'

