using Ftc.DataAccess.Data;
using Ftc.DataAccess.Repository.IRepository;
using Ftc.Models;

namespace Ftc.DataAccess.Repository
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly ApplicationDbContext _db;
        public EventRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Event obj)
        {
            _db.Events.Update(obj);
        }
    }
}
