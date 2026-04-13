using Riok.Mapperly.Abstractions;
using Spotify.Contract.Abstractions.Shared;
using Spotify.Domain.Entities;
using V1Response = Spotify.Contract.Services.Product.Response;

namespace Spotify.Application.Mapper;

[Mapper]
public partial class ServiceMapper 
{
    public partial V1Response.ProductResponse ToV1ProductResponse(Product product);
    public partial Product ToProduct(V1Response.ProductResponse response);
    public partial PagedResult<V1Response.ProductResponse> ToV1PagedProductResponse(PagedResult<Product> source);
    public partial PagedResult<Product> ToPagedProduct(PagedResult<V1Response.ProductResponse> source);
}
