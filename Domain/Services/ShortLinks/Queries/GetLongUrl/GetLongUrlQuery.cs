using System.ComponentModel.DataAnnotations;
using Domain.Models;
using MediatR;

namespace Domain.Services.ShortLinks.Queries.GetLongUrl
{
    public class GetLongUrlQuery : IRequest<QueryItemResponse<GetLongUrlResponse>>
    {
        [Required]
        public string ShortUrl { get; set; } = String.Empty;
    }
}