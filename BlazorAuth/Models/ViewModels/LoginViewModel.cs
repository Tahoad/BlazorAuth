using System.ComponentModel.DataAnnotations;

namespace BlazorAuth.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "กรุณาใส่ UserName")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "กรุณาใส่ Password")]
        public string? Password { get; set; }
    }
}
