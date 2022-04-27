using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HAPPYWeb.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HAPPYWeb.view.Controllers
{
    public class ProdutosController : Controller
    {
        DB_HAPPYContext odb;
        public ProdutosController()
        {
            odb = new DB_HAPPYContext();
        }


        // GET: ProdutosController
        public ActionResult Index()
        {
            var retorno = odb.Tbprodutos.Include(e => e.IdMarcaNavigation).AsNoTracking();
            return View(retorno);
        }


        // GET: Details
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Create
        public ActionResult Create()
        {
            var Lista = new SelectList(odb.Tbmarca.ToList(), "Id", "Descricao");
            ViewBag.ListaMarcas = Lista;
            return View();
        }


        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tbprodutos oProd)
        {
            try
            {
                odb.Tbprodutos.Add(oProd);
                odb.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Edit
        public ActionResult Edit(int id)
        {
            Tbprodutos oProd = odb.Tbprodutos.Find(id);
            var Lista = new SelectList(odb.Tbmarca.ToList(), "Id", "Descricao",oProd.IdMarca);
            ViewBag.ListaMarcas = Lista;
            return View(oProd);
        }


        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tbprodutos oProd)
        {
            odb.Entry(oProd).State = EntityState.Modified;
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
            Tbprodutos oProd = odb.Tbprodutos.Find(id);
            odb.Entry(oProd).State = EntityState.Deleted;
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
