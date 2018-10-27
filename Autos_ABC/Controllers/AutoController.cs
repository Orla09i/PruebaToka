using Autos_ABC.Models;
using Autos_ABC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos_ABC.Controllers
{
    public class AutoController : Controller
    {
        // GET: Aut/ObtenerAuto()    
        public ActionResult ObtenerAuto()
        {

            AutosRepository AutRepo = new AutosRepository();
            ModelState.Clear();
            return View(AutRepo.ObtenerAuto());
        }
        // GET: Auto/AgregarAuto()   
        public ActionResult AgregarAuto()
        {
            return View();
        }

        // POST: Auto/AgregarAuto  
        [HttpPost]
        public ActionResult AgregarAuto(AutoModel Auto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AutosRepository AutRep = new AutosRepository();

                    if (AutRep.AgregarAuto(Auto))
                    {
                        ViewBag.Message = "Auto agregado satisfactoriamente";
                    }
                }

                return RedirectToAction("ObtenerAuto");
            }
            catch
            {
                return RedirectToAction("ObtenerAuto");
            }
        }

        // GET:Auto/Actualizarautos/5    
        public ActionResult ActualizarAuto(int id)
        {
            AutosRepository AutRep = new AutosRepository();

            return View(AutRep.ObtenerAuto().Find(Aut => Aut.IdAuto == id));

        }

        // POST: Auto/Auctualizarauto/5    
        [HttpPost]

        public ActionResult ActualizarAuto(int id, AutoModel obj)
        {
            try
            {
                AutosRepository AutRep = new AutosRepository();

                obj.IdAuto = id;

                AutRep.ActualizarAuto(obj);

                return RedirectToAction("ObtenerAuto");
            }
            catch
            {
                return View();
            }
        }


        // GET: Solicitud/BorrarSolicitud/5    
        public ActionResult BorrarSolicitud(int id)
        {
            try
            {
                AutosRepository AutRepo = new AutosRepository();
                if (AutRepo.BorrarAuto(id))
                {
                    ViewBag.AlertMsg = "Auto borrado satisfactoriamente";

                }
                return RedirectToAction("ObtenerAuto");

            }
            catch
            {
                return View();
            }
        }

    }
}
