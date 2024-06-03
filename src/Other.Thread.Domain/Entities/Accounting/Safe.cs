using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Other.Thread.Entities.Accounting;

public class Safe : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Bank { get; set; } = "";
    public string BankBranch { get; set; } = "";
    public string AccountNo {get; set; } = "";
    public string IBAN {get; set;} = "";
    public bool IsDefault {get; set;} = false;
}