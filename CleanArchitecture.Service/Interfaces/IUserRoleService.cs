using CleanArchitecture.DataTransferObject.Dto;

namespace CleanArchitecture.Service.Interfaces
{
    public interface IUserRoleService
    {
        Task<IEnumerable<UserRoleDto>> GetAllUserRoleServiceAsync();
        Task<UserRoleDto> GetUserRoleByIdServiceAsync(int id);
        Task<int> AddUserRoleServiceAsync(UserRoleDto userRoleDto);
        Task<int> UpdateUserRoleServiceAsync(UserRoleDto userRoleDto);
        Task<int> DeleteUserRoleServiceAsync(int id);
    }
}
