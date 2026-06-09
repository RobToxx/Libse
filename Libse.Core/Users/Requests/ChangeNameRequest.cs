namespace Libse.Core.Users.Requests;

public readonly record struct ChangeNameRequest(
    string Password,
    string NewName,
    string NewSurname
);