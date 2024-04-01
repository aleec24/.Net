using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogDAL
{
    [Table("AspNetUsers")]
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}