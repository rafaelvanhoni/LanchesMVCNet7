﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesRafael.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required(ErrorMessage ="O Nome do Lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A Descrição do Lanche deve ser informada")]
    [Display(Name = "Descrição do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
    public string? DescricaoCurta { get; set; }

    [Required(ErrorMessage = "A Descrição Detalhada do Lanche deve ser informada")]
    [Display(Name = "Descrição Detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição Detalhada deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição Detalhada não pode exceder {1} caracteres")]
    public string? DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o Preço do Lanche")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage = "O Preço deve estar entre 1 e 999,99")]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Caminho Imagem Miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string? ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria? Categoria { get; set; }
}

