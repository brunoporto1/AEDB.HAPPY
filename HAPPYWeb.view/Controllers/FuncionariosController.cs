using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HAPPYWeb.model;
using Microsoft.EntityFrameworkCore;

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

        // GET: Details
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Create
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
            return View(oOficial);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tboficial oOficial)
        {
            odb.Entry(oOficial).State = EntityState.Modified;
            odb.SaveChanges();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Delete
        public ActionResult Delete(int id)
        {
            Tboficial oOficial = odb.Tboficial.Find(id);
            odb.Entry(oOficial).State = EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // POST: Delete
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
