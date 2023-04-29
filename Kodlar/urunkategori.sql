create procedure urunkategori
as

select TBLKATEGORI.AD,COUNT(*)  from  TBLURUN 
Inner Join TBLKATEGORI 
ON TBLKATEGORI.ID=TBLURUN.KATEGORI 
group by TBLKATEGORI.AD 
