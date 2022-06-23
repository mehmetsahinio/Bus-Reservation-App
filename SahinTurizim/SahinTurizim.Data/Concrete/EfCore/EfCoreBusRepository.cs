using System;
using System.Linq;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreBusRepository : EfCoreGenericRepository<Bus, SahinTurizimContext>, IBusRepository
    {
        public int GetSeatCapacity(int id)
        {
            using (var context=new SahinTurizimContext())
            {
                var busCapacity = context.Buses.Where(i => i.BusId == id).Select(i => i.SeatCapasite).FirstOrDefault();
                return busCapacity;
            }
        }
    }
}
