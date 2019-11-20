using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mpc.WinFormsIoC.Domain.Core.Repositories
{
    public interface IReviewsRepository
    {
        Task InsertAsync(ReviewModel review);

        Task<List<ReviewModel>> GetAllAsync();

        Task<ReviewModel> FindAsync(int id);
    }
}
