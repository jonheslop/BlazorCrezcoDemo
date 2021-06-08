using System.ComponentModel.DataAnnotations;
public class Invoice
{
  [Required]
  [StringLength(20, ErrorMessage = "Reference is too long.")]
  public string Reference { get; set; }
}
