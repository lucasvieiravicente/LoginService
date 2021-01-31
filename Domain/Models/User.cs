using LoginService.Domain.Consts;
using System.ComponentModel.DataAnnotations;

namespace LoginService.Domain.Models
{
    public class User : BaseEntity
    {
        [Display(Name = "Login")]
        [MinLength(5, ErrorMessage = ErrorMessages.MinRequired)]
        [MaxLength(25, ErrorMessage = ErrorMessages.MaxRequired)]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [MinLength(10, ErrorMessage = ErrorMessages.MinRequired)]
        [MaxLength(40, ErrorMessage = ErrorMessages.MaxRequired)]
        public string Password { get; set; }

        [Display(Name = "Nome")]
        [MinLength(3, ErrorMessage = ErrorMessages.MinRequired)]
        [MaxLength(60, ErrorMessage = ErrorMessages.MaxRequired)]
        public string Name { get; set; }
    }
}
