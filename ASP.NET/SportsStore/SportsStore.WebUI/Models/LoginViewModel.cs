using System.ComponentModel.DataAnnotations;

namespace SportsStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { set; get; }

        [Required]
        public string Password { set; get; }
    }
}