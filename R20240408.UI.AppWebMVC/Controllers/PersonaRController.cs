using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R20240408.EntidadesDeNegocio;
using R20240408.LogicaDeNegocio;

namespace R20240408.UI.AppWebMVC.Controllers
{
    public class PersonaRController : Controller
    {
        readonly PersonaRBL _personaRBL;

        public PersonaRController(PersonaRBL personaRBL)
        {
            _personaRBL = personaRBL;
        }

        // GET: PersonaRController
        public async Task<ActionResult> Index(PersonaR personaR)
        {
            var personasR = await _personaRBL.Buscar(personaR);
            return View(personasR);
        }

        // GET: PersonaRController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personasR = await _personaRBL.ObtenerPorId(new PersonaR { Id = id });
            return View(personasR);
        }

        // GET: PersonaRController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaRController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaR personaR)
        {
            try
            {
                await _personaRBL.Crear(personaR);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaRController/Edit/5
        public  async Task<ActionResult> Edit(int id)
        {
            var personasR = await _personaRBL.ObtenerPorId(new PersonaR { Id = id });
            return View(personasR);
        }

        // POST: PersonaRController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaR personaR)
        {
            try
            {
                await _personaRBL.Modificar(personaR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaRController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personasR = await _personaRBL.ObtenerPorId(new PersonaR { Id = id });
            return View(personasR);
            
        }

        // POST: PersonaRController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaR personaR)
        {
            try
            {
                await _personaRBL.Eliminar(personaR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
