using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController(IUserRoleService userRoleService) : ControllerBase
    {
        private readonly IUserRoleService _userRoleService = userRoleService;

        [HttpGet]
        public async Task<IEnumerable<UserRoleDto>> Get()
        {
            return await this._userRoleService.GetAllUserRoleServiceAsync();
        }

        [HttpGet]
        public async Task<UserRoleDto> Get(int id)
        {
            return await this._userRoleService.GetUserRoleByIdServiceAsync(id);
        }

        [HttpPost]
        public async Task<int> Post(UserRoleDto userRoleDto)
        {
            return await this._userRoleService.AddUserRoleServiceAsync(userRoleDto);
        }

        [HttpPut]
        public async Task<int> Put(UserRoleDto userRoleDto)
        {
            return await this._userRoleService.UpdateUserRoleServiceAsync(userRoleDto);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await this._userRoleService.DeleteUserRoleServiceAsync(id);
        }
    }
}
