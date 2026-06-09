namespace Libse.Core.Shared;

public interface IError {
    string Message { get; }
}

public readonly record struct Error<E>(
    E Type,
    string Message
): IError;