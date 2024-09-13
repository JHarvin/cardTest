using WebFrontend.Helpers;
using WebFrontend.Models;
using WebFrontend.Models.Commands;
using Microsoft.AspNetCore.Mvc;


namespace WebFrontend.Controllers
{
    public class CategoriasController : Controller
    {
        private  CategoriaQuery _categoriaQuery;

      
        public IActionResult Index()
        {
            return View();
        }

        #region dataTables js
        [HttpGet]
        public IActionResult GetAll()
        {
            _categoriaQuery = new CategoriaQuery();
            var datos =_categoriaQuery.Compras();
            return Json(new { data = datos.Result });
        }
        #endregion

       
    }
}
