namespace Spotify.Domain.Exceptions;

public abstract class ProductException : NotFoundException
{
    protected ProductException(Guid productId)
        : base($"The product with the id {productId} was not found.")
    {
    }
}
    