using System.ComponentModel.DataAnnotations;
using Domain.Models;
using MediatR;

namespace Domain.Services.ShortLinks.Commands.CreateShortUrl
{
    public class CreateShortUrlCommand : IRequest<CommandResponse<CreateShortUrlResponse>>
    {
        [Required]
        public string LongUrl { get; set; } = String.Empty;
    }
}