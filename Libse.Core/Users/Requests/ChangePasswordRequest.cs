namespace Libse.Core.Users.Requests;

public readonly record struct ChangePasswordRequest(
    string OldPassword,
    string NewPassword
);