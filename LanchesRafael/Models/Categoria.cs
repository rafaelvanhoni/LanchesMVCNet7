using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesRafael.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage = "Informe o Nome da Categoria")]
    [Display(Name = "Nome da Categoria ")]
    public string? CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
    [Required(ErrorMessage = "Informe o Descrição da Categoria")]
    [Display(Name = "Descrição da Categoria")]
    public string? Descricao { get; set; }

    public List<Lanche>? Lanches { get; set; }

}

