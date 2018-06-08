if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spCity]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spCity
GO

CREATE PROCEDURE [dbo].[spCity]

@action int = null,
@id int = null,
@name varchar(50)= null,
@ponumber varchar(15) = null,
@regionId int = null

as

if @action = 1 begin --select all
	
	select c.Name as Naziv,ponumber as [Poštanski broj], r.Name as [Županija], c.id 
	from City c
	left join Region r on c.RegionID = r.id
	
end

if @action = 11 begin --select on id
	
	select c.Name as Naziv, POnumber as [Poštanski broj], r.Name as [Županija], c.id, r.id
	from City c
	left join Region r on c.RegionID = r.id
	where c.id = @id
end

if @action = 2 begin --insert
	
	insert into City(Name,POnumber, RegionID)
	values (@name, @ponumber, @regionId)
end

if @action = 3 begin --update

	update City set
	Name = @name,
	RegionID = @regionId,
	POnumber = @ponumber
	where id = @id
end

if @action = 4 begin --delete
	
	delete from City where id = @id
end