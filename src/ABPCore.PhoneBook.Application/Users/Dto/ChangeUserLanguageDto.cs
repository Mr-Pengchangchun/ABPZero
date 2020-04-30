using System.ComponentModel.DataAnnotations;

namespace ABPCore.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}