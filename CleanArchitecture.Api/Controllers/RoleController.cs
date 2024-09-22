using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(IRoleService roleService) : ControllerBase
    {
        private readonly IRoleService _roleService = roleService;

        [HttpGet]
        public async Task<IEnumerable<RoleDto>> Get()
        {
            return await this._roleService.GetAllRoleServiceAsync();
        }

        [HttpGet]
        public async Task<RoleDto> Get(int id)
        {
            return await this._roleService.GetRoleByIdServiceAsync(id);
        }

        [HttpPost]
        public async Task<int> Post(RoleDto roleDto)
        {
            return await this._roleService.AddRoleServiceAsync(roleDto);
        }

        [HttpPut]
        public async Task<int> Put(RoleDto roleDto)
        {
            return await this._roleService.UpdateRoleServiceAsync(roleDto);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await this._roleService.DeleteRoleServiceAsync(id);
        }
    }
}
