using AulasRazorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulasRazorMVC.Controllers
{
    public class DiscoController : Controller
    {
        private static DiscoDados discoDados = new DiscoDados();
        // GET: Disco
        public ActionResult Index()
        {
            return View(discoDados.listaDisco);
        }

        public ActionResult AdicionaDisco()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaDisco(Disco discos)
        {
            discoDados.CriaDiscos(discos);
            return RedirectToAction("Index", "Disco", discoDados);
            //return View();
        }

        //GET:
        public ActionResult ApagaDisco(string id)
        {
            try
            {
                if(discoDados.ApagaDisco(id))
                {
                    ViewBag.AlertMsg = "Disco não existente.";
                }
                return RedirectToAction("Index", "Disco", discoDados);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AtualizaDisco(string id)
        {
            return View(discoDados.listaDisco.Find(discoDados => discoDados.disco == id));
        }
        //Post
        [HttpPost]
        public ActionResult AtualizaDisco(Disco discos)
        {
            discoDados.AtualizaDisco(discos);
            return RedirectToAction("Index", "Disco", discoDados);
        }
    }
}