select * from Users
select * from UserDetails
insert into Users values ('senis','2752')

-- yanlışlıkla iki kere Execute gerçekleştirdiğim için şimdi birini çıkartacağım.

delete from Users where UserID=10

insert into Users values ('gülnaz','6782'),('ali','3345')

insert into Users values ('hüseyin','6743'),('jale','9883'),('emre','7678'),('merve','1090'),('fatih','0908'),('kübra','1879'),('semih','6673')

select * from UserDetails
select * from Users

insert into UserDetails values (8,'Senin','Birsen','senisbirsen@gmail.com','11-11-1978','Kartal','Aşçı','Erkek')

insert into UserDetails values (9,'Gülnaz','Işık','gulnazisik@outlook.com','09-08-1980','Kadıköy','Öğretmen','Kadın')

insert into UserDetails values (11,'Ali','Şener','alisener@gmail.com','01-01-1991','Beylikdüzü','Şöför','Erkek')

insert into UserDetails values (12,'Hüseyin','Sarı','huseyinsari@gpbilisim.com','06-05-1984','Küçükyalı','Terzi','Erkek')

insert into UserDetails values (13,'Jale','Kahraman','jalekahraman@gmail.com','02-11-1990','Maltepe','Tercüman','Kadın')

insert into UserDetails values (14,'Emre','Küçük','emrekucuk@hotmail.com','12-10-1965','Bostancı','Polis','Erkek')

insert into UserDetails values (15,'Merve','Uzun','merveuzun@outlook.com','01-30-1974','Beşiktaş','Temizlikçi','Kadın')

insert into UserDetails values (16,'Fatih','Yeşil','fatihyesil@asdpazalama.com','08-27-1961','Maslak','Güvenlik','Erkek')

insert into UserDetails values (17,'Kübra','Egemen','kubraegemen@yahoo.com','01-12-1998','Beyoğlu','IT','Kadın')

insert into UserDetails	values (18,'Semih','Reis','semihreis@ibb.gov.tr','10-11-1978','Nişantaşı','Devlet Memuru','Erkek')

------------------------------------------------------------------------------
select * from Messages

select SenderId,ReceiverId,MessageBody from Messages

insert into Messages(SenderId,ReceiverId,MessageBody) values (12,2,'Selam dostum')

insert into Messages(SenderId,ReceiverId,MessageBody) values (2,12, 'Çok kötüyüm, çok hastayım')

insert into Messages(SenderId,ReceiverId,MessageBody) values (1,14,'Yarın kurs var mı?')

insert into Messages(SenderId,ReceiverId,MessageBody) values (14,1, 'Tabiki var sakın kaçırma!')

insert into Messages(SenderId,ReceiverId,MessageBody) values (19,17, 'Dün yemek çok kötüydü')

select * from Photos

insert into Photos values ('Fenerbahçe',9,'Selfie!',NULL)

insert into Photos values ('Küçükyalı',1,'Aile Yemeği',NULL)

insert into Photos values ('Nişantaşı',19,'Shopping time!',NULL)

insert into Photos values ('Maslak',16,'We have to do something...',NULL)

insert into Photos values ('Taksim',15,'Yine,yeni,yeniden',NULL)

insert into Photos values ('Kadıköy',11,'Parti zamanı',NULL)

insert into Photos values ('Berlin',6,'Tatil',NULL)

insert into Photos values ('Prag',4,'Sense of humor',NULL)

insert into Photos values ('New York',8,'Crazy times.',NULL)

insert into Photos values ('Wisconsin',7,'Love is love, baby you hurt me!',NULL)
-------------------------------------------------------


select * from PhotoComments

insert into PhotoComments values (1,2,'Çok çirkin çıkmışsın.',NULL)

insert into PhotoComments values (4,2,'Yine mi sen?',NULL)

insert into PhotoComments values (6,2,'hahaha',NULL)

insert into PhotoComments values (19,2,'çok iyi çımışsın',NULL)

insert into PhotoComments values (4,2,'teşekkürler',NULL)

--------------------------------------------------------

select * from WallNotes

insert into WallNotes values ('İyi bayramlar',1,NULL)

insert into WallNotes values ('Hayırlı işler',11,NULL)

