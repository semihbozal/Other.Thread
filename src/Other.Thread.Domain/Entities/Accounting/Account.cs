using System;
using Microsoft.Win32.SafeHandles;
using Volo.Abp.Domain.Entities.Auditing;

namespace Other.Thread.Entities.Accounting;

public class Account : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public bool IsCustomer {get; set; } = false;
    public bool IsSuplier {get; set;} = false;
}
