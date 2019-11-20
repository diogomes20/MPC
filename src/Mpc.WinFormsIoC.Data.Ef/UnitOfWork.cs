namespace Mpc.WinFormsIoC.Data.Ef
{
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Data.Ef.Repositories;
    using Mpc.WinFormsIoC.Domain.Core;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UsersRepository = new Repositories.UsersRepository(_context);
            CountriesRepository = new Repositories.CountriesRepository(_context);
            PlacesRepository = new Repositories.PlacesRepository(_context);
            ReviewsRepository = new Repositories.ReviewsRepository(_context);
        }

        public IUsersRepository UsersRepository { get; }

        public ICountriesRepository CountriesRepository { get; }

        public IPlacesRepository PlacesRepository { get; }

        public IReviewsRepository ReviewsRepository { get; }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);

            var entities = _context.ChangeTracker.Entries().ToList();

            foreach (var entry in entities)
            {
                entry.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
        }
    }
}
