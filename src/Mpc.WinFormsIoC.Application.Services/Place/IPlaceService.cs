
namespace Mpc.WinFormsIoC.Application.Services.Place
{
    using Mpc.WinFormsIoC.Application.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPlaceService
    {
        /// <summary>
        /// Get all places
        /// </summary>
        /// <returns></returns>
        Task<List<PlaceDto>> GetAllAsync();

        Task<PlaceDto> FindAsync(int placeId);

        Task UpdateAsync(PlaceDto place);

        Task<PlaceDto> CreateAsync(PlaceDto place);

        Task UpdateClassification(int placeId);

        Task<double> CalculateAverageClassification(PlaceDto place);
    }
}
