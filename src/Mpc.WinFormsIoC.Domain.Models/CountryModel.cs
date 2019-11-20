using System.Collections.Generic;

namespace Mpc.WinFormsIoC.Domain.Models
{
    public class CountryModel
    {
        public string Alias { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserModel> Users { get; set; }
    }
}
