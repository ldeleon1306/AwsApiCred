#pragma checksum "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c835e1983c4cdcc71ad49b037cb4a165dc00e8a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c835e1983c4cdcc71ad49b037cb4a165dc00e8a", @"/Views/Home/Resultado.cshtml")]
    public class Views_Home_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
 if (ViewBag.Result != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Resultado de la asociación:</h1>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
  Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
}
else
{
    dynamic jsonData = JsonConvert.DeserializeObject(ViewBag.JsonData);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Datos enviados:</h1>\r\n    <p>");
#nullable restore
#line 18 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
  Write(jsonData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h1>Respuesta:</h1>\r\n    <p>");
#nullable restore
#line 20 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
  Write(ViewBag.Response);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 21 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
    // Convertir la cadena JSON a un objeto dinámico
   



#line default
#line hidden
#nullable disable
            WriteLiteral("    <form method=\"post\" action=\"/Home/Asociar\">\r\n        <input type=\"hidden\" name=\"userName\"");
            BeginWriteAttribute("value", " value=\"", 599, "\"", 625, 1);
#nullable restore
#line 26 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 607, jsonData.userName, 607, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"clientId\"");
            BeginWriteAttribute("value", " value=\"", 675, "\"", 701, 1);
#nullable restore
#line 27 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 683, jsonData.clientId, 683, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <button type=\"submit\" style=\"background-color: #4CAF50; color: yellow; padding: 8px 16px; border: none; border-radius: 5px;\">Asociar</button>\r\n    </form>\r\n");
#nullable restore
#line 30 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 919, 1);
#nullable restore
#line 35 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Resultado.cshtml"
WriteAttributeValue("", 891, Url.Action("Index", "Home"), 891, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #4CAF50; color: white; padding: 8px 16px; border: none; border-radius: 5px;\">Inicio</a>\r\n");
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