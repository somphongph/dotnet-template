using Domain.Interfaces.Repositories;
using Domain.Models;
using MediatR;

namespace Domain.Services.ShortLinks.Queries.GetLongUrl
{
    public class GetLongUrlQueryHandler : IRequestHandler<GetLongUrlQuery, QueryItemResponse<GetLongUrlResponse>>
    {
        private readonly IShortLinkMongoRepository _mongoShortLink;

        public GetLongUrlQueryHandler(IShortLinkMongoRepository mongoShortLink)
        {
            _mongoShortLink = mongoShortLink ?? throw new ArgumentNullException(nameof(mongoShortLink));
        }

        public async Task<QueryItemResponse<GetLongUrlResponse>> Handle(GetLongUrlQuery req, CancellationToken cancellationToken)
        {
            var shortLink = await _mongoShortLink.GetByShortUrlAsync(req.ShortUrl);

            var resp = new GetLongUrlResponse()
            {
                LongUrl = shortLink.LongUrl,
                ShortUrl = shortLink.ShortUrl
            };

            return new QueryItemResponse<GetLongUrlResponse>()
            {
                Data = resp
            };
        }
    }
}