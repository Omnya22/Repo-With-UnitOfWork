using CRUD.Core.Interfaces;
using CRUD.Core.Models;

namespace CRUD.EF.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;

        public IBaseRepo<Author> Authors { get; private set; }

        public IBaseRepo<Book> Books { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Authors = new BaseRepo<Author>(_context);
            Books = new BaseRepo<Book>(_context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
