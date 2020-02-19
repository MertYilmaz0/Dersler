--yorum satýrý.

/*
burasý da çok satýrlý yorum alaný.
dilediðiniz kadar yorum yazabilirsiniz.
buraya yazmýþ olduðunuz kodlar arka tarafta derlenmez.

*/

--T-Sql de sorgulamalar içerisinde büyük küçük harf duyarlýlýðý bulunmamaktadýr.

--DML (Data Manupulation Language) 
	--Select
	--Insert
	--Update
	--Delete

select 2
select 5
select 10
--------------------------------------------------------------------------
--result penceresini kapatmak için Ctrl+r tuþ kombinasyonunu kullanabilirsiniz.

select UserName,Password from Users

select FirstName,LastName from UserDetails

select * from UserDetails -- eðer select komutundan sonra * kullanýrsanýz o tablodaki bütün sütunlarý size teslim eder.

select * from Messages

select * from Photos
select * from PhotoComments
-------------------------------

select 5 as 'Sayý'
select 5 as 'Sayý 1', 10 as 'Sayý 2', 15 as 'Sayý 3' -- veriden sonra tanýmlamýþ olduðunuz as ifadesi o verinin baðlý bulunduðunun kolonun ismini temsil eder.
-- '' char veri tipi tanýmlamak istenildiðinde kullanýlýr.

select 'Bilge Adam' as 'Þirket Adý'
------------------------------------------------

select FirstName as 'Ad', LastName as 'Soyad' from UserDetails

select FirstName as Ad, LastName as Soyad from UserDetails-- '' kullanmadan da ayný sonucu alýrsýnýz.

select FirstName  Ad, LastName Soyad from UserDetails -- as kullanmadan da ayný sonucu alýrsýnýz.
-------------------------------------------------