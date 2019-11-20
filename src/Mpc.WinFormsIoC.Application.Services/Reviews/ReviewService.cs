
namespace Mpc.WinFormsIoC.Application.Services.Reviews
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Application.Services.Mappings;
    using Mpc.WinFormsIoC.Domain.Core;
    using Polly;

    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReviewDto> CreateAsync(ReviewDto review)
        {
            var reviewModel = review.ToModel();
            
            await _unitOfWork.ReviewsRepository.InsertAsync(reviewModel).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return reviewModel.ToDto();
        }

        public async Task<List<ReviewDto>> GetAllAsync()
        {
            // example to use retry pattern
            // https://azure.microsoft.com/pt-pt/blog/using-the-retry-pattern-to-make-your-cloud-application-more-resilient/
            var policy = await Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2))
                .ExecuteAndCaptureAsync(async () => await _unitOfWork.ReviewsRepository.GetAllAsync().ConfigureAwait(false));

            return policy.Result.ToDto().ToList();
        }

        public async Task<ReviewDto> FindAsync(int reviewId)
        {
            var review = await _unitOfWork.ReviewsRepository.FindAsync(reviewId).ConfigureAwait(false);

            return review.ToDto();
        }
    }
}
