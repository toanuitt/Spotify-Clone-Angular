using Spotify.Contract.Abstractions.Message;
using Spotify.Contract.Abstractions.Shared;
using Spotify.Contract.Enumerations;
using static Spotify.Contract.Services.Product.Response;

namespace Spotify.Contract.Services.Product;

public static class Query
{
    public record GetProductsQuery(string? SearchTerm, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder, int PageIndex, int PageSize) : IQuery<PagedResult<ProductResponse>>;
    public record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;
}
