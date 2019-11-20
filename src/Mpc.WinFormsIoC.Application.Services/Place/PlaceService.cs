
namespace Mpc.WinFormsIoC.Application.Services.Place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Application.Services.Mappings;
    using Mpc.WinFormsIoC.Application.Services.Security;
    using Mpc.WinFormsIoC.Domain.Core;
    using Polly;

    public class PlaceService : IPlaceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<PlaceDto>> GetAllAsync()
        {
            // example to use retry pattern
            // https://azure.microsoft.com/pt-pt/blog/using-the-retry-pattern-to-make-your-cloud-application-more-resilient/
            var policy = await Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2))
                .ExecuteAndCaptureAsync(async () => await _unitOfWork.PlacesRepository.GetAllAsync().ConfigureAwait(false));

            return policy.Result.ToDto().ToList();
        }

        public async Task<PlaceDto> FindAsync(int placeId)
        {
            var place = await _unitOfWork.PlacesRepository.FindAsync(placeId).ConfigureAwait(false);

            return place.ToDto();
        }

        public async Task UpdateAsync(PlaceDto place)
        {
            var currentPlace = await _unitOfWork.PlacesRepository.FindAsync(place.Id).ConfigureAwait(false);

            currentPlace.Name = place.Name;
            currentPlace.Address = place.Address;
            currentPlace.PhoneNumber = place.PhoneNumber;
            currentPlace.Website = place.Website;

            _unitOfWork.PlacesRepository.Update(currentPlace);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task UpdateClassification(int placeId)
        {
            var currentPlace = await _unitOfWork.PlacesRepository.FindAsync(placeId).ConfigureAwait(false);

            var avrg = await CalculateAverageClassification(currentPlace.ToDto());

            currentPlace.Classification = avrg;

            _unitOfWork.PlacesRepository.Update(currentPlace);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<double> CalculateAverageClassification(PlaceDto place)
        {
            double classification = 0;
            double average = 0;

            foreach (var item in place.Reviews)
            {
                classification += item.Classification;
            }

            average = classification / place.Reviews.Count;

            return average;
        }

        public async Task<PlaceDto> CreateAsync(PlaceDto place)
        {
            var placeModel = place.ToModel();
            
            await _unitOfWork.PlacesRepository.InsertAsync(placeModel).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return placeModel.ToDto();
        }
    }
}