insert into WallNotes values ('Mutlu Yıllar',8,NULL)

insert into WallNotes values ('Kayıtlarımız başlamıştır, DM',2,NULL)

insert into WallNotes values ('Acil AB+ kana ihtiyaç vardır.',13,NULL)

insert into WallNotes values ('İleri düzey ingilizce bilen bir kişi aranıyor.',7,NULL)

insert into WallNotes values ('Uçak kazasında 20 kişi ölmüş, ailelerine başsağlığı diliyorum.',12,NULL)

insert into WallNotes values ('İBB Fırtına uyarısı yaptı',18,NULL)

insert into WallNotes values ('Ödevlerle ilgili yarım lazım',16,NULL)

insert into WallNotes values ('Çok sıkıldım',4,NULL)

insert into WallNotes values ('Ufak bir mola',1,NULL)

insert into WallNotes values ('Günün önemi',2,NULL)

insert into WallNotes values ('13. doğum günü',13,NULL)

insert into WallNotes values ('We are going to play Apex Legends tonight!',18,NULL)

insert into WallNotes values ('Sinemaya gidiyorum.',7,NULL)
-----------------------------------------------------------------------------------------


select * from WallNoteComment

insert into WallNoteComment values (1,1,'iyi bayramlar',NULL)

insert into WallNoteComment values (1,2,'bol kazançlar',NULL)

insert into WallNoteComment values (2,2,'kolay gelsin',NULL)

insert into WallNoteComment values (11,2,'teşekkürler sizede',NULL)

insert into WallNoteComment values (2,8,'nice senelere',NULL)

insert into WallNoteComment values (9,4,'mesajımı yanıtlayın lütfen',NULL)

insert into WallNoteComment values (2,4,'kusura bakmayın görmemişim.',NULL)

insert into WallNoteComment values (9,4,'önemli değil.',NULL)

insert into WallNoteComment values (2,4,'bu dönemki kayıtlar yeterli katılım olmadığı için iptal edilmiştir.',NULL)

insert into WallNoteComment values (6,4,'fena saçmaladınız.',NULL)

insert into WallNoteComment values (12,7,'çok üzücü.',NULL)

insert into WallNoteComment values (19,7, ':(',NULL)

insert into WallNoteComment values (19,8, 'Kar geliyor galiba.',NULL)

insert into WallNoteComment values (18,8, 'evet',NULL)

insert into WallNoteComment values (7,8,' hayır, sadece yağmur yağacak.',NULL)

insert into WallNoteComment values (7,8, 'sıkı giyinin',NULL)

insert into WallNoteComment values (1,9,'nerede takıldın?',NULL)

insert into WallNoteComment values (19,9, 'hiçbir şey anlamadım ki...',NULL)

insert into WallNoteComment values (1,9,'mesaj olarak gönder bana bir bakayım.',NULL)

insert into WallNoteComment values (19,9,'tamam',NULL)
---------------------------------------------------------------------------------

select * from PhotoComments where PhotoId=1

select * from WallNoteComment where UserId=19

select * from UserDetails where Gender='erkek'

------------------------------------------------------------

select COUNT(UserDetailID) as 'Kullanıcılar' from UserDetails

select SUM(PhotoId) as 'PhotoID Toplamı' from PhotoComments
---------------------------------------------------------------------

--kim kime kaç mesaj atmış? (Umarım doğru yapmışımdır :D)

select SenderId,ReceiverId,COUNT(MessageBody) as 'Mesaj Adedi' from Messages group by SenderId,ReceiverId

--kim kime kaç kaç yorum yapmış?

select UserId,WallNoteId,COUNT(CommentBody) as 'Yorum Adedi' from WallNoteComment group by UserId,WallNoteId

-------------------------------------------------------------------------


--tüm kullanıcıların İş/Meslek lerini A dan Z ye sırala

select FirstName,Job from UserDetails order by Job asc

--yapılan tüm fotoğraf yorumlarını tersten sırala.

select comment from PhotoComments order by PhotoCommentID desc

------------------------------------------------------------------------------

--semihin yaptığı tüm fotoğraf yorumlarını getir.

select * from PhotoComments where UserId like '%19%'

--5 eksik var yarın tamamlanacak