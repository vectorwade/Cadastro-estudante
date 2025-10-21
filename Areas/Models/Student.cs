using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BalataTest.Areas.Models
{
    public class Student
    {

        [Key]
        [DisplayName("Student ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        [MaxLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]

        [DisplayName("Student Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Student Email")]
        public string Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new List<Premium>();

    }
}