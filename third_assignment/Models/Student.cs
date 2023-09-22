using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace third_assignment.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        [MinLength(3, ErrorMessage = "Min length 3")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Address")]
        [MinLength(3, ErrorMessage = "Min length 3")]

        public double Address { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Faculty")]
        [MinLength(3, ErrorMessage = "Min length 3")]

        public double Faculty { get; set; }


    }
}