namespace Libse.Core.Users.Requests;

public readonly record struct ChangeEmailRequest(
    string Password,
    string NewEmail
);