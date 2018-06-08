if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spBillInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spBillInsert
GO

CREATE PROCEDURE [dbo].[spBillInsert]

@action int = null,
@id int = null,
@billNumber varchar(30) = null,
@billDate datetime = null,
@storeID int = null,
@billCategoryID int = null,
@billPurposeID int = null,
@totalSum money = null,
@totalPdv money = null,
@description varchar(500) = null,
@statusId int = null,
@headid int = null,
@articl varchar(100) = null,
@quantity money = null,
@uomId int = null,
@sum money = null,
@pdv money = null

as

If @action = 1 begin  --insert glave
	insert into billHead (billnumber, billDate, storeID, BillCategoryID, BillPurposeID, Description, StatusID)
	values (@billNumber,@billDate,@storeID,@billCategoryID,@billPurposeID,@description, @statusId)
end


if @action = 2 begin --update glave
	
	update BillHead set
	BillNumber = @billNumber,
	BillDate = @billDate,
	StoreID = @storeID,
	BillCategoryID = @billCategoryID,
	BillPurposeID = @billPurposeID,
	TotalSum = @totalSum,
	TotalPDV = @totalPdv,
	Description = @description,
	StatusID = @statusId
	where id = @id
	
end

if @action = 3 begin --update stavke
	update BillBody set
	ArticlName = @articl,
	Quantity = @quantity,
	UnitOfMeasureID = @uomId,
	Sum = @sum,
	Pdv = @pdv,
	Description = @description
	where id = @id
end

if @action = 4 begin --delete stavke
	delete from BillBody 
	where id = @id
end

if @action = 5 begin
	Insert into BillBody (billhead, articlname, quantity, unitofmeasureid, sum, pdv, description) 
	values ( @headId, @articl, @quantity, @uomId, @sum, @pdv, @description)
	
	
	
end
return