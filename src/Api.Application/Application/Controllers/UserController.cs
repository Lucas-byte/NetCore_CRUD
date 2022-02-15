using Core.Interfaces;
using Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUserService _userService;
        public UserController(IMediator mediator,
            IUserService userService)
        {
            _mediator = mediator;
            _userService = userService;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetSelectUsers();

            return Ok(result);
        }

        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _userService.GetUserById(id);

            return Ok(result);
        }

        [Authorize("Bearer")]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromForm] CreateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [Authorize("Bearer")]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromForm] UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [Authorize("Bearer")]
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteUserCommand command)
        {
            await _mediator.Send(command);

            return Ok(true);
        }
    }
}
