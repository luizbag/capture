using Capture.Domain.Entities;
using MediatR;

namespace Capture.Application.Command;

public class CreateNotebookCommand : IRequest<Notebook>
{
    public required Notebook Notebook { get; set; }
}
