--DML
--select <kolonAdi>,<kolonAdi> from <TabloAdi>
--insert
--update
--delete

--Where

--Aggregate Functions

--Group by

--Order by

--Like
--------------------------------------
use FacebookDB

select * from Users
--Insert
--yeni bir kullan�c� ekleyin

insert into Users values('bilal','1234')
insert into Users values('mert','4321')

--eklenen kullan�c�ya ait kullan�c� detay� ekleyin.

select * from Users
select * from UserDetails

insert into UserDetails values(7,'Bilal','K�rkg�l',null,null,null,null,null)
insert into UserDetails (UserDetailID,FirstName,LastName) values (8,'Mert','Y�lmaz')

-------------------------------------
--Update

update UserDetails set Email='mert.yilmaz@gmail.com' where UserDetailID=8


--Delete
delete from UserDetails where UserDetailID=8
---------------------------------------------------------

--10 users olu�turun
--10 adet user�n detaylar� tam olacak �ekilde doldurulsun.
--Message tablosunda toplam 5 mesaj girilsin ve b�t�n kolon doldurulsun.
--Photos tablosuna 10 kay�t girilsin b�t�n alanlar doldurulsun.
--PhotoComment 5 kay�t girilsin b�t�n alanlar doldurulsun.
--WallNotes'a 15 kay�t girilsin b�t�n alanlar doldurulsun.
--WallnotesCommet 20 girilsin b�t�n alanlar doldurulsun.

--girilen kay�tlarla beraber  

--Where - 3 sorgu

--Aggregate Functions - 2 sorgu

--Group by - 3 sorgu 

--Order by - 5 sorgu

--Like - 5 sorgu

--Yapmadan gelen tatl� ile gelsin!!
--------------------------------------------------------------------



