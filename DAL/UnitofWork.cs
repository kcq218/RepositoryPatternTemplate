namespace DAL
{
    public class UnitofWork : IUnitofWork
    {
        // replace with actual context from Entity Framework.
        //private DbContext _context = new DbContext();

        // replace with actual Repositories from Entity Framework tables.
        //public IRepository<T> placeholderRepository => new Repository<T>(_context);

        public void Save()
        {
            //_context.SaveChanges();
        }

        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //_context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}