using System.ComponentModel.DataAnnotations;

namespace IdentityCrud.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "ব্যবহারকারীর নাম লিখতে হবে")]
        [MinLength(3, ErrorMessage = "ব্যবহারকারীর নাম ৩ অক্ষরের বড় হতে হবে")]
        [MaxLength(50, ErrorMessage = "ব্যবহারকারীর নাম ৫০ অক্ষরের ছোট হতে হবে")]
        [Display(Name = "ব্যবহারকারীর নাম", Prompt = "ব্যবহারকারীর নাম লিখুন")]
        public string Name { get; set; }
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
