using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
   public interface IWizytaRepository
    {
        WizytaModel Get(int wizytaId);
        IQueryable<WizytaModel> GetAllActive();

        void Add(WizytaModel wizyta);

        void Update(int wizytaId, WizytaModel wizyta);

        void Deleate(int wizytaId);
    }
}
