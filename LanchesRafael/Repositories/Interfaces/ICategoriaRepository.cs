using LanchesRafael.Models;

namespace LanchesRafael.Repositories.Interfaces;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}

