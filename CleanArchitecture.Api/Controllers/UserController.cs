using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await this._userService.GetAllUserServiceAsync();
        }

        [HttpGet]
        public async Task<UserDto> Get(int id)
        {
            return await this._userService.GetUserByIdServiceAsync(id);
        }

        [HttpPost]
        public async Task<int> Post(UserDto userDto)
        {
            return await this._userService.AddUserServiceAsync(userDto);
        }

        [HttpPut]
        public async Task<int> Put(UserDto userDto)
        {
            return await this._userService.UpdateUserServiceAsync(userDto);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await this._userService.DeleteUserServiceAsync(id);
        }
    }
}
