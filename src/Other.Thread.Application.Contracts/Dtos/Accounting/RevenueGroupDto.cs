using System;
using Volo.Abp.Application.Dtos;

namespace Other.Thread.Dtos.Accounting;

public class RevenueGroupDto : AuditedEntityDto<Guid>
{
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}
