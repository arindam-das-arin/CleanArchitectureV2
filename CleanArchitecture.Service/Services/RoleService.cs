using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;
using CleanArchitecture.Service.Interfaces;

namespace CleanArchitecture.Service.Services
{
    public class RoleService(IRoleRepository roleRepository, IMapper mapper) : IRoleService
    {
        private readonly IRoleRepository _roleRepository = roleRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> AddRoleServiceAsync(RoleDto roleDto)
        {
            var entity = this._mapper.Map<Role>(roleDto);
            return await this._roleRepository.AddAsync(entity);
        }

        public async Task<int> DeleteRoleServiceAsync(int id)
        {
            return await this._roleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<RoleDto>> GetAllRoleServiceAsync()
        {
            return this._mapper.Map<IEnumerable<RoleDto>>(await this._roleRepository.GetAllAsync());
        }

        public async Task<RoleDto> GetRoleByIdServiceAsync(int id)
        {
            return this._mapper.Map<RoleDto>(await this._roleRepository.GetByIdAsync(id));
        }

        public async Task<int> UpdateRoleServiceAsync(RoleDto roleDto)
        {
            var entity = this._mapper.Map<Role>(roleDto);
            return await this._roleRepository.UpdateAsync(entity);
        }
    }
}
