namespace DAL
{
    public interface IUnitofWork
    {
        // populate with actual types using tables that are populated by Entity Framework.
        //public IRepository<T> TRepository { get; }
        public void Save();
        public void Dispose(bool disposing);
    }
}
