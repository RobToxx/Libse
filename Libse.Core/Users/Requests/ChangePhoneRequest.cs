namespace Libse.Core.Users.Requests;

public readonly record struct ChangePhoneRequest(
    string Password,
    string NewPhone
);