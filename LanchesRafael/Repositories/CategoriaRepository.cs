using LanchesRafael.Models;
using LanchesRafael.Models.Context;
using LanchesRafael.Repositories.Interfaces;

namespace LanchesRafael.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> Categorias => _context.Categorias;
}

