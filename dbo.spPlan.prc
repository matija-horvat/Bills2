if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spPlan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spPlan
GO

CREATE PROCEDURE [dbo].[spPlan]

@action int = null,
@id int = null,
@date datetime = null,
@incomePay int = null,
@incomeCat int = null,
@amount money = null,
@name varchar(50)= null,
@description varchar(200) = null,
@statusId int = null,
@planYear int = null,
@planMounth int = null,
@categoryID int = null,
@purposeID int = null

as

if @action = 1 begin --select GRID
	
	select p.PlanYear as [Planirana godina potrošnje], p.PlanMounth as [Planirani mjesec potrošnje]
	, bc.name as [Vrsta troška], bp.Name as [Namjena potrošnje], p.Amount as [Iznos(kn)], p.Description as Opis,  p.id
	from dbo.[Plan] p 
	left join BillCategory bc on p.BillCategoryID = bc.id
	left join BillPurpose bp on p.BillPurposeID = bp.id
	order by p.planyear, p.PlanMounth
	
	
end

if @action = 11 begin --select OBJECT
	
	select p.PlanYear, p.PlanMounth
	, p.BillCategoryID, p.BillPurposeID, p.Amount as [Iznos(kn)], p.Description as Opis,  p.id
	from dbo.[Plan] p  
	where p.id = @id
end

if @action = 2 begin --insert
	
	insert into dbo.[Plan](PlanDate,PlanYear, PlanMounth, BillCategoryID, BillPurposeID, Description, Amount)
	values (GETDATE(), @planYear, @planMounth, @categoryID, @purposeID, @description, @amount)
end

if @action = 3 begin --update

	update dbo.[Plan] set
	PlanDate = @date,
	PlanMounth = @planMounth,
	PlanYear = @planYear,
	BillCategoryID = @categoryID,
	BillPurposeID = @purposeID,
	Description = @description,
	Amount = @amount 
	where id = @id
end

if @action = 4 begin --delete
	
	delete from dbo.[Plan] where id = @id
end
