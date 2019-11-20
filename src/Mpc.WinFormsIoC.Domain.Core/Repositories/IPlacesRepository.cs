using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mpc.WinFormsIoC.Domain.Core.Repositories
{
    public interface IPlacesRepository
    {
        Task<List<PlaceModel>> GetAllAsync();

        Task<PlaceModel> FindAsync(int id);

        void Update(PlaceModel place);

        Task InsertAsync(PlaceModel place);
    }
}
