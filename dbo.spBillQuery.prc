if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spBillQuery]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spBillQuery]
GO

CREATE PROCEDURE [dbo].[spBillQuery]

@action int = null,
@node varchar(30) = null,
@id int = null,
@billNumber varchar(30) = null,
@billDate datetime = null,
@storeID int = null,
@billCategoryID int = null,
@billPurposeID int = null,
@description varchar(500) = null,
@param int = null,
@year int = null,
@month int = null,
@day int = null

as

declare @counter int

If @action = 1 begin --select glava
	
	
	
	
	if @node = 'nodeToday' begin
		select BillNumber as [Broj Raèuna], BillDate as [Datum], s.name as [Mjesto troška]
		, bc.Name as [Kategorija], bp.Name as Namjena, (convert(varchar, TotalSum,1)) as [Ukupno(kn)]
		, (convert(varchar, TotalPDV,1)) as [Ukupno PDV], b.Description as Opis, b.id, st.ForeColorGrid, st.BackColorGrid
		from BillHead b 
		left join Store s on b.StoreID = s.id
		left join BillCategory bc on b.BillCategoryID = bc.id
		left join BillPurpose bp on b.BillPurposeID = bp.id
		left join Status st on b.StatusID = st.id
		where YEAR(BillDate) = YEAR(GETDATE())
		and MONTH(BillDate) = MONTH(GETDATE())
		and DAY(BillDate) = DAY(GETDATE())
		
		return
	end
	
	if @node = 'nodeYesterday' begin
		select BillNumber as [Broj Raèuna], BillDate as [Datum], s.name as [Mjesto troška]
		, bc.Name as [Kategorija], bp.Name as Namjena, (convert(varchar, TotalSum,1)) as [Ukupno(kn)]
		, (convert(varchar, TotalPDV,1)) as [Ukupno PDV], b.Description as Opis, b.id, st.ForeColorGrid, st.BackColorGrid
		from BillHead b 
		left join Store s on b.StoreID = s.id
		left join BillCategory bc on b.BillCategoryID = bc.id
		left join BillPurpose bp on b.BillPurposeID = bp.id
		left join Status st on b.StatusID = st.id
		where YEAR(BillDate) = YEAR(GETDATE())
		and MONTH(BillDate) = MONTH(GETDATE())
		and DAY(BillDate) = DAY(GETDATE())-1
		
		return
	end
	
	if @node = 'nodeThisMonth' begin
		select BillNumber as [Broj Raèuna], BillDate as [Datum], s.name as [Mjesto troška]
		, bc.Name as [Kategorija], bp.Name as Namjena, (convert(varchar, TotalSum,1)) as [Ukupno(kn)]
		, (convert(varchar, TotalPDV,1)) as [Ukupno PDV], b.Description as Opis, b.id, st.ForeColorGrid, st.BackColorGrid
		from BillHead b 
		left join Store s on b.StoreID = s.id
		left join BillCategory bc on b.BillCategoryID = bc.id
		left join BillPurpose bp on b.BillPurposeID = bp.id 
		left join Status st on b.StatusID = st.id
		where YEAR(BillDate) = YEAR(GETDATE())
		and MONTH(BillDate) = MONTH(GETDATE())
		
		return
	end
	
	if @node = 'nodeThisYear' begin
		select BillNumber as [Broj Raèuna], BillDate as [Datum], s.name as [Mjesto troška]
		, bc.Name as [Kategorija], bp.Name as Namjena, (convert(varchar, TotalSum,1)) as [Ukupno(kn)]
		, (convert(varchar, TotalPDV,1)) as [Ukupno PDV], b.Description as Opis, b.id, st.ForeColorGrid, st.BackColorGrid
		from BillHead b 
		left join Store s on b.StoreID = s.id
		left join BillCategory bc on b.BillCategoryID = bc.id
		left join BillPurpose bp on b.BillPurposeID = bp.id 
		left join Status st on b.StatusID = st.id
		where YEAR(BillDate) = YEAR(GETDATE())
		
		return
	end
	
	if @node like 'nodeMonth%' begin
		
		declare @month2 int
		
		set @month2 = CAST(SUBSTRING(@node,10,len(@node)) as int)
		select BillNumber as [Broj Raèuna], BillDate as [Datum], s.name as [Mjesto troška]
		, bc.Name as [Kategorija], bp.Name as Namjena, (convert(varchar, TotalSum,1)) as [Ukupno(kn)]
		, (convert(varchar, TotalPDV,1)) as [Ukupno PDV], b.Description as Opis, b.id, st.ForeColorGrid, st.BackColorGrid
		from BillHead b 
		left join Store s on b.StoreID = s.id
		left join BillCategory bc on b.BillCategoryID = bc.id
		left join BillPurpose bp on b.BillPurposeID = bp.id
		left join Status st on b.StatusID = st.id
		where YEAR(BillDate) = YEAR(GETDATE())
		and MONTH(BillDate) = @month2
		
		return
	end
	
end

If @action = 2 begin --select stavki
	
	select ArticlName as [Artikl / Usluga], UnitOfMeasureId, uom.name as [Jedinica mjere]
	, Quantity as [Kolièina], (convert(varchar, Sum,1)) as [Iznos], (convert(varchar, PDV,1)) as PDV, b.Description as Opis, b.id, billhead
	from BillBody b
	left join UnitOfMeasure uom on b.unitofmeasureid = uom.id
	where BillHead = @id
	
	return
