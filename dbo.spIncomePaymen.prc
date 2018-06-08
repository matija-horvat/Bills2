if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spIncomePaymen]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spIncomePaymen
GO

CREATE PROCEDURE [dbo].[spIncomePaymen]

@action int = null,
@id int = null,
@name varchar(50)= null,
@description varchar(200) = null,
@statusId int = null

as

if @action = 1 begin --select all
	
	select b.Name as Naziv,b.Description as Opis, st.Name as Status,  b.id, st.id 
	from IncomePaymen b
	left join Status st on b.StatusID = st.id
	
	
end

if @action = 11 begin --select on id
	
	select b.Name as Naziv,b.Description as Opis,  b.id, st.id
	from IncomePaymen b
	left join Status st on b.StatusID = st.id
	where b.id = @id
end

if @action = 2 begin --insert
	
	insert into IncomePaymen(Name, Description, StatusID)
	values (@name, @description, @statusId)
end

if @action = 3 begin --update

	update IncomePaymen set
	Name = @name,
	Description = @description,
	StatusID = @statusId
	where id = @id
end

if @action = 4 begin --delete
	
	update IncomePaymen set
	statusid = (select id from Status where Name like 'Inactive')
	where id = @id
end