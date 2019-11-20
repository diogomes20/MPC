using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Application.Dto
{
    public class PlaceDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Website { get; set; }

        public double Classification { get; set; }

        public List<ReviewDto> Reviews { get; set; }
    }
}
