namespace Mpc.WinFormsIoC.Application.Services.Mappings
{
    using System.Collections.Generic;
    using System.Linq;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Domain.Models;

    public static class CountryMapping
    {
        /// <summary>
        /// Convert IEnumerable of UserModel to IEnumerable of UserDto 
        /// </summary>
        public static IEnumerable<CountryDto> ToDto(this IEnumerable<CountryModel> coutries)
        {
            return coutries?.Select(ToDto);
        }

        /// <summary>
        /// Convert Model to Dto
        /// </summary>
        public static CountryDto ToDto(this CountryModel country)
        {
            List<UserDto> users = new List<UserDto>();

            return country == null ? null : new CountryDto
            {
                Id = country.Id,
                Name = country.Name,
                Alias = country.Alias,
                Users = country.Users == null ? users : country.Users.ToDto().ToList()
            }; 
        }

        /// <summary>
        /// Convert Dto to Model
        /// </summary>
        public static CountryModel ToModel(this CountryDto country)
        {
            return country == null ? null : new CountryModel
            {
                Id = country.Id,
                Name = country.Name,
                Alias = country.Alias
            };
        }
    }
}
