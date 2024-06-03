using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Other.Thread.Entities.Accounting;

public class RevenueGroup : FullAuditedAggregateRoot<Guid> 
{
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

}