end

If @action = 22 begin --select stavke
	
	select ArticlName as [Artikl / Usluga], UnitOfMeasureId, uom.name as [Jedinica mjere]
	, Quantity as [Kolièina], (convert(varchar, sum,1)) as [Iznos(kn)], (convert(varchar, PDV,1)), b.Description as Opis, b.id, billhead
	from BillBody b
	left join UnitOfMeasure uom on b.unitofmeasureid = uom.id
	where b.id = @id
	
	return
end

if @action=3 begin
	select * from BillHead
	where id = @id
end 


if @action = 4 begin
	select year(bh.BillDate) as Godina, MONTH(bh.BillDate) as Mjesec, bc.Name as Kategorija, (convert(varchar, SUM(bb.sum),1)) as [Ukupno(kn)] 
	from BillBody bb inner join BillHead bh on bb.BillHead = bh.id
	inner join BillCategory bc on bh.BillCategoryID = bc.id
	where (YEAR(bh.BillDate) = @year or @year is null)
	and (month(bh.BillDate) = @month or @month is null)
	group by year(bh.BillDate), MONTH(bh.BillDate), bh.BillCategoryID, bc.Name

end

if @action = 5 begin  --rekapitulacija po mjesecu (dijagram)
	
	IF EXISTS(SELECT * FROM tempdb.dbo.sysobjects WHERE ID = OBJECT_ID(N'tempdb..#tdijaRekap')) 
		drop table #tdijaRekap
	
	select 1 as Mjesec, 0 as [Iznos(kn)]
	into #tdijaRekap
	union all
	select 2 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 3 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 4 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 5 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 6 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 7 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 8 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 9 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 10 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 11 as Mjesec, 0 as [Iznos(kn)]
	union all
	select 12 as Mjesec, 0 as [Iznos(kn)]
	
	set @counter = 1
	
	while @counter <= (select COUNT(*) from #tdijaRekap) begin
		update #tdijaRekap set
		[Iznos(kn)] = coalesce((select SUM(bb.sum)
				from BillBody bb inner join BillHead bh on bb.BillHead = bh.id
				inner join BillCategory bc on bh.BillCategoryID = bc.id
				where YEAR(bh.BillDate) = @year
				and month(bh.BillDate) = (select mjesec from #tdijaRekap where mjesec = @counter)
				group by year(bh.BillDate), MONTH(bh.BillDate)),0)
		where mjesec = @counter
		
		set @counter = @counter + 1
	end
	
	select * from #tdijaRekap

end

if @action = 6 begin  --rekapitulacija po kategoriji za mjesec (dijagram)
	
	IF EXISTS(SELECT * FROM tempdb.dbo.sysobjects WHERE ID = OBJECT_ID(N'tempdb..#tdijaRekapKat')) 
		drop table #tdijaRekapKat
	
	select distinct bc.Name as Kategorija, 0 as [Iznos(kn)], IDENTITY(int) as id 
	into #tdijaRekapKat
	from BillCategory bc 
	inner join Status s on bc.StatusID = s.id
	where s.Name like 'Active'
	
	set @counter = 1
	
	while @counter <= (select COUNT(*) from #tdijaRekapKat) begin
		update #tdijaRekapKat set
		[Iznos(kn)] = coalesce((select SUM(bb.sum)
				from BillBody bb inner join BillHead bh on bb.BillHead = bh.id
				inner join BillCategory bc on bh.BillCategoryID = bc.id
				where YEAR(bh.BillDate) = @year
				and month(bh.BillDate) = @month
				and bc.name = (select kategorija from #tdijaRekapKat where id = @counter)
				group by year(bh.BillDate), MONTH(bh.BillDate)),0)
		where id = @counter
		
		set @counter = @counter + 1
	end
	
	select Kategorija, [Iznos(kn)] from #tdijaRekapKat

end

if @action = 7 begin  --rekapitulacija po kategoriji za mjesec i dan (dijagram)
	
	IF EXISTS(SELECT * FROM tempdb.dbo.sysobjects WHERE ID = OBJECT_ID(N'tempdb..#tdijaRekapKat2')) 
		drop table #tdijaRekapKat2
	
	select distinct bc.Name as Kategorija, 0 as [Iznos(kn)], IDENTITY(int) as id 
	into #tdijaRekapKat2
	from BillCategory bc 
	inner join Status s on bc.StatusID = s.id
	inner join BillHead bh on bc.id = bh.BillCategoryID
	where s.Name like 'Active'
	and YEAR(bh.BillDate) = @year
	and month(bh.BillDate) = @month
	and day(bh.BillDate) = @day 
	
	set @counter = 1
	
	while @counter <= (select COUNT(*) from #tdijaRekapKat2) begin
		update #tdijaRekapKat2 set
		[Iznos(kn)] = coalesce((select SUM(bb.sum)
				from BillBody bb inner join BillHead bh on bb.BillHead = bh.id
				inner join BillCategory bc on bh.BillCategoryID = bc.id
				where YEAR(bh.BillDate) = @year
				and month(bh.BillDate) = @month
				and day(bh.BillDate) = @day 
				and bc.name = (select kategorija from #tdijaRekapKat2 where id = @counter)
				group by year(bh.BillDate), MONTH(bh.BillDate), day(bh.BillDate)),0)
		where id = @counter
		
		set @counter = @counter + 1
	end
	
	select Kategorija, [Iznos(kn)] from #tdijaRekapKat2

end
return