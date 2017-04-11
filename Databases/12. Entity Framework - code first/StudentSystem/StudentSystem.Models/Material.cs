using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public int CourseId { get; set; }

        public virtual Course course { get; set; }
    }
}
