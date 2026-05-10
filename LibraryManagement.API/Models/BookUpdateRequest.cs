using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class BookUpdateRequest
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Author { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(2048)]
        [Url]
        public string PhotoUrl { get; set; } = string.Empty;
    }
}
