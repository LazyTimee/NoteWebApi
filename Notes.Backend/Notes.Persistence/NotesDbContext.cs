using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConf;

namespace Notes.Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConf());
            base.OnModelCreating(builder);
        }
    }
}