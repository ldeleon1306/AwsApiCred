using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        public IActionResult Resultado(string sentData, string response)
        {
            ViewBag.SentData = sentData;
            ViewBag.Response = response;
            ViewBag.JsonData = sentData; // Asignar la cadena JSON a ViewBag.JsonData
            dynamic jsonData = JsonConvert.DeserializeObject(ViewBag.JsonData);
            return View("~/Views/Home/Resultado.cshtml", jsonData);
        }
        [HttpPost]
        public async Task<IActionResult> Asociar(string userName, string clientId)
        {
            var url = "http://api-contrato-unificada.qa.apps.aro.andreani.com.ar/api/v1/usuarios";

            var payload = new
            {
                nombre = userName,
                clientes = new[]
                {
            new
            {
                codigo = clientId
            }
        }
            };

            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ViewBag.Result = result;
                return View("Resultado");
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
