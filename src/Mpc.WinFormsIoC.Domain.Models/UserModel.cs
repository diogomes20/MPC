using System.Collections.Generic;

namespace Mpc.WinFormsIoC.Domain.Models
{
    public class UserModel
    {
        public string Email { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public int PaisId { get; set; }

        public virtual CountryModel Pais { get; set; }

        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
