using Libse.Core.Models;
using Libse.Core.Shared;
using Libse.Core.Users.Responses;

namespace Libse.Core.Users;

public interface IUserRepository {
    Task<Error<DbError>?> Create(User user);
    Task<User?> GetById(Guid id);
    Task<User?> GetByEmail(string email);
    Task<UserProfile?> GetProfile(Guid id);
    Task<bool> Exists(string email);
    Task<(bool? Updated, Error<DbError>? Err)> UpdateActive(Guid id, bool active);
    Task<bool?> IsActive(Guid id);
    Task<(bool? Updated, Error<DbError>? Err)> UpdatePassword(Guid id, string password);
    Task<(bool? Updated, Error<DbError>? Err)> UpdateEmail(Guid id, string email);
    Task<(bool? Updated, Error<DbError>? Err)> UpdateName(Guid id, string name, string surname);
    Task<(bool? Updated, Error<DbError>? Err)> UpdatePhone(Guid id, string phone);
}