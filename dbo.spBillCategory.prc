if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spBillCategory]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spBillCategory
GO

CREATE PROCEDURE [dbo].[spBillCategory]

@action int = null,
@id int = null,
@name varchar(50)= null,
@description varchar(200) = null,
@statusId int = null

as

if @action = 1 begin --select all
	
	select bc.name as [Kategorija raèuna], case when bc.Description is null then 'N/A' else bc.Description end as Opis, s.name as Status, bc.id, s.id 
	from BillCategory bc 
	left join status s on bc.statusid = s.id 
	where s.name like 'Active%'
	
	
end

if @action = 11 begin --select on id
	
	select b.Name as Naziv,case when b.Description is null then '' else b.Description end as Opis, b.id, st.id
	from BillCategory b
	left join Status st on b.StatusID = st.id
	where b.id = @id
end

if @action = 2 begin --insert
	
	insert into BillCategory(Name, Description, StatusID)
	values (@name, @description, @statusId)
end

if @action = 3 begin --update

	update BillCategory set
	Name = @name,
	Description = @description,
	StatusID = @statusId
	where id = @id
end

if @action = 4 begin --delete
	
	delete from BillCategory where id = @id
end