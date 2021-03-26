CREATE PROCEDURE sproc_tblStock_Update
--create the paramters for the stored procedure 

@PCIDNO int,
@PCName varchar (50),
@CPU nchar (10),
@GPU nchar (10),
@BuildDate date,
@StockAvaliable int,
@StorageType int

As
--update the record as specified by @StockNo value
update tblStock
set PCName = @PCName,
CPU = @CPU,
GPU = @GPU,
BuildDate = @BuildDate,
StockAvaliable = @StockAvaliable,
StorageType = @StorageType

where PCIDNo = @PCIDNO