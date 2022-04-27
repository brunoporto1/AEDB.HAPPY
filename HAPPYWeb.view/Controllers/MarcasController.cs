using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HAPPYWeb.model;
using Microsoft.EntityFrameworkCore;

namespace HAPPYWeb.view.Controllers
{
    public class MarcasController : Controller
    {
        DB_HAPPYContext odb;
        public MarcasController()
        {
            odb = new DB_HAPPYContext();

        }      


        // GET: MarcasController
        public ActionResult Index()
        {
            List<Tbmarca> oLista = odb.Tbmarca.ToList();
            return View(oLista);
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
        public ActionResult Create(Tbmarca oMar)
        {
            odb.Tbmarca.Add(oMar);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Edit
        public ActionResult Edit(int id)
        {
            Tbmarca oMar = odb.Tbmarca.Find(id);
            return View(oMar);
        }


        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tbmarca oMar)
        {
            odb.Entry(oMar).State = EntityState.Modified;
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
            Tbmarca oMar = odb.Tbmarca.Find(id);
            odb.Entry(oMar).State = EntityState.Deleted;
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
