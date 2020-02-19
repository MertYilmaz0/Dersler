--dilerseniz aþaðýdaki kod ile beraber farklý veritabaný içerisinden farklý verileri sorgulayabilirsiniz..
use Northwind--use anahtar kelimesi sorgulama iþlemi için veritabaný seçmemizi saðlar.

select * from Products-- * ifadesinden sonra Products tablosuda ne kadar kolon varsa hepsini listeler.

--Çalýþanlar tablosundan çalýþanlara ait, ad, soyad, görev ve doðum tarihi bilgilerini listeleyin.

select FirstName,LastName,Title,BirthDate from Employees


select 
FirstName as 'Ad',
LastName as 'Soyad', 
Title as 'Görev', 
BirthDate as 'Doðum Tarihi' 
from Employees

---------------------------------------------------

--Çalýþanlar tablosundan firstname ve lastname kolonlarýný birleþtirerek listeleyin.

select (FirstName+' '+LastName) as 'Ad Soyad', Title as 'Görev' from Employees -- eðer metinsel bir verinin yanýnda + simgesini kullanýlýrsa birleþtirme iþlemi yapar, sayýsal bir verinin yanýnda kullanýlýrsa toplama iþlemi yapar.

select FirstName+' '+LastName from Employees

--çalýþanlarýn þehirlerini ad soyad ile beraber listeleyin.
select City as 'Þehir', (FirstName+' '+LastName) as 'Ad Soyad' from Employees

select City as 'Þehir' from Employees -- tekrar eden þehirleri getirir.

--Çalýþanlarýmda kaç farklý þehir vardýr?

select distinct City from Employees -- distinct komutu farklý þehirleri getirir.