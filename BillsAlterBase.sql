if not exists (select * from syscolumns where name='Adress' and id=object_id('Store')) 
alter table Store add Adress varchar(100) null 
GO

if not exists (select * from syscolumns where name='PhoneNumber' and id=object_id('Store')) 
alter table Store add PhoneNumber varchar(20) null 
GO

if not exists (select * from syscolumns where name='Web' and id=object_id('Store')) 
alter table Store add Web varchar(100) null 
GO

if not exists (select * from syscolumns where name='StatusID' and id=object_id('Store')) 
alter table Store add StatusID int null 
GO

if not exists (select * from syscolumns where name='BillNumber' and id=object_id('BillHead')) 
alter table BillHead add BillNumber varchar(30) null 
GO

if not exists (select * from syscolumns where name='ForeColorGrid' and id=object_id('Status')) 
alter table Status add ForeColorGrid varchar(30) null 
GO

if not exists (select * from syscolumns where name='BackColorGrid' and id=object_id('Status')) 
alter table Status add BackColorGrid varchar(30) null 
GO

if exists (select * from syscolumns where name='Quantity' and id=object_id('BillBody')) 
alter table BillBody alter column Quantity money null 
GO




