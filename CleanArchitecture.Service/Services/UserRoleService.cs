using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class UserRoleService(IUserRoleRepository userRoleRepository, IMapper mapper) : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository = userRoleRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> AddUserRoleServiceAsync(UserRoleDto userRoleDto)
        {
            var entity = this._mapper.Map<UserRole>(userRoleDto);
            return await this._userRoleRepository.AddAsync(entity);
        }

        public async Task<int> DeleteUserRoleServiceAsync(int id)
        {
            return await this._userRoleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserRoleDto>> GetAllUserRoleServiceAsync()
        {
            return this._mapper.Map<IEnumerable<UserRoleDto>>(await this._userRoleRepository.GetAllAsync());
        }

        public async Task<UserRoleDto> GetUserRoleByIdServiceAsync(int id)
        {
            return this._mapper.Map<UserRoleDto>(await this._userRoleRepository.GetByIdAsync(id));
        }

        public Task<int> UpdateUserRoleServiceAsync(UserRoleDto userRoleDto)
        {
            var entity = this._mapper.Map<UserRole>(userRoleDto);
            return this._userRoleRepository.UpdateAsync(entity);
        }
    }
}
