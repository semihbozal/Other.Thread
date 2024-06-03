using System;
using Volo.Abp.Application.Dtos;

namespace Other.Thread.Dtos.Accounting;

public class AccountDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public bool IsCustomer {get; set; } = false;
    public bool IsSuplier {get; set;} = false;
}