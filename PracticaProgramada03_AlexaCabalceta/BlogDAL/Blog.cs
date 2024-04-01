using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    [Table("Blogs")]
    public class Blog
    {
        [Key]
        [Required]
        public int BlogId { get; set; }

        [Required]
        [Display(Name = "Nombre del Blog")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Autor del Blog")]
        public string UsuarioCreacionId { get; set; }

        [Display(Name = "Autor")]
        public ApplicationUser? UsuarioCreacion { get; set; }
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    }
}
