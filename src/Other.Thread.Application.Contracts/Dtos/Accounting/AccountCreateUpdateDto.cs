using System;
using System.ComponentModel.DataAnnotations;

namespace Other.Thread.Dtos.Accounting;

public class AccountCreateUpdateDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = "";

    [Required]
    [StringLength(500)]
    public string Address { get; set; } = "";
    
    [Required]
    [StringLength(20)]
    public string Phone { get; set; } = "";
    
    [Required]
    [StringLength(50)]
    public string Email { get; set; } = "";

    public bool IsCustomer {get; set; } = false;
    
    public bool IsSuplier {get; set;} = false;
}