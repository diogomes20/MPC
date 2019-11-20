namespace Mpc.WinFormsIoC.Application.Services.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;

    public interface ICountryService
    {
        Task<List<CountryDto>> GetAllAsync();

        Task<CountryDto> CreateAsync(CountryDto country);

        Task UpdateAsync(CountryDto country);

        Task DeleteAsync(CountryDto country);

        Task<CountryDto> FindAsync(int countryId);

        /// <summary>
        /// Find country name by Id
        /// </summary>
        /// <param name="paisId"></param>
        /// <returns>Returns the name</returns>
        Task<string> GetNameById(int paisId);
    }
}
