namespace Libse.Core.Users.Requests;

public readonly record struct RegisterRequest(
    string Email,
    string Password,
    string Name,
    string Surname,
    string Phone
);