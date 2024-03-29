﻿namespace Mpc.WinFormsIoC.Domain.Core
{
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;

    public interface IUnitOfWork
    {
        ICountriesRepository CountriesRepository { get; }

        IUsersRepository UsersRepository { get; }

        IPlacesRepository PlacesRepository { get; }

        IReviewsRepository ReviewsRepository { get; }

        Task SaveChangesAsync();
    }
}
