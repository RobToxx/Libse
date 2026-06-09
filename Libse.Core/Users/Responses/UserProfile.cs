namespace Libse.Core.Users.Responses;

public readonly record struct UserProfile(
    string Name,
    string Surname,
    string Email,
    string Phone,
    bool IsActive
);