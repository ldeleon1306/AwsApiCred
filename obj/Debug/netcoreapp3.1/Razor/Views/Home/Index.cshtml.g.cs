#pragma checksum "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "546b4aabbb51f73f6c327537b1675281e10a7197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546b4aabbb51f73f6c327537b1675281e10a7197", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 style=\"font-size: 28px; font-weight: bold;\">Contrato</h1>\r\n<div style=\"margin-top: 20px;\">\r\n");
#nullable restore
#line 3 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
     using (Html.BeginForm("BuscarContrato", "Home", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""display: flex; justify-content: center;"">
            <input type=""text"" name=""idContrato"" placeholder=""Ingrese el ID del contrato"" style=""padding: 8px; border-radius: 5px; border: 1px solid #ccc; width: 250px; margin-right: 10px;"" />
            <button type=""submit"" style=""background-color: #4CAF50; color: white; padding: 8px 16px; border: none; border-radius: 5px;"">Buscar</button>
        </div>
");
#nullable restore
#line 9 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""margin-top: 20px;"">
            <table style=""width: 100%; border-collapse: collapse;"">
                <tr>
                    <th style=""text-align: left; padding: 8px; background-color: #4CAF50; color: white; border: 1px solid #ddd;"">Contrato_tms</th>
                    <td style=""text-align: left; padding: 8px; border: 1px solid #ddd;"">");
#nullable restore
#line 16 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
                                                                                   Write(Model.contrato_tms);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
                <tr>
                    <th style=""text-align: left; padding: 8px; background-color: #4CAF50; color: white; border: 1px solid #ddd;"">Cliente</th>
                    <td style=""text-align: left; padding: 8px; border: 1px solid #ddd;"">");
#nullable restore
#line 20 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
                                                                                   Write(Model.cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
                <tr>
                    <th style=""text-align: left; padding: 8px; background-color: #4CAF50; color: white; border: 1px solid #ddd;"">Cliente_para_validaciones</th>
                    <td style=""text-align: left; padding: 8px; border: 1px solid #ddd;"">");
#nullable restore
#line 24 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
                                                                                   Write(Model.cliente_para_validaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\ldeleon\source\repos\AwsApiCred\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
