using System;
using Volo.Abp.Application.Dtos;

namespace Other.Thread;

public class AccountPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string NameFilterMethod { get; set; } = "";
    public string AddressFilterMethod { get; set; } = "";
    public string PhoneFilterMethod { get; set; } = "";
    public string EmailFilterMethod { get; set; } = "";
    public bool IsCustomer {get; set; } = false;
    public bool IsSuplier {get; set;} = false;

}
