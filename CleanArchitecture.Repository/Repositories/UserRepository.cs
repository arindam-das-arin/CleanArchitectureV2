using CleanArchitecture.Entity.Context;
using CleanArchitecture.Entity.Models;
using CleanArchitecture.Repository.Interfaces;

namespace CleanArchitecture.Repository.Repositories
{
    public class UserRepository(AppDbContext appDbContext) : BaseRepository<User>(appDbContext), IUserRepository
    {
    }
}
