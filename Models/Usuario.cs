using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ApiComDBCartões.classes
{
    [Table("usuario")]
    public class Usuario
    {
       
        
            [Key]
            [Column("id")]
            public int Id { get; set; }

             [Column("usuarioNome")]
             [Required,NotNull] 
             [StringLength(50)]
            public string? NomeUsuario { get; set; }


            [Column("usuarioSenha")]
            [Required,NotNull]
            [StringLength(12)]
            public string? SenhaUsuario { get; set; }




    }
}
