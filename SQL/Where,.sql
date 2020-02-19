

--Where komutu: Filitreleme iþlemlerinde kullanýlýr.

--ürünler tablosundan sadece product id'si 1 olan ürünü listeleyin.

select * from Products where ProductID=1

--adý janet olan çalýþanýn bilgilerini getirin.

select * from Employees where FirstName='janet'

--ürün fiyatý 30'dan büyük olanlarý listeleyin.

select * from Products where UnitPrice>30

--ürün fiyatý 30'dan küçük olanlarý listeleyin.
select * from Products where UnitPrice<30

--Fiyatý 10 ile 40 arasýnda olan ürünleri listeleyin.

--I.Yol
select * from Products where UnitPrice>10 and UnitPrice<40

--II.Yol

select * from Products where UnitPrice between 10 and 40

/*
  = atama operatörü
  > büyüktür
  < küçüktür
  >= büyük eþittir
  <= küçük eþittir,
  !  deðildir,
  <> deðildir.

*/

--ürün fiyatý 10 olmayan ürünleri listeleyin.
select * from Products where UnitPrice!=10

select * from Products where UnitPrice<>10

