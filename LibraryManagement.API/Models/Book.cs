using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.TitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(ValidationConstants.AuthorMaxLength)]
        public string Author { get; set; } = string.Empty;

        [MaxLength(ValidationConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(ValidationConstants.PhotoUrlMaxLength)]
        [Url]
        public string PhotoUrl { get; set; } = string.Empty;

    }
}
