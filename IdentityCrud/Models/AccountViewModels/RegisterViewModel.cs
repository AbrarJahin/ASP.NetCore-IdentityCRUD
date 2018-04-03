using System.ComponentModel.DataAnnotations;

namespace IdentityCrud.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "ব্যবহারকারীর নাম লিখতে হবে")]
        [MinLength(3, ErrorMessage = "ব্যবহারকারীর নাম ৩ অক্ষরের বড় হতে হবে")]
        [MaxLength(50, ErrorMessage = "ব্যবহারকারীর নাম ৫০ অক্ষরের ছোট হতে হবে")]
        [Display(Name = "ব্যবহারকারীর নাম", Prompt = "ব্যবহারকারীর নাম লিখুন")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
