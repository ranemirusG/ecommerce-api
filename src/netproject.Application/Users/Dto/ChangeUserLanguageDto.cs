using System.ComponentModel.DataAnnotations;

namespace netproject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}