using CommandBlazorApp.Models;

namespace CommandBlazorApp.Components.Commands
{
    public class AgregarLibroCommand : Command
    {
        private readonly Libro _libro;
        private readonly AppDbContext _dbContext;

        public AgregarLibroCommand(Libro libro, AppDbContext dbContext)
        {
            _libro = libro;
            _dbContext = dbContext;
        }

        public override void Execute()
        {
            _dbContext.Libros.Add(_libro);
            Console.WriteLine($"Guardando libro con título '{_libro.Titulo}' y autor '{_libro.Autor}'.");
            _dbContext.SaveChanges();
        }
    }

}
