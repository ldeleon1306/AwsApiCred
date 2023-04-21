using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace AwsApiCred.Controllers
{
    using Newtonsoft.Json;
    using OfficeOpenXml;
    using System.Net;
    using System.Net.Http;

    public class ExcelController : Controller
    {
        public async Task<IActionResult> SaveToExcelAsync(MyViewModel model)
        {
            string excelLink = "https://grupologisticoandreani-my.sharepoint.com/:x:/g/personal/ldeleon_andreani_com/EQRFGivucjNGkEXd_8Fi3DkBHW5KCbGovx0VDNRkva3f-g?e=McyggP";
            string excelLinka = "C:/Users/ldeleon/Downloads/AWS_Lista de credenciales generadas.xlsx";
            FileInfo fileInfo = new FileInfo(excelLinka);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;           

            // Verificar si el archivo existe
            if (!fileInfo.Exists)
            {
                // El archivo no existe
                return NotFound();
            }
            string excelLinkas = "https://grupologisticoandreani-my.sharepoint.com/personal/ldeleon_andreani_com/_layouts/15/onedrive.aspx?id=/personal/ldeleon_andreani_com/Documents/Documentos/Descargas/Downloads";
            // Verificar si la URL es accesible
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(excelLinkas);
                if (!response.IsSuccessStatusCode)
                {
                    // La URL no es accesible
                    return NotFound();
                }
            }
            string localFilePath = "C:/Users/ldeleon/Downloads/AWS_Lista_de_credenciales_generadas.xlsx";

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(excelLinkas, localFilePath);
            }
            

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = null;
                foreach (var sheet in package.Workbook.Worksheets)
                {
                    if (sheet.Name == "QA_Credenciales AWS")
                    {
                        worksheet = sheet;
                        break;
                    }
                }
                ExcelWorksheet worksheets = package.Workbook.Worksheets["QA_CredencialesAWS"];
                //ExcelWorksheet worksheetss = package.Workbook.Worksheets.Add("QA_Credenciales AWS");
                worksheets.Cells[1, 1].Value = model.UserName;
                worksheets.Cells[2, 1].Value = model.Password;
                worksheets.Cells[3, 1].Value = model.ClientId;
                worksheets.Cells[4, 1].Value = model.IsActive;
                worksheets.Cells[5, 1].Value = model.GroupId;

                package.Save();
            }

            return RedirectToAction("Index", "Home");
        }
        public class MyViewModel
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string ClientId { get; set; }
            public bool IsActive { get; set; }
            public string GroupId { get; set; }
        }


    }

}
