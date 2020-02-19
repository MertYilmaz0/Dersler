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
--yeni bir kullanýcý ekleyin

insert into Users values('bilal','1234')
insert into Users values('mert','4321')

--eklenen kullanýcýya ait kullanýcý detayý ekleyin.

select * from Users
select * from UserDetails

insert into UserDetails values(7,'Bilal','Kýrkgül',null,null,null,null,null)
insert into UserDetails (UserDetailID,FirstName,LastName) values (8,'Mert','Yýlmaz')

-------------------------------------
--Update

update UserDetails set Email='mert.yilmaz@gmail.com' where UserDetailID=8


--Delete
delete from UserDetails where UserDetailID=8
---------------------------------------------------------

--10 users oluþturun
--10 adet userýn detaylarý tam olacak þekilde doldurulsun.
--Message tablosunda toplam 5 mesaj girilsin ve bütün kolon doldurulsun.
--Photos tablosuna 10 kayýt girilsin bütün alanlar doldurulsun.
--PhotoComment 5 kayýt girilsin bütün alanlar doldurulsun.
--WallNotes'a 15 kayýt girilsin bütün alanlar doldurulsun.
--WallnotesCommet 20 girilsin bütün alanlar doldurulsun.

--girilen kayýtlarla beraber  

--Where - 3 sorgu

--Aggregate Functions - 2 sorgu

--Group by - 3 sorgu 

--Order by - 5 sorgu

--Like - 5 sorgu

--Yapmadan gelen tatlý ile gelsin!!
--------------------------------------------------------------------



