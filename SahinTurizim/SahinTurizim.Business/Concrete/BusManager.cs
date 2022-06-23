using System;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Data.Abstract;

namespace SahinTurizim.Business.Concrete
{
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public int GetSeatCapacity(int id)
        {
            return _busRepository.GetSeatCapacity(id);
        }
    }
}
