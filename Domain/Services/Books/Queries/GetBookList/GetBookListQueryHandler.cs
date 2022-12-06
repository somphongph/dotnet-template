using Domain.Interfaces.Repositories;
using Domain.Models;
using Domain.Services.Books.Queries.GetBookAll;
using MediatR;

namespace Domain.Services.Books.Queries.GetBookList
{
    public class GetBookListQueryHandler : IRequestHandler<GetBookListQuery, QueryListResponse<GetBookListResponse>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookListQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public async Task<QueryListResponse<GetBookListResponse>> Handle(GetBookListQuery req, CancellationToken cancellationToken)
        {
            var userResp = await _bookRepository.GetAllAsync();

            // Response
            return new QueryListResponse<GetBookListResponse>()
            {
                Data = null,
                // Id = book.Id
            };
        }
    }
}