using Capture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Capture.Infrastructure.Context;

public class CaptureContext : DbContext
{
    public DbSet<Notebook> Notebooks { get; set; }

    public DbSet<Note> Notes { get; set; }

    public DbSet<Tag> Tags { get; set; }
}