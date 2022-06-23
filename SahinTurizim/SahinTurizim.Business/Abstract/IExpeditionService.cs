using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface IExpeditionService
    {
        Expedition GetById(int id);
        List<Expedition> GetAll();
        void Create(Expedition entity);
        void Update(Expedition entity);
        void Delete(Expedition entity);

        List<Expedition> GetExpeditionRoute(string startTerminal, string endTerminal, string date);
        Expedition GetExpeditionDetails(int id);
    }
}
