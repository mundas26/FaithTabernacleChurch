using Ftc.Models;

namespace Ftc.DataAccess.Repository.IRepository
{
    public interface IEventRepository : IRepository<Event>
    {
        void Update(Event obj);
    }
}
