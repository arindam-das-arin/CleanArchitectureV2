using CleanArchitecture.DataTransferObject.Dto;

namespace CleanArchitecture.Service.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUserServiceAsync();
        Task<UserDto> GetUserByIdServiceAsync(int id);
        Task<int> AddUserServiceAsync(UserDto userDto);
        Task<int> UpdateUserServiceAsync(UserDto userDto);
        Task<int> DeleteUserServiceAsync(int id);
    }
}
