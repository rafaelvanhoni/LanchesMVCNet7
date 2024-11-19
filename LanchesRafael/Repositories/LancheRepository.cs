using LanchesRafael.Models;
using LanchesRafael.Models.Context;
using LanchesRafael.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesRafael.Repositories;

public class LancheRepository : ILancheRepository
{

    private readonly AppDbContext _context;

    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

    public Lanche GetLanchesById(int lancheId)
    {
        var lanche = _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

        return lanche ?? throw new KeyNotFoundException($"Lanche com ID {lancheId} não foi encontrado");
    }
}

