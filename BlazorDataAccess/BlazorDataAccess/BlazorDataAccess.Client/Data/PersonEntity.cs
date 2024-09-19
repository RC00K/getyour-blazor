using System.ComponentModel.DataAnnotations;

namespace BlazorDataAccess.Data;

public class PersonEntity
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }
    public int Age { get; set; }
}