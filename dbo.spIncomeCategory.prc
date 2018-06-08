if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spIncomeCategory]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spIncomeCategory
GO

CREATE PROCEDURE [dbo].[spIncomeCategory]

@action int = null,
@id int = null,
@name varchar(50)= null,
@description varchar(200) = null,
@statusId int = null

as

if @action = 1 begin --select all
	
	select ic.name as [Vrsta prihoda], case when ic.Description is null then 'N/A' else ic.Description end as Opis, s.name as Status, ic.id, s.id 
	from IncomeCategory ic 
	left join status s on ic.statusid = s.id 
	
	
	
end

if @action = 11 begin --select on id
	
	select b.Name as Naziv,case when b.Description is null then '' else b.Description end as Opis, b.id, st.id
	from IncomeCategory b
	left join Status st on b.StatusID = st.id
	where b.id = @id
end

if @action = 2 begin --insert
	
	insert into IncomeCategory(Name, Description, StatusID)
	values (@name, @description, @statusId)
end

if @action = 3 begin --update

	update IncomeCategory set
	Name = @name,
	Description = @description,
	StatusID = @statusId
	where id = @id
end

if @action = 4 begin --delete
	
	update IncomeCategory set
	statusid = (select id from Status where Name like 'Active')
	where id = @id
end