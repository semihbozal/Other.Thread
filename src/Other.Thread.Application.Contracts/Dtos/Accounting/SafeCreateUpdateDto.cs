using System;
using System.ComponentModel.DataAnnotations;

namespace Other.Thread.Dtos.Accounting;

public class SafeCreateUpdateDto
{
    [Required]
    [StringLength(10)]
    public string Code { get; set; } = "";
    
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = "";
    
    [StringLength(500)]
    public string Description { get; set; } = "";
    
    [StringLength(50)]
    public string Bank { get; set; } = "";
    
    [StringLength(50)]
    public string BankBranch { get; set; } = "";
    
    [StringLength(50)]
    public string AccountNo {get; set; } = "";
    
    [StringLength(50)]
    public string IBAN {get; set;} = "";

    [Required]
    public bool IsDefault {get; set;} = false;
}
