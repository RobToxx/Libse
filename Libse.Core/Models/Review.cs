namespace Libse.Core.Models;

public record struct Review(
    Guid Id,
    byte Rating,
    string Comment,
    DateOnly Date,
    Guid BookId,
    Guid UserId
);