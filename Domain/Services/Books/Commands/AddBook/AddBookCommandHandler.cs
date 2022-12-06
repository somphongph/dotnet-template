using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MediatR;

namespace Domain.Services.Books.Commands.AddBook
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, CommandResponse>
    {
        private readonly IBookRepository _bookRepository;

        public AddBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public async Task<CommandResponse> Handle(AddBookCommand req, CancellationToken cancellationToken)
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