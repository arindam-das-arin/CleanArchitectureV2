using CleanArchitecture.DataTransferObject.Dto;

namespace CleanArchitecture.Service.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllRoleServiceAsync();
        Task<RoleDto> GetRoleByIdServiceAsync(int id);
        Task<int> AddRoleServiceAsync(RoleDto roleDto);
        Task<int> UpdateRoleServiceAsync(RoleDto roleDto);
        Task<int> DeleteRoleServiceAsync(int id);
    }
}
