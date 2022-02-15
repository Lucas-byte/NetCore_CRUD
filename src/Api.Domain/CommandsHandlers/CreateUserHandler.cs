using AutoMapper;
using Domain.Commands;
using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.CommandsHandlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IUserRepositoryEF _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUserRepositoryEF userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userEf = new UserEF()
            {
                Name = request.Name,
                Email = request.Email,
                BrithDate = request.BrithDate,
                Password = request.Password
            };

            await _userRepository.Create(userEf);

            return _mapper.Map<UserDto>(userEf);    
        }
    }
}
