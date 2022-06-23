using System;
using System.Collections.Generic;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Concrete
{
    public class ExpeditionManager : IExpeditionService
    {
        private IExpeditionRepository _expeditionRepository;

        public ExpeditionManager(IExpeditionRepository expeditionRepository)
        {
            _expeditionRepository = expeditionRepository;
        }

        public void Create(Expedition entity)
        {
            _expeditionRepository.Create(entity);
        }

        public void Delete(Expedition entity)
        {
            _expeditionRepository.Delete(entity);
        }

        public List<Expedition> GetAll()
        {
           return _expeditionRepository.GetAll();
        }

        public Expedition GetById(int id)
        {
            return _expeditionRepository.GetById(id);
        }

        public Expedition GetExpeditionDetails(int id)
        {
            return _expeditionRepository.GetExpeditionDetails(id);
        }

        public List<Expedition> GetExpeditionRoute(string startTerminal, string endTerminal, string date)
        {
            return _expeditionRepository.GetExpeditionRoute(startTerminal, endTerminal, date);
        }

       

        public void Update(Expedition entity)
        {
            _expeditionRepository.Update(entity);

        }
    }
}
