using System.ComponentModel.DataAnnotations;

namespace CloudAlliance.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}