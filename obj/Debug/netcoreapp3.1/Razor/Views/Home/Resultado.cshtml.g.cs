#pragma checksum "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001fbdb87d1fa7eb08fe7bdd67cb900baad08d51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resultado), @"mvc.1.0.view", @"/Views/Home/Resultado.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001fbdb87d1fa7eb08fe7bdd67cb900baad08d51", @"/Views/Home/Resultado.cshtml")]
    public class Views_Home_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
 if (ViewBag.Result != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Resultado de la asociación:</h1>\r\n    <p>");
#nullable restore
#line 15 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
  Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
}
else
{
    dynamic jsonData = JsonConvert.DeserializeObject(ViewBag.JsonData);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Usuario generado:</h1>\r\n");
#nullable restore
#line 23 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
                                
    // Convertir la cadena JSON a un objeto dinámico
    Dictionary<string, object> dataDict = jsonData.ToObject<Dictionary<string, object>>();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Nombre de usuario</th>\r\n                <th>ID de cliente</th>\r\n                <th>ID de usuario</th>\r\n");
            WriteLiteral("                <th>Contraseña</th>\r\n                <th>¿Está activo?</th>\r\n                <th>ID de grupo</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
               Write(jsonData["userName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
               Write(jsonData["clientId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
                Write(ViewBag.Response != null ? JObject.Parse(ViewBag.Response).GetValue("userId").ToString() : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 45 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
               Write(jsonData["password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
               Write(jsonData["isActive"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
               Write(jsonData["groupId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <style>\r\n        table {\r\n            border-collapse: collapse;\r\n        }\r\n\r\n        td, th {\r\n            border: 1px solid black;\r\n            padding: 5px;\r\n        }\r\n    </style>\r\n");
            WriteLiteral(@"    <br />
    <button style=""background-color: green; color: #4CAF50; padding: 8px 16px; border: none; border-radius: 5px;"" onclick=""openPopup()"">Abrir Excel Sharepoint</button>
    <br />
    <br />
    <br />
    <form method=""post"" action=""/Home/Asociar"">
        <input type=""hidden"" name=""userName""");
            BeginWriteAttribute("value", " value=\"", 2564, "\"", 2590, 1);
#nullable restore
#line 77 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 2572, jsonData.userName, 2572, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"clientId\"");
            BeginWriteAttribute("value", " value=\"", 2640, "\"", 2666, 1);
#nullable restore
#line 78 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 2648, jsonData.clientId, 2648, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <button type=\"submit\" style=\"background-color: #4CAF50; color: yellow; padding: 8px 16px; border: none; border-radius: 5px;\">Asociar</button>\r\n    </form>\r\n");
#nullable restore
#line 81 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 2845, "\"", 2880, 1);
#nullable restore
#line 84 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 2852, Url.Action("Index", "Home"), 2852, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color: #4CAF50; color: white; padding: 8px 16px; border: none; border-radius: 5px;"">Inicio</a>

<script>
    function openPopup(jsonData) {
        var width = screen.width / 2;
        var height = screen.height;
        var url = ""https://grupologisticoandreani-my.sharepoint.com/:x:/g/personal/gblanco_andreani_com/EUXc59TE-BNNh2YikpqtfCQBqsN5aV20Ykc5DzXibVsErQ?e=1Dcd8o&clickparams=eyJBcHBOYW1lIjoiVGVhbXMtRGVza3RvcCIsIkFwcFZlcnNpb24iOiIyNy8yMzAzMDUwMTEwNSIsIkhhc0ZlZGVyYXRlZFVzZXIiOmZhbHNlfQ%3D%3D"" + encodeURIComponent(JSON.stringify(jsonData));
        window.open(url, ""popup"", ""width="" + width + "",height="" + height);
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
