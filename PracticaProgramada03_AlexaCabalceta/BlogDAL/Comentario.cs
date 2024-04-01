using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        [Required]
        public int ComentarioId { get; set; }

        [Required]
        [Display(Name = "Nombre del Usuario")]
        public string UsuarioCreacionId { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "Comentario")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [ForeignKey("BlogId")]
        [Display(Name = "Blog")]
        public int BlogId { get; set; }

        [Display(Name = "Usuario")]
        public ApplicationUser? UsuarioCreacion { get; set; }

        public Blog? Blog { get; set; }
    }
}
