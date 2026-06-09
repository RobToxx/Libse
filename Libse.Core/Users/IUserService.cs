using Libse.Core.Shared;
using Libse.Core.Users.Requests;
using Libse.Core.Users.Responses;

namespace Libse.Core.Users;

public enum UserError {
    EmailAlreadyExists,
    InvalidEmail,
    InvalidPassword,
    InvalidName,
    InvalidPhone,
    UserNotFound
}

public interface IUserService {
    Task<(Guid? Id, Error<UserError>? Err)> Register(RegisterRequest request);
    Task<(UserProfile? Profile, Error<UserError>? Err)> GetProfile(Guid userId);
    Task<Error<UserError>?> SetActive(Guid userId, bool active);
    Task<Error<UserError>?> ChangePassword(Guid userId, ChangePasswordRequest request);
    Task<Error<UserError>?> ChangeEmail(Guid userId, ChangeEmailRequest request);
    Task<Error<UserError>?> ChangeName(Guid userId, ChangeNameRequest request);
    Task<Error<UserError>?> ChangePhone(Guid userId, ChangePhoneRequest request);
}