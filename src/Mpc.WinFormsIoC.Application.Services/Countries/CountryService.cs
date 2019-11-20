namespace Mpc.WinFormsIoC.Application.Services.Countries
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Application.Services.Mappings;
    using Mpc.WinFormsIoC.Domain.Core;

    internal class CountryService : ICountryService
    {
        private IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CountryDto>> GetAllAsync()
        {
            var countries = await _unitOfWork.CountriesRepository.GetAllAsync().ConfigureAwait(false);

            return countries.ToDto().ToList();
        }

        public async Task<CountryDto> CreateAsync(CountryDto country)
        {
            var currentCountry = country.ToModel();

            await _unitOfWork.CountriesRepository.InsertAsync(currentCountry).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return currentCountry.ToDto();
        }

        public async Task UpdateAsync(CountryDto country)
        {
            var currentCountry = await _unitOfWork.CountriesRepository.FindAsync(country.Id).ConfigureAwait(false);
            
            currentCountry.Name = country.Name;
            currentCountry.Alias = country.Alias;

            _unitOfWork.CountriesRepository.Update(currentCountry);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(CountryDto country)
        {
            var currentCountry = await _unitOfWork.CountriesRepository.FindAsync(country.Id).ConfigureAwait(false);

            _unitOfWork.CountriesRepository.Delete(currentCountry);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<CountryDto> FindAsync(int countryId)
        {
            var country = await _unitOfWork.CountriesRepository.FindAsync(countryId).ConfigureAwait(false);

            return country.ToDto();
        }

        public async Task<string> GetNameById(int paisId)
        {
            var country = await _unitOfWork.CountriesRepository.GetByIdAsync(paisId).ConfigureAwait(false);

            return country.Name;
        }
    }
}
