using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class UserRoleRepository(AppDbContext appDbContext) : BaseRepository<UserRole>(appDbContext), IUserRoleRepository
    {
    }
}
