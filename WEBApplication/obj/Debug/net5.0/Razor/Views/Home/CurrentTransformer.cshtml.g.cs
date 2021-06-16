#pragma checksum "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38ea0ce769b88205fe4b4bdd8540c9b959661a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CurrentTransformer), @"mvc.1.0.view", @"/Views/Home/CurrentTransformer.cshtml")]
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
#line 1 "D:\Projects\WEBService\WEBApplication\Views\_ViewImports.cshtml"
using WEBApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\WEBService\WEBApplication\Views\_ViewImports.cshtml"
using WEBApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\WEBService\WEBApplication\Views\_ViewImports.cshtml"
using WEBService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38ea0ce769b88205fe4b4bdd8540c9b959661a3", @"/Views/Home/CurrentTransformer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a89c22238466cbc19bc2485df44a33d5be8989", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CurrentTransformer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CurrentTransformer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
  
    ViewData["Title"] = "Трансформаторы тока";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Список трансформаторов тока</h1>
</div>
<table class=""table table-hover"">
    <thead class=""thead-light"">
        <tr>
            <th>Id</th>
            <th>Номер</th>
            <th>Тип трансформатора тока</th>
            <th>Коэффициент трансформации</th>
            <th>Дата проверки</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
               Write(item.CurrentTransformerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
               Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
               Write(item.TransformerType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
               Write(item.TransformationRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-danger\">");
#nullable restore
#line 27 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
                                   Write(item.CheckDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Projects\WEBService\WEBApplication\Views\Home\CurrentTransformer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CurrentTransformer>> Html { get; private set; }
    }
}
#pragma warning restore 1591