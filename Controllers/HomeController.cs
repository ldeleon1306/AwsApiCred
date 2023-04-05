using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwsApiCred.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContratosController _contratosController;

        public HomeController(ContratosController contratosController)
        {
            _contratosController = contratosController;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscarContrato(string idContrato)
        {
            if (string.IsNullOrEmpty(idContrato))
            {
                return RedirectToAction("Index");
            }

            dynamic contrato = await _contratosController.GetContrato(idContrato);

            if (contrato == null)
            {
                ViewBag.ErrorMessage = "No se encontró el contrato especificado";
                return View("Index");
            }

            return View("Contrato", contrato);
        }
    }
}
