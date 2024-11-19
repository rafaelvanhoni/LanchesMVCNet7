using LanchesRafael.Models;

namespace LanchesRafael.Repositories.Interfaces;

public interface ILancheRepository
{
    IEnumerable<Lanche> Lanches { get; }
    IEnumerable<Lanche> LanchesPreferidos { get; }
    Lanche GetLanchesById(int lancheId);

}

