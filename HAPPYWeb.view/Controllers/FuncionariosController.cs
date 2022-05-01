using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HAPPYWeb.model;
namespace HAPPYWeb.view.Controllers
{
    public class FuncionariosController : Controller
    {
        DB_HAPPYContext odb;
        public FuncionariosController()
        {
            odb = new DB_HAPPYContext();
        }

        // GET: FuncionariosController
        public ActionResult Index()
        {
            List<Tboficial> oList = odb.Tboficial.ToList();
            return View(oList);
        }

        // GET: FuncionariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuncionariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tboficial oOficial)
        {
            odb.Tboficial.Add(oOficial);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            Tboficial oOficial = odb.Tboficial.Find(id);
            return View();
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tboficial oOficial)
        {
            var oOficialBanco = odb.Tboficial.Find(id);
            oOficialBanco.Nome = oOficial.Nome;
            odb.Entry(oOficialBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: FuncionariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FuncionariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
