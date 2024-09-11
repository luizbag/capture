using Capture.Domain.Entities;
using Capture.Domain.Repositories;
using MediatR;

namespace Capture.Application.Command.Handler;

public class CreateNotebookCommandHandler(INotebookRepository notebookRepository) : IRequestHandler<CreateNotebookCommand, Notebook>
{
    public Task<Notebook> Handle(CreateNotebookCommand request, CancellationToken cancellationToken)
    {
        return notebookRepository.CreateAsync(request.Notebook);
    }
}
