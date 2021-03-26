CREATE PROCEDURE [dbo].sproc_tblStock_Delete

--this stored procedure is situated in the data layer

--this stored procedure is used to delete a single record in the table tblStock
--it accpects a single parmater @StockNo and returns no value

--delcare hte parameter 
@PCIDNo int

As

delete from tblStock where PCIDNo = @PCIDNO; 


