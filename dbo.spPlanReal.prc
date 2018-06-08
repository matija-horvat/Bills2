if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spPlanReal]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].spPlanReal
GO

CREATE PROCEDURE [dbo].[spPlanReal]

@action int = null,
@date datetime = null,
@datumod datetime = null,
@datumdo datetime = null

as

if @action = 1 begin --select plan

	select bc.name as [Vrsta troška], bp.Name as [Namjena potrošnje], (convert(varchar, sum(p.Amount),1))  as [Iznos(kn)]
	from dbo.[Plan] p 
	left join BillCategory bc on p.BillCategoryID = bc.id
	left join BillPurpose bp on p.BillPurposeID = bp.id 
	where (p.planYear >= YEAR(@datumod) and p.planMounth >= MONTH(@datumod))
	and (p.planYear <= YEAR(@datumdo) and p.planMounth <= MONTH(@datumdo))
	group by bc.name, bp.Name

end


if @action = 2 begin --select real

	select bc.name as [Vrsta troška], bp.Name as [Namjena potrošnje], (convert(varchar, SUM(bb.Sum), 1)) as [Iznos(kn)]
	from dbo.BillBody bb
	inner join BillHead bh on bb.BillHead = bh.id
	left join BillCategory bc on  bh.BillCategoryID = bc.id
	left join BillPurpose bp on bh.BillPurposeID = bp.id 
	where (YEAR(bh.BillDate) >= YEAR(@datumod) and MONTH(bh.BillDate) >= MONTH(@datumod))
	and (YEAR(bh.BillDate) <= YEAR(@datumdo) and MONTH(bh.BillDate) <= MONTH(@datumdo))
	group by bc.name, bp.Name

end

