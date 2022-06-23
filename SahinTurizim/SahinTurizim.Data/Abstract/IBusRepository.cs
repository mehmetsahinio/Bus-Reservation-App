using System;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Abstract
{
    public interface IBusRepository:IRepository<Bus>
    {
        int GetSeatCapacity(int id);
    }
}
