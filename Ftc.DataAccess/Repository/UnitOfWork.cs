using Ftc.DataAccess.Data;
using Ftc.DataAccess.Repository.IRepository;

namespace Ftc.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IEventRepository Event { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Event = new EventRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges(); 
        }
    }
}
