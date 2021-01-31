using LoginService.Domain.Consts;
using LoginService.Utils;
using System.ComponentModel.DataAnnotations;

namespace LoginService.Domain.Models
{
    public class User : BaseEntity
    {
        #region [Constructors]
        public User(string login, string password, string name)
        {
            Login = login;
            Password = HashUtil.HashPassword(password);
            Name = name;
        }

        public User()
        {
        }
        #endregion

        #region [Columns]
        [Display(Name = "Login")]
        [MinLength(5, ErrorMessage = ErrorMessages.MinRequired)]
        [MaxLength(25, ErrorMessage = ErrorMessages.MaxRequired)]
        public string Login { get; set; }

        [Display(Name = "Nome")]
        [MinLength(3, ErrorMessage = ErrorMessages.MinRequired)]
        [MaxLength(60, ErrorMessage = ErrorMessages.MaxRequired)]
        public string Name { get; set; }

        public byte[] Password { get; set; }
        #endregion
    }
}
