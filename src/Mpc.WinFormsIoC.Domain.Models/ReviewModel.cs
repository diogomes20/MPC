using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Domain.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public int UserId { get; set; }

        public int Classification { get; set; }

        public string Comments { get; set; }

        public virtual UserModel User { get; set; }

        public virtual PlaceModel Place { get; set; }
    }
}
