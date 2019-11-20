
namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Domain.Models;

    internal class ReviewsRepository : IReviewsRepository
    {
        private readonly AppDbContext _context;

        public ReviewsRepository (AppDbContext context)
        {
            _context = context;
        }

        public Task InsertAsync(ReviewModel review)
        {
            return _context.Reviews
                .AddAsync(review);
        }

        public Task<List<ReviewModel>> GetAllAsync()
        {
            return _context.Reviews
                .Include(r => r.User)
                .Include(r => r.Place)
                .ToListAsync();
        }

        public Task<ReviewModel> FindAsync(int id)
        {
            return _context.Reviews
                .AsNoTracking()
                .SingleOrDefaultAsync(r => r.Id == id);
        }
    }
}