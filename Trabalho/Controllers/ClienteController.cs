using Projeto.Context;
using Projeto.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Trabalho.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto _contexto = new Contexto();

        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = _contexto.Clientes.ToList();
            return View(clientes);
        }

        [HttpGet]
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cliente cliente = _contexto.Clientes.Where(c => c.Id == id).FirstOrDefault();

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Cliente cliente = _contexto.Clientes.Find(id);
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}