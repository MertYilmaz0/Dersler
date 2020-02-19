--dilerseniz a�a��daki kod ile beraber farkl� veritaban� i�erisinden farkl� verileri sorgulayabilirsiniz..
use Northwind--use anahtar kelimesi sorgulama i�lemi i�in veritaban� se�memizi sa�lar.

select * from Products-- * ifadesinden sonra Products tablosuda ne kadar kolon varsa hepsini listeler.

--�al��anlar tablosundan �al��anlara ait, ad, soyad, g�rev ve do�um tarihi bilgilerini listeleyin.

select FirstName,LastName,Title,BirthDate from Employees


select 
FirstName as 'Ad',
LastName as 'Soyad', 
Title as 'G�rev', 
BirthDate as 'Do�um Tarihi' 
from Employees

---------------------------------------------------

--�al��anlar tablosundan firstname ve lastname kolonlar�n� birle�tirerek listeleyin.

select (FirstName+' '+LastName) as 'Ad Soyad', Title as 'G�rev' from Employees -- e�er metinsel bir verinin yan�nda + simgesini kullan�l�rsa birle�tirme i�lemi yapar, say�sal bir verinin yan�nda kullan�l�rsa toplama i�lemi yapar.

select FirstName+' '+LastName from Employees

--�al��anlar�n �ehirlerini ad soyad ile beraber listeleyin.
select City as '�ehir', (FirstName+' '+LastName) as 'Ad Soyad' from Employees

select City as '�ehir' from Employees -- tekrar eden �ehirleri getirir.

--�al��anlar�mda ka� farkl� �ehir vard�r?

select distinct City from Employees -- distinct komutu farkl� �ehirleri getirir.