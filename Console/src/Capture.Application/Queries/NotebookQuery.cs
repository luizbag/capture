using Capture.Domain.Entities;
using MediatR;

namespace Capture.Application.Queries;

public class NotebookQuery : IRequest<ICollection<Notebook>>
{
}
