using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AwsApiCred.Controllers
{
    public class ContratosController : Controller
    {

        [Route("contratos/{id}")]
        public async Task<Contrato> GetContrato(string id)
        {
            HttpClient client = new HttpClient();
            var url = $"http://api-contrato-unificada.apps.aro.andreani.com.ar/api/v1/contratos/{id}";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var contrato = await response.Content.ReadAsAsync<Contrato>();
                //var postContent = new StringContent(@"{
                //                                ""userName"":""endomicilioa.com_gla"",
                //                                ""password"":""NAKa1FfMlZ"",
                //                                ""clientId"":""0012009378"",
                //                                ""isActive"":true,
                //                                ""groupId"":""b9ce68f5-7d77-4cce-b492-d9da2847b6e1""
                //                             }", Encoding.UTF8, "application/json");

                //var postResponse = await client.PostAsync("https://apis.andreani.com/login/usuarios", postContent);

                return contrato;
            }
            else
            {
                return null;
            }
        }

        public async Task<IActionResult> PostLogin([FromForm] string userName, [FromForm] string password, [FromForm] string clientId, [FromForm] bool isActive, [FromForm] string groupId)
        {
            HttpClient client = new HttpClient();

            var json = new
            {
                userName = userName,
                password = password,
                clientId = clientId,
                isActive = true,
                groupId = groupId
            };

            var content = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");

            //var response = await client.PostAsync("https://apis.andreani.com/login/usuarios", content);
            var response = await client.PostAsync("https://apisqa.andreani.com/login/usuarios", content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                //return Ok(result);
                ViewBag.Result = result;

                // Rediriges a la vista Contrato.cshtml
                //return View("~/Views/Home/Contrato.cshtml");
                return RedirectToAction("Resultado", "Home", new { sentData = JsonConvert.SerializeObject(json), response = result });
            }
            else
            {
                return BadRequest(response.ReasonPhrase);
            }
        }
        
    }
}
