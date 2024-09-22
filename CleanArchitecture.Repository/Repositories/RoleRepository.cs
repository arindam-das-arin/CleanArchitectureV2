using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class RoleRepository(AppDbContext appDbContext) : BaseRepository<Role>(appDbContext), IRoleRepository
    {
    }
}
