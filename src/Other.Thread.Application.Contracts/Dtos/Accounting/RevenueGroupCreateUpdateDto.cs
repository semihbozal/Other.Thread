using System;
using System.ComponentModel.DataAnnotations;

namespace Other.Thread.Dtos.Accounting;

public class RevenueGroupCreateUpdateDto
{
    [Required]
    [StringLength(10)]
    public string Code { get; set; } = "";
    
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = "";
    
    [StringLength(500)]
    public string Description { get; set; } = "";
}
