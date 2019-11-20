using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Application.Dto
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public int UserId { get; set; }

        public int Classification { get; set; }

        public string Comments { get; set; }

        public string PlaceName { get; set; }

        public string Username { get; set; }
    }
}
