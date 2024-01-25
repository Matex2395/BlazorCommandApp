namespace CommandBlazorApp.Components.Commands
{
    public class DetallesLibroCommand : Command
    {
        private readonly int _libroId;
        private readonly AppDbContext _dbContext;

        public DetallesLibroCommand(int libroId, AppDbContext dbContext)
        {
            _libroId = libroId;
            _dbContext = dbContext;
        }

        public override void Execute()
        {
            var libro = _dbContext.Libros.Find(_libroId);
            // Haz algo con el libro...
        }
    }

}
