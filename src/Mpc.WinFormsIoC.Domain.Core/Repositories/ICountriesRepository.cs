namespace Mpc.WinFormsIoC.Domain.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Domain.Models;

    public interface ICountriesRepository
    {
        Task<CountryModel> FindAsync(int countryId);

        Task<List<CountryModel>> GetAllAsync();

        Task InsertAsync(CountryModel country);

        void Delete(CountryModel country);

        void Update(CountryModel country);

        Task<CountryModel> GetByIdAsync(int paisId);
    }
}
