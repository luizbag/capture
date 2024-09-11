namespace Capture.Domain.Entities;

public class Notebook : BaseEntity
{
    public required string Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Note>? Notes { get; set; }
}