using CommandBlazorApp.Models;

namespace CommandBlazorApp.Components.Commands
{
    public class EditarLibroCommand : Command
    {
        private readonly Libro _libro;
        private readonly AppDbContext _dbContext;

        public EditarLibroCommand(Libro libro, AppDbContext dbContext)
        {
            _libro = libro;
            _dbContext = dbContext;
        }

        public override void Execute()
        {
            _dbContext.Libros.Update(_libro);
            _dbContext.SaveChanges();
        }
    }
}
