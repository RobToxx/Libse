namespace Libse.Core.Models;

public record struct Loan(
    Guid Id,
    DateTime Date,
    DateOnly DueDate,
    DateTime? ReturnDate,
    Guid BookId,
    Guid UserId
);