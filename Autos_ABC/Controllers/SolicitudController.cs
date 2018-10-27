using Autos_ABC.Models;
using Autos_ABC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos_ABC.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Aut/ObtenerSolicitud()    
        public ActionResult ObtenerSolicitud(string searchString)
        {
           


            SolicitudRepository SolRepo = new SolicitudRepository();


            //Buscar solicitudes por folio 
            var folio = from s in SolRepo.ObtenerSolicitud() select s;


            if (!String.IsNullOrEmpty(searchString))
            {
                folio = folio.Where(s => s.NumeroLote.Equals(searchString));
            }

            ModelState.Clear();

            return View(folio.ToList());
        }
        // GET: Solicitud/AgregarSolicitud()   
        public ActionResult AgregarSolicitud()
        {
            SolicitudRepository SolRepo = new SolicitudRepository();

            ViewBag.Auto = SolRepo.ObtenerAutosList();
            return View();
        }

        // POST: Solicitud/AgregarSolicitud  
        [HttpPost]
        public ActionResult AgregarSolicitud(SolicitudModel Solicitud)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SolicitudRepository AutRep = new SolicitudRepository();

                    if (AutRep.AgregarSolicitud(Solicitud))
                    {
                        ViewBag.Message = "Solicitud agregado satisfactoriamente";
                    }
                }

                return RedirectToAction("ObtenerSolicitud");
            }
            catch
            {
                return RedirectToAction("ObtenerSolicitud");
            }
        }

        // GET:Solicitud/ActualizarSolicituds/5    
        public ActionResult ActualizarSolicitud(int id)
        {
            SolicitudRepository SolRep = new SolicitudRepository();

            ViewBag.Auto = SolRep.ObtenerAutosList();

            return View(SolRep.ObtenerSolicitud().Find(Aut => Aut.IdSolicitud == id));

        }

        // POST: Solicitud/AuctualizarSolicitud/5    
        [HttpPost]

        public ActionResult ActualizarSolicitud(int id, SolicitudModel obj)
        {
            try
            {
                SolicitudRepository AutRep = new SolicitudRepository();
                obj.IdSolicitud = id;

                AutRep.ActualizarSolicitud(obj);

                return RedirectToAction("ObtenerSolicitud");
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
                SolicitudRepository EmpRepo = new SolicitudRepository();
                if (EmpRepo.BorrarSolicitud(id))
                {
                    ViewBag.AlertMsg = "Solicitud borrado satisfactoriamente";

                }
                return RedirectToAction("ObtenerSolicitud");

            }
            catch
            {
                return View();
            }
        }

    }
}
