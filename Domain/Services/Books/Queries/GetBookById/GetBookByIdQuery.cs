using Domain.Models;
using MediatR;

namespace Domain.Services.Books.Queries.GetBookById
{
    public class GetBookByIdQuery : IRequest<QueryItemResponse<GetBookByIdResponse>>
    {

    }
}