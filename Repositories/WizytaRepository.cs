using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    class WizytaRepository : IWizytaRepository
    {
        private readonly WizytaManagerContext _context;

        public WizytaRepository(WizytaManagerContext context)
        {
            _context = context;
        }

        public WizytaModel Get(int wizytaId)
            => _context.Wizyty.SingleOrDefault(x => x.WizytaId == wizytaId);

        public IQueryable<WizytaModel> GetAllActive()
            => _context.Wizyty.Where(x => x.WizytaId >= 0);
        

        public void Add(WizytaModel wizyta)
        {
            _context.Wizyty.Add(wizyta);
            _context.SaveChanges();
        }

        public void Update(int wizytaId, WizytaModel wizyta)
        {
            var result = _context.Wizyty.SingleOrDefault(x => x.WizytaId == wizytaId);

            if(result != null)
            {
                result.Nazwa = wizyta.Nazwa;
                result.JoinDate = wizyta.JoinDate;
                result.OpisBadania = result.OpisBadania;
                result.ImiePacjenta = result.ImiePacjenta;
                result.NazwiskoPacjenta = result.NazwiskoPacjenta;
                result.PeselPacjenta = result.PeselPacjenta;

                _context.SaveChanges();
            }
        }

        public void Deleate(int wizytaId)
        {
            var result = _context.Wizyty.SingleOrDefault(x => x.WizytaId==wizytaId);

            if (result != null)
            {
                _context.Wizyty.Remove(result);
                _context.SaveChanges();
            }
        }

      

       

       
    }
}
