if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spIncome
GO

CREATE PROCEDURE [dbo].[spIncome]

@action int = null,
@id int = null,
@date datetime = null,
@incomePay int = null,
@incomeCat int = null,
@amount money = null,
@name varchar(50)= null,
@description varchar(200) = null,
@statusId int = null

as

if @action = 1 begin --select all
	
	select i.IncomeDate as [Datum], ic.name as [Vrsta prihoda], ip.Name as [Uplatitelj], i.Amount as [Iznos(kn)], i.Description as Opis,  i.id
	from Income i 
	left join IncomeCategory ic on i.IncomeCategoryID = ic.id
	left join IncomePaymen ip on i.IncomePaymenID = ip.id
	left join status s on ic.statusid = s.id 
	order by i.IncomeDate
	
	
end

if @action = 11 begin --select on id GRID
	
	select i.IncomeDate as [Datum], i.IncomeCategoryID, i.IncomePaymenID, i.Amount, i.Description, i.id
	from Income i 
	left join IncomeCategory ic on i.IncomeCategoryID = ic.id
	left join IncomePaymen ip on i.IncomePaymenID = ip.id
	left join status s on ic.statusid = s.id 
	where i.id = @id
end

if @action = 2 begin --insert
	
	insert into Income(IncomeDate,IncomeCategoryID,IncomePaymenID, Description, Amount)
	values (@date, @incomeCat, @incomePay, @description, @amount)
end

if @action = 3 begin --update

	update Income set
	IncomeDate = @date,
	IncomeCategoryID = @incomeCat,
	IncomePaymenID = @incomePay,
	Amount = @amount,
	Description = @description
	where id = @id
end

--if @action = 4 begin --delete
	
--	--update Income set
--	--statusid = (select id from Status where Name like 'Active')
--	--where id = @id
--end
