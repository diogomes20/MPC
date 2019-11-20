using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Domain.Models
{
    public class PlaceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Website { get; set; }

        public double Classification { get; set; }

        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
