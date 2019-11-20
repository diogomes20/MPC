using System.Collections.Generic;

namespace Mpc.WinFormsIoC.Application.Dto
{
    public class CountryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public List<UserDto> Users { get; set; }
    }
}
