using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityCrud.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "ব্যবহারকারীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "ব্যবহারকারীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "ব্যবহারকারীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "ব্যবহারকারীর নাম", Prompt = "ব্যবহারকারীর নাম লিখুন")]
        public string Name { get; set; }
    }
}
