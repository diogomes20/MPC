using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mpc.WinFormsIoC.Application.Services.Mappings
{
    public static class PlaceMapping
    {
        /// <summary>
        /// Convert IEnumerable of UserModel to IEnumerable of UserDto 
        /// </summary>
        public static IEnumerable<PlaceDto> ToDto(this IEnumerable<PlaceModel> places)
        {
            return places?.Select(ToDto);
        }

        /// <summary>
        /// Convert Model to Dto
        /// </summary>
        public static PlaceDto ToDto(this PlaceModel place)
        {
            List<ReviewDto> reviews = new List<ReviewDto>();

            return place == null ? null : new PlaceDto
            {
                Id = place.Id,
                Name = place.Name,
                Address = place.Address,
                PhoneNumber = place.PhoneNumber,
                Website = place.Website,
                Classification = place.Classification,
                Reviews = place.Reviews == null ? reviews : place.Reviews.ToDto().ToList()
            };
        }

        /// <summary>
        /// Convert Dto to Model
        /// </summary>
        public static PlaceModel ToModel(this PlaceDto place)
        {
            return place == null ? null : new PlaceModel
            {
                Id = place.Id,
                Name = place.Name,
                Address = place.Address,
                PhoneNumber = place.PhoneNumber,
                Website = place.Website,
                Classification = place.Classification
            };
        }

    }
}
