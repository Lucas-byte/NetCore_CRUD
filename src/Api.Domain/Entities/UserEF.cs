using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserEF : BaseEF
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BrithDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
