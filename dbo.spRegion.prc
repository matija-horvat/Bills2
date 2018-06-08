if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRegion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spRegion
GO

CREATE PROCEDURE [dbo].[spRegion]

@action int = null,
@id int = null,
@name varchar(50)= null,
@countryId int = null

as

if @action = 1 begin --select all
	
	select r.Name as Naziv, c.Name as [Država], r.id 
	from Region r
	left join Country c on r.CountryID = c.id
	
end

if @action = 11 begin --select on id
	
	select r.Name as Naziv, c.Name as [Država], r.id, c.id
	from Region r
	left join Country c on r.CountryID = c.id
	where r.id = @id
end

if @action = 2 begin --insert
	
	insert into Region(Name, CountryID)
	values (@name, @countryId)
end

if @action = 3 begin --update

	update Region set
	Name = @name,
	CountryID = @countryId
	where id = @id
end

if @action = 4 begin --delete
	
	delete from Region where id = @id
end