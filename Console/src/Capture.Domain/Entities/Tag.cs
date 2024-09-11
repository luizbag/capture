namespace Capture.Domain.Entities;

public class Tag : BaseEntity
{
    public required string Value { get; set; }

    public string? Description { get; set; }
}