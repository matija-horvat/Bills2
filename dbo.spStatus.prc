if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spStatus]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spStatus
GO

CREATE PROCEDURE [dbo].[spStatus]

@action int = null,
@id int = null,
@name varchar(50)= null,
@foreColorGrid varchar(30)= null,
@backColorGrid varchar(30)= null

as

if @action = 1 begin --select all
	
	select Name as Naziv, ForeColorGrid as [Boja fonta], BackColorGrid as [Boja grida], id 
	from Status 
	
end

if @action = 11 begin --select on id
	
	select Name as Naziv, ForeColorGrid as [Boja fonta], BackColorGrid as [Boja grida], id 
	from Status 
	where id = @id
end

if @action = 2 begin --insert
	
	insert into Status(Name, ForeColorGrid, BackColorGrid)
	values (@name, @foreColorGrid, @backColorGrid)
end

if @action = 3 begin --update

	update Status set
	Name = @name,
	ForeColorGrid = @foreColorGrid,
	BackColorGrid = @backColorGrid
	where id = @id
end

if @action = 4 begin --delete
	
	delete from Status where id = @id
end