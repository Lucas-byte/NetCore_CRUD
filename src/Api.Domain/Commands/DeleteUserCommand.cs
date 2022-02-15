using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class DeleteUserCommand : IRequest
    {
        public int Id { get; set; }
    }
}
