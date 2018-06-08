
if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Status]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].Status
(
	id int primary key identity,
	Name varchar(50),
	ForeColorGrid varchar(30),
	BackColorGrid varchar(30)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UnitOfMeasure]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].UnitOfMeasure
(
	id int primary key identity,
	Name varchar(50),
	Description varchar(500),
	StatusID int,
	constraint fk_UoMStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserRole]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].UserRole
(
	id int primary key identity,
	Name varchar(50),
	SelectData bit,
	InputData bit,
	UpadateData bit,
	DeleteData bit,
	PrintData bit
	
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserData]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].UserData
(
	id int primary key identity,
	Name varchar(50),
	Surname varchar(50),
	username varchar(50),
	password varchar(250),
	RoleID int,
	StatusID int,
	constraint fk_UserStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id),
	constraint fk_UserRole FOREIGN KEY (RoleID) REFERENCES [dbo].UserRole(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Country]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].Country
(
	id int primary key identity,
	Name varchar(50)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Region]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].Region
(
	id int primary key identity,
	Name varchar(100),
	CountryID int,
	constraint fk_RegCtry FOREIGN KEY (CountryID) REFERENCES [dbo].Country(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[City]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].City
(
	id int primary key identity,
	Name varchar(50),
	POnumber varchar(15),
	RegionID int,
	constraint fk_CiReg FOREIGN KEY (RegionID) REFERENCES [dbo].Region(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Store]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].Store
(
	id int primary key identity,
	Name varchar(50),
	Adress varchar(100),
	PhoneNumber varchar(20),
	Web varchar(100),
	Description varchar(200),
	CityID int,
	StatusID int,
	constraint fk_StCi FOREIGN KEY (CityID) REFERENCES [dbo].City(id),
	constraint fk_StSta FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BillCategory]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].BillCategory
(
	id int primary key identity,
	Name varchar(50),
	Description varchar(500),
	StatusID int,
	constraint fk_CostcStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BillPurpose]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].BillPurpose
(
	id int primary key identity,
	Name varchar(50),
	Description varchar(500),
	StatusID int,
	constraint fk_PurStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BillHead]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].BillHead
(
	id int primary key identity,
	BillNumber varchar(30),
	BillDate datetime,
	StoreID int,
	BillCategoryID int,
	BillPurposeID int,
	TotalSum money,
	TotalPDV money,
	Description varchar(500),
	StatusID int,
	constraint fk_BillHeadStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id),
	constraint fk_BillHeadSto FOREIGN KEY (StoreID) REFERENCES [dbo].Store(id),
	constraint fk_BillHeadCat FOREIGN KEY (BillCategoryID) REFERENCES [dbo].BillCategory(id),
	constraint fk_BillHeadPurp FOREIGN KEY (BillPurposeID) REFERENCES [dbo].BillPurpose(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BillBody]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].BillBody
(
	id int primary key identity,
	BillHead int,
	ArticlName varchar(100),
	Quantity money,
	UnitOfMeasureID int,
	Sum money,
	PDV money,
	Description varchar(500),
	constraint fk_BodyStat FOREIGN KEY (BillHead) REFERENCES [dbo].BillHead(id),
	constraint fk_BodyUoM FOREIGN KEY (UnitOfMeasureID) REFERENCES [dbo].UnitOfMeasure(id)
)


if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[IncomeCategory]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].IncomeCategory
(
	id int primary key identity,
	Name varchar(50),
	Description varchar(500),
	StatusID int,
	constraint fk_InccStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[IncomePaymen]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].IncomePaymen
(
	id int primary key identity,
	Name varchar(50),
	Description varchar(500),
	StatusID int,
	constraint fk_IncPStat FOREIGN KEY (StatusID) REFERENCES [dbo].Status(id)
)

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Income]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
create table [dbo].Income
(
	id int primary key identity,
	IncomeDate datetime,
	IncomeCategoryID int,
	IncomePaymenID int,
	Amount money,
	Description varchar(500),
	constraint fk_IncCat FOREIGN KEY (IncomeCategoryID) REFERENCES [dbo].IncomeCategory(id),
	constraint fk_IncPay FOREIGN KEY (IncomePaymenID) REFERENCES [dbo].IncomePaymen(id)
)
