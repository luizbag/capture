namespace Capture.Domain.Entities;

public class Note : BaseEntity
{
    public required string Title { get; set; }

    public required string Content { get; set; }

    public required Notebook Notebook { get; set; }

    public ICollection<Tag>? Tags { get; set; }
}