using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApplication_transporte.Models;


namespace webApplication_transporte.Controllers
{
    public class GastosTransporteController : Controller
    {
        // GET: GastosTransporte
        public ActionResult Costos()
        {
            return View(new Transporte());
        }
        [HttpPost]public ActionResult Costos(Transporte reg)
        {
            ViewBag.costo = reg.Costo().ToString("######.#0");
            ViewBag.seguro = reg.Seguro().ToString("######.#0");
            ViewBag.monto = reg.Monto().ToString("######.#0");
            ViewBag.igv = reg.IGV().ToString("######.#0");
            ViewBag.total = reg.MontoTotal().ToString("######.#0");
            return View(reg);
        }
        
    }
}