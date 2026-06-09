namespace Libse.Core.Models;

public record struct User(
    Guid Id,
    string Name,
    string Surname,
    string Email,
    string Phone,
    string Password,
    bool IsActive
);