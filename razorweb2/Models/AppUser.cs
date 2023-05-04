using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace razorweb2.models
{
    public class AppUser : IdentityUser
    {
        // Add field Home Address into Identity User
        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string HomeAddress { get; set; }
    }
}