using Microsoft.EntityFrameworkCore;
using Mpc.WinFormsIoC.Domain.Core.Repositories;
using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    internal class PlacesRepository : IPlacesRepository
    {
        private AppDbContext _context;

        public PlacesRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<PlaceModel>> GetAllAsync ()
        {
            var result = _context.Places.Include(p => p.Reviews).ToListAsync();
            return result;
        }

        public Task<PlaceModel> FindAsync(int id)
        {
            return _context.Places
                .AsNoTracking()
                .Include(p => p.Reviews)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public void Update(PlaceModel place)
        {
            _context.Entry(place).State = EntityState.Modified;
        }

        public Task InsertAsync(PlaceModel place)
        {
            return _context.Places
                .AddAsync(place);
        }
    }
}
