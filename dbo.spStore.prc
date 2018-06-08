if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spStore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spStore
GO

CREATE PROCEDURE [dbo].[spStore]

@action int = null,
@id int = null,
@name varchar(50)= null,
@adress varchar(100) = null,
@cityId int = null,
@phone varchar(20) = null,
@web varchar(100) = null,
@description varchar(200) = null,
@statusId int = null

as

if @action = 1 begin --select all
	
	select s.Name as Naziv,s.Adress as Adresa,c.Name as [Grad], 
	s.Web, s.PhoneNumber as Telefon, st.Name as Status,  s.id 
	from Store s
	left join City c on s.CityID = c.id
	left join Status st on s.StatusID = st.id
	
	
end

if @action = 11 begin --select on id
	
	select s.Name as Naziv, s.Adress as Adresa, c.Name as [Grad], 
	s.Web, s.PhoneNumber as Telefon, s.Description, st.Name as Status,  s.id, c.id, st.id
	from Store s
	left join City c on s.CityID = c.id
	left join Status st on s.StatusID = st.id
	where s.id = @id
end

if @action = 2 begin --insert
	
	insert into Store(Name, Adress, CityID, Web, PhoneNumber, Description, StatusID)
	values (@name, @adress, @cityId, @web, @phone, @description, @statusId)
end

if @action = 3 begin --update

	update Store set
	Name = @name,
	Adress = @adress,
	CityID = @cityId,
	Web = @web,
	PhoneNumber = @phone,
	Description = @description,
	StatusID = @statusId
	where id = @id
end

if @action = 4 begin --delete
	
	delete from Store where id = @id
end