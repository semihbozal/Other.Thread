using System;
using Volo.Abp.Application.Dtos;

namespace Other.Thread.Dtos.Accounting;

public class SafeDto : AuditedEntityDto<Guid>
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