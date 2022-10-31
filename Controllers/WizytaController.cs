using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    public class WizytaController : Controller
    {

        private readonly IWizytaRepository _wizytaRepository;

        public WizytaController(IWizytaRepository wizytaRepository)
        {
            _wizytaRepository = wizytaRepository;
        }

        // GET: WizytaController
        public ActionResult Index()
        {
            
            return View(_wizytaRepository.GetAllActive());
        }

        // GET: WizytaController/Details/5
        public ActionResult Details(int id)
        {
            return View(_wizytaRepository.Get(id));
        }

        private List<WyborWizytaModel> GetWizyty()
        {
            var wizyty = new List<WyborWizytaModel>();
            wizyty.Add(new WyborWizytaModel() { Id = "Rezonans Magnetyczny", Nazwa = "Rezonans Magnetyczny" });
            wizyty.Add(new WyborWizytaModel() { Id = "EKG", Nazwa = "EKG" });
            wizyty.Add(new WyborWizytaModel() { Id = "RTG", Nazwa = "RTG" });
            wizyty.Add(new WyborWizytaModel() { Id = "Tomografia Komputerowa", Nazwa = "Tomografia Komputerowa" });
            wizyty.Add(new WyborWizytaModel() { Id = "Wstawianie zastawki serca", Nazwa = "Wstawianie zastawki serca" });

            return wizyty;
        }

        // GET: WizytaController/Create
        public ActionResult Create()
        {
            ViewBag.WyborWizyty = new SelectList(GetWizyty(), "Id", "Nazwa");
            return View(new WizytaModel());
        }

        // POST: WizytaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WizytaModel wizytaModel)
        {
            ViewBag.WyborWizyty = new SelectList(GetWizyty(), "Id", "Nazwa");
            _wizytaRepository.Add(wizytaModel);
                return RedirectToAction(nameof(Index));
            
           
        }

        // GET: WizytaController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.WyborWizyty = new SelectList(GetWizyty(), "Id", "Nazwa");
            return View(_wizytaRepository.Get(id));
        }

        // POST: WizytaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WizytaModel wizytaModel)
        {
            ViewBag.WyborWizyty = new SelectList(GetWizyty(), "Id", "Nazwa");
            _wizytaRepository.Update(id, wizytaModel);


                return RedirectToAction(nameof(Index));
            
           
        }

        // GET: WizytaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_wizytaRepository.Get(id));
        }

        // POST: WizytaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {

            _wizytaRepository.Deleate(id);

                return RedirectToAction(nameof(Index));
           
           
        }
    }
}
