using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BalataTest.Areas.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Premium ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters")]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters long")]
        [MaxLength(200, ErrorMessage = "Description cannot be longer than 200 characters")]
        [DisplayName("Premium Description")]
        public string Description { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Premium Start Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Premium End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Invalid price")]
        [DisplayName("Premium Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid duration")]
        [DisplayName("Premium Duration (months)")]
        public int Duration { get; set; }

        // Use a single integer FK property (nome coincidente com a View/PageModel: StudentID)
        public int StudentID { get; set; }

        // Removida a propriedade 'object StudentID' duplicada
        public decimal Value { get; set; }

        // navigation
        public Student Student { get; set; } = null!;
    }
}