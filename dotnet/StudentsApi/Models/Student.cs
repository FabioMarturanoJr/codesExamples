using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsApi.Models
{
    [Table("Students")]
    public class Student
    {
        // dataAnnotations redundante [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; } = "Student";
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = "email@email.com";
        [Required]
        public int Age { get; set; }
    }
}