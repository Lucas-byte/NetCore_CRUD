using AutoMapper;
using Domain.Commands;
using Domain.Dtos;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.CommandsHandlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserDto>
    {
        private readonly IUserRepositoryEF _userRepository;
        private readonly IMapper _mapper;
        public UpdateUserHandler(IUserRepositoryEF userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userEf = await _userRepository.GetById(request.Id);

            userEf.Name = request.Name;
            userEf.Email = request.Email;
            userEf.BrithDate = request.BrithDate;

            await _userRepository.Update(userEf);

            return _mapper.Map<UserDto>(userEf);
        }
    }
}
