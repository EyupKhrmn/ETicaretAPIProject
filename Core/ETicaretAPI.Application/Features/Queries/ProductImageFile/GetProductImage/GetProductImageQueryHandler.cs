using MediatR;

namespace ETicaretAPI.Application.ValidatonRules.ProductImageFile.GetProductImage;

public class GetProductImageQueryHandler : IRequestHandler<GetProductImageQueryRequest,GetProductImageQueryResponse>
{
    public async Task<GetProductImageQueryResponse> Handle(GetProductImageQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}