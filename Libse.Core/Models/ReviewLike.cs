namespace Libse.Core.Models;

public record struct ReviewLike(
    Guid ReviewId,
    Guid UserId
);