using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MediatR;

namespace Domain.Services.Books.Commands.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, CommandResponse>
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public async Task<CommandResponse> Handle(UpdateBookCommand req, CancellationToken cancellationToken)
        {
            var book = new Book()
            {
                Title = "",
                Name = ""
            };

            await _bookRepository.AddAsync(book);

            // Response
            return new CommandResponse()
            {
                Success = true,
                // Id = book.Id
            };
        }
    }
}