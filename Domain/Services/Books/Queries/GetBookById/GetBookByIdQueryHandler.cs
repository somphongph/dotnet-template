using Domain.Interfaces.Repositories;
using Domain.Models;
using MediatR;

namespace Domain.Services.Books.Queries.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, QueryItemResponse<GetBookByIdResponse>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public async Task<QueryItemResponse<GetBookByIdResponse>> Handle(GetBookByIdQuery req, CancellationToken cancellationToken)
        {
            var id = new Guid("");
            var userResp = await _bookRepository.GetByIdAsync(id);
            // Response
            return new QueryItemResponse<GetBookByIdResponse>()
            {
                Data = null,
                // Id = book.Id
            };
        }
    }
}

