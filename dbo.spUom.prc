if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spUom]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spUom
GO

CREATE PROCEDURE [dbo].[spUom]

@action int = null,
@id int = null,
@name varchar(50)= null,
@description varchar(500)= null,
@statusid int = null

as

if @action = 1 begin --select all
	
	select u.name as Naziv, description as Opis, s.Name as Status 
	from UnitOfMeasure u
	left join Status s on u.StatusID = s.id
end

if @action = 11 begin --select on id
	
	select u.name as Naziv, description as Opis, s.Name as Status, u.id, s.id
	from UnitOfMeasure u
	left join Status s on u.StatusID = s.id
	where u.id = @id
end

if @action = 2 begin --insert
	
	insert into UnitOfMeasure(Name, Description, StatusID)
	values (@name, @description, @statusid)
end

if @action = 3 begin --update

	update UnitOfMeasure set
	Name = @name,
	Description = @description,
	StatusID = @statusid
	where id = @id
end

if @action = 4 begin --delete
	
	delete from UnitOfMeasure where id = @id
end