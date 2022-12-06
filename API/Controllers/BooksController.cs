using System.Net;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Models;
using Domain.Services.Books.Queries.GetBookList;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;
    private readonly IMediator _mediator;

    public BooksController(ILogger<BooksController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet]
    [ProducesResponseType(typeof(QueryListResponse<GetBookListQuery>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult> GetList(GetBookListQuery query)
    {
        var res = await _mediator.Send(query);

        return Ok(res);
    }

}
