using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja_Produtos.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name="Código")]
        public int Id { get; set; }

        [Column("Produto")]
        [Display(Name ="Produto")]
        public string Mercadoria { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


    }
}
