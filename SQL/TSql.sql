--yorum sat�r�.

/*
buras� da �ok sat�rl� yorum alan�.
diledi�iniz kadar yorum yazabilirsiniz.
buraya yazm�� oldu�unuz kodlar arka tarafta derlenmez.

*/

--T-Sql de sorgulamalar i�erisinde b�y�k k���k harf duyarl�l��� bulunmamaktad�r.

--DML (Data Manupulation Language) 
	--Select
	--Insert
	--Update
	--Delete

select 2
select 5
select 10
--------------------------------------------------------------------------
--result penceresini kapatmak i�in Ctrl+r tu� kombinasyonunu kullanabilirsiniz.

select UserName,Password from Users

select FirstName,LastName from UserDetails

select * from UserDetails -- e�er select komutundan sonra * kullan�rsan�z o tablodaki b�t�n s�tunlar� size teslim eder.

select * from Messages

select * from Photos
select * from PhotoComments
-------------------------------

select 5 as 'Say�'
select 5 as 'Say� 1', 10 as 'Say� 2', 15 as 'Say� 3' -- veriden sonra tan�mlam�� oldu�unuz as ifadesi o verinin ba�l� bulundu�unun kolonun ismini temsil eder.
-- '' char veri tipi tan�mlamak istenildi�inde kullan�l�r.

select 'Bilge Adam' as '�irket Ad�'
------------------------------------------------

select FirstName as 'Ad', LastName as 'Soyad' from UserDetails

select FirstName as Ad, LastName as Soyad from UserDetails-- '' kullanmadan da ayn� sonucu al�rs�n�z.

select FirstName  Ad, LastName Soyad from UserDetails -- as kullanmadan da ayn� sonucu al�rs�n�z.
-------------------------------------------------