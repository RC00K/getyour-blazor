using System.ComponentModel.DataAnnotations;

namespace BlazorHolData.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        public int Age { get; set; }
    }
}