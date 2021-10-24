using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        private IAmigoAlmacen amigoAlmacen;

        public HomeController(IAmigoAlmacen AmigoAlmacen)
        {
            amigoAlmacen = AmigoAlmacen;
        }
       
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index(int Id)
        {
            var amigo = amigoAlmacen.DameTodosLosAmigos();
            return View(amigo);
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index/{id?}")]
        public JsonResult Index2(int? Id)
        {
            Amigo modelo = amigoAlmacen.dameDatosAmigo(Id?? 1);
            return Json(modelo);
        }

        public JsonResult Details()
        {
            Amigo modelo = amigoAlmacen.dameDatosAmigo(2);
            return Json(modelo);
        }

        public ViewResult Detalles()
        {
            Amigo modelo1 = amigoAlmacen.dameDatosAmigo(3);
            ViewData["Cabecera"] = "LISTA DE AMIGOS";
            ViewData["Amigo"] = modelo1;
            return View(modelo1);
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Amigos/{id?}")]
        public JsonResult Amigo(int? Id)
        {

            Amigo modelo = amigoAlmacen.dameDatosAmigo(Id??1);

            if (modelo == null)
            {
                Response.StatusCode = 404;
                return Json("Amigo no encontrado: "+Id);
            }

            return Json(modelo);
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Amigos")]
        public JsonResult Amigos()
        {
            List<Amigo> modelo = amigoAlmacen.DameTodosLosAmigos();

            return Json(modelo);
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Eliminar/{id}")]
        public JsonResult Amigos(int? Id)
        {
            Amigo modelo = amigoAlmacen.Eliminar(Id??1);
            return Json(modelo);
        }


        [Route("")]
        [Route("Home")]
        [Route("Home/Actualizar/{id}")]
        public JsonResult AmigoActualizar(int? Id)
        {
            Amigo modelo = amigoAlmacen.Actualizar(Id??1);
            return Json(modelo);
        }

    }
}
