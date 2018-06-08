if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spCountry]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spCountry
GO

CREATE PROCEDURE [dbo].[spCountry]

@action int = null,
@id int = null,
@name varchar(50)= null

as

if @action = 1 begin --select all
	
	select Name as Naziv, id 
	from Country 
	
end

if @action = 11 begin --select on id
	
	select Name as Naziv, id 
	from Country  
	where id = @id
end

if @action = 2 begin --insert
	
	insert into Country(Name)
	values (@name)
end

if @action = 3 begin --update

	update Country set
	Name = @name
	where id = @id
end

if @action = 4 begin --delete
	
	delete from Country where id = @id
end