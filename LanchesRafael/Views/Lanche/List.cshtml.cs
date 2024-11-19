using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LanchesRafael.Models;
using LanchesRafael.Models.Context;

namespace LanchesRafael.Controllers
{
    public class ListModel : PageModel
    {
        private readonly LanchesRafael.Models.Context.AppDbContext _context;

        public ListModel(LanchesRafael.Models.Context.AppDbContext context)
        {
            _context = context;
        }

        public IList<Lanche> Lanche { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Lanches != null)
            {
                Lanche = await _context.Lanches
                .Include(l => l.Categoria).ToListAsync();
            }
        }
    }
}
