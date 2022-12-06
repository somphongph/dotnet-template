using Domain.Models;
using Domain.Services.Books.Queries.GetBookAll;
using MediatR;

namespace Domain.Services.Books.Queries.GetBookList
{
    public class GetBookListQuery : IRequest<QueryListResponse<GetBookListResponse>>
    {

    }
}