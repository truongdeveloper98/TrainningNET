using System.ComponentModel.DataAnnotations;

namespace Trainning.Core.ViewModels.Authentications
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;
    }
}
