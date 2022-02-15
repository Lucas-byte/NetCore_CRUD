using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BrithDate { get; set; }
    }
}
