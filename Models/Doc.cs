using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextEditor.Models
{
    public class Doc
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } // Add Title field

        public string Contect { get; set; }

        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]

        public IdentityUser? User { get; set; }
    }
}
