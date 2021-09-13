using CRUD.Core.Models;
using System;

namespace CRUD.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IBaseRepo<Author> Authors { get; }
        IBaseRepo<Book> Books { get; }
        int Save();
    }
}
