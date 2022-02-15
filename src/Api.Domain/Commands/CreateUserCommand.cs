using Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BrithDate { get; set; }
    }
}
