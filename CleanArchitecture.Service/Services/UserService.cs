using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> AddUserServiceAsync(UserDto userDto)
        {
            var entity = this._mapper.Map<User>(userDto);
            return await this._userRepository.AddAsync(entity);
        }

        public async Task<int> DeleteUserServiceAsync(int id)
        {
            return await this._userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserDto>> GetAllUserServiceAsync()
        {
            return this._mapper.Map<IEnumerable<UserDto>>(await this._userRepository.GetAllAsync());
        }

        public async Task<UserDto> GetUserByIdServiceAsync(int id)
        {
            return this._mapper.Map<UserDto>(await this._userRepository.GetByIdAsync(id));
        }

        public async Task<int> UpdateUserServiceAsync(UserDto userDto)
        {
            var entity = this._mapper.Map<User>(userDto);
            return await this._userRepository.UpdateAsync(entity);
        }
    }
}
