
namespace Mpc.WinFormsIoC.Application.Services.Reviews
{
    using Mpc.WinFormsIoC.Application.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReviewService
    {
        Task<ReviewDto> CreateAsync(ReviewDto review);

        Task<List<ReviewDto>> GetAllAsync();

        Task<ReviewDto> FindAsync(int reviewId);
    }
}
