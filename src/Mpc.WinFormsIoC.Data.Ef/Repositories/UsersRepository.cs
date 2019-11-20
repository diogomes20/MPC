namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Domain.Models;

    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> CountAsync()
        {
            return _context.Users.CountAsync();
        }

        public void Delete(UserModel user)
        {
            _context.Users.Remove(user);
        }

        public Task<UserModel> FindAsync(int id)
        {
            return _context.Users
                .Include(x => x.Pais)
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<UserModel>> GetByFilterAsync(int page, int pageSize)
        {
            return _context.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<UserModel> GetByUsernameAndPasswordAsync(string username, string password)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }

        public Task<UserModel> GetByUsernameAsync(string username)
        {
            return _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == username);
        }

        public Task InsertAsync(UserModel user)
        {
            return _context.Users
                .AddAsync(user);
        }

        public void Update(UserModel user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public Task<List<UserModel>> GetByCountryAsync(int countryId)
        {
            return _context.Users
                .Include(x => x.Pais)
                .Where(x => x.PaisId == countryId)
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<List<UserModel>> GetAllUsers()
        {
            return _context.Users
                .Include(u => u.Pais)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
