using System.ComponentModel.DataAnnotations;

namespace CVProfile.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Technology name is required")]
        [StringLength(100)]
        public string TechnologyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Years of experience is required")]
        [Range(0, 50, ErrorMessage = "Years must be between 0 and 50")]
        public decimal YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Skill level is required")]
        [Range(1, 5, ErrorMessage = "Skill level must be between 1 and 5")]
        public int SkillLevel { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
    }
} 