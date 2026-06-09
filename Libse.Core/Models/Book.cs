namespace Libse.Core.Models;

public record struct Book(
    Guid Id,
    string Title,
    string Description,
    string Isbn,
    DateOnly PublishDate,
    string ImageUrl,
    int Stock
);