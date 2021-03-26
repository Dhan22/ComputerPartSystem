CREATE PROCEDURE sproc_tblStock_Insert
--create parameters for the stored procedure

@PCName varchar (50),
@RAM int,
@GPU nchar (10),
@CPU nchar (10),
@BuildDate date,
@StockAvaliable int,
@StorageType int

AS

--insert the new record 

INSERT INTO tblStock (PCName, RAM, CPU, GPU, BuildDate, StockAvaliable, StorageType)
values (PCName, RAM, CPU, BuildDate, GPU, StockAvaliable, StorageType)

--return the primary ket value to the new record 
return @@Identity 
