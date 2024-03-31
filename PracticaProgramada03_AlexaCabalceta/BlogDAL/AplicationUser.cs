using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogDAL
{
    [Table("AspNetUsers")]
    public class AplicationUser: IdentityUser
    {
        public int MyProperty { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}