using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class LoginUserCommand : IRequest<object>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
