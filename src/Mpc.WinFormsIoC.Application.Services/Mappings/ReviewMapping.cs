using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mpc.WinFormsIoC.Application.Services.Mappings
{
    public static class ReviewMapping
    {
        /// <summary>
        /// Convert IEnumerable of UserModel to IEnumerable of UserDto 
        /// </summary>
        public static IEnumerable<ReviewDto> ToDto(this IEnumerable<ReviewModel> reviews)
        {
            return reviews?.Select(ToDto);
        }

        /// <summary>
        /// Convert Model to Dto
        /// </summary>
        public static ReviewDto ToDto(this ReviewModel review)
        {
            var place = review.Place;
            var user = review.User;

            return review == null ? null : new ReviewDto
            {
                Id = review.Id,
                PlaceId = review.PlaceId,
                UserId = review.UserId,
                Classification = review.Classification,
                Comments = review.Comments,
                PlaceName = place == null ? string.Empty : place.Name,
                Username = user == null ? string.Empty : user.Username
            };
        }

        /// <summary>
        /// Convert IEnumerable of UserDto to IEnumerable of UserModel 
        /// </summary>
        public static IEnumerable<ReviewModel> ToModel(this IEnumerable<ReviewDto> reviews)
        {
            return reviews?.Select(ToModel);
        }

        /// <summary>
        /// Convert Dto to Model
        /// </summary>
        public static ReviewModel ToModel(this ReviewDto review)
        {
            return review == null ? null : new ReviewModel
            {
                PlaceId = review.PlaceId,
                UserId = review.UserId,
                Classification = review.Classification,
                Comments = review.Comments
            };
        }
    }
}
