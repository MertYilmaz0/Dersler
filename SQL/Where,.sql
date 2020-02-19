

--Where komutu: Filitreleme i�lemlerinde kullan�l�r.

--�r�nler tablosundan sadece product id'si 1 olan �r�n� listeleyin.

select * from Products where ProductID=1

--ad� janet olan �al��an�n bilgilerini getirin.

select * from Employees where FirstName='janet'

--�r�n fiyat� 30'dan b�y�k olanlar� listeleyin.

select * from Products where UnitPrice>30

--�r�n fiyat� 30'dan k���k olanlar� listeleyin.
select * from Products where UnitPrice<30

--Fiyat� 10 ile 40 aras�nda olan �r�nleri listeleyin.

--I.Yol
select * from Products where UnitPrice>10 and UnitPrice<40

--II.Yol

select * from Products where UnitPrice between 10 and 40

/*
  = atama operat�r�
  > b�y�kt�r
  < k���kt�r
  >= b�y�k e�ittir
  <= k���k e�ittir,
  !  de�ildir,
  <> de�ildir.

*/

--�r�n fiyat� 10 olmayan �r�nleri listeleyin.
select * from Products where UnitPrice!=10

select * from Products where UnitPrice<>10

