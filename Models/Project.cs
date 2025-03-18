using System.ComponentModel.DataAnnotations;

namespace CVProfile.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Project name is required")]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Project description is required")]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Project date is required")]
        public DateTime CompletionDate { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL")]
        public string? GitHubUrl { get; set; }

        [StringLength(500)]
        public string? Technologies { get; set; }

        public string? ImageUrl { get; set; }
    }
} 