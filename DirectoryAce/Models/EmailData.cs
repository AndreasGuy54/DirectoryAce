using System.ComponentModel.DataAnnotations;

namespace DirectoryAce.Models
{
    public class EmailData
    {
        [Required]
        public string? EmailAddress { get; set; } = string.Empty;
        [Required]
        public string? Subject { get; set; } = string.Empty;
        [Required]
        public string? Body { get; set; } = string.Empty;
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? GroupName { get; set; }
    }
}
