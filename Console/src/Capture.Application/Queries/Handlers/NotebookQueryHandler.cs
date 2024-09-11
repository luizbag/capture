using Capture.Domain.Entities;
using Capture.Domain.Repositories;
using MediatR;

namespace Capture.Application.Queries.Handlers;

public class NotebookQueryHandler(INotebookRepository notebookRepository) : IRequestHandler<NotebookQuery, ICollection<Notebook>>
{
    public Task<ICollection<Notebook>> Handle(NotebookQuery request, CancellationToken cancellationToken)
    {
        return notebookRepository.GetAllAsync();
    }
}
