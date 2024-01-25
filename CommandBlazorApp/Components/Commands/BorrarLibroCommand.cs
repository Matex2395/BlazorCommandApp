using CommandBlazorApp.Models;

namespace CommandBlazorApp.Components.Commands
{
    public class BorrarLibroCommand : Command
    {
        private readonly Libro _libro;
        private readonly AppDbContext _dbContext;

        public BorrarLibroCommand(Libro libro, AppDbContext dbContext)
        {
            _libro = libro;
            _dbContext = dbContext;
        }

        public override void Execute()
        {
            _dbContext.Libros.Remove(_libro);
            _dbContext.SaveChanges();
        }
    }

}
