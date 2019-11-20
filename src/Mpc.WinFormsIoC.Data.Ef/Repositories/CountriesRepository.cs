namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Domain.Models;

    internal class CountriesRepository : ICountriesRepository
    {
        private AppDbContext _context;

        public CountriesRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<CountryModel> FindAsync(int countryId)
        {
            return _context.Countries.FindAsync(countryId);
        }

        public Task<List<CountryModel>> GetAllAsync()
        {
            return _context.Countries.Include(p => p.Users).ToListAsync();
        }

        public Task InsertAsync(CountryModel country)
        {
            return _context.Countries.AddAsync(country);
        }

        public void Update(CountryModel country)
        {
            _context.Entry(country).State = EntityState.Modified;
        }

        public void Delete(CountryModel country)
        {
            _context.Countries.Remove(country);
        }

        public Task<CountryModel> GetByIdAsync(int paisId)
        {
            return _context.Countries
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == paisId);
        }
    }
}
