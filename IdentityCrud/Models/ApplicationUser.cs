using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCrud.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "ব্যবহারকারীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "ব্যবহারকারীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "ব্যবহারকারীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "ব্যবহারকারীর নাম", Prompt = "ব্যবহারকারীর নাম লিখুন")]
        public string Name { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "এনাবল করা হয়েছে কি"), Column("IsEnabled")]
        public bool IsEnabled { get; set; } = false;
    }
}
