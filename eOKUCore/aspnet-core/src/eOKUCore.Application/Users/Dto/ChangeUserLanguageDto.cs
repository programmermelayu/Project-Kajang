using System.ComponentModel.DataAnnotations;

namespace eOKUCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}