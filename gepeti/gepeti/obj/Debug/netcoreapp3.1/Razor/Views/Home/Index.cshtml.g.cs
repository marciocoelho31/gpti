#pragma checksum "C:\developer\gepeti\gepeti\gepeti\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11cf2e21ed0be075a1d7f7fed8ba32442c509609"
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
#nullable restore
#line 1 "C:\developer\gepeti\gepeti\gepeti\Views\_ViewImports.cshtml"
using gepeti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\developer\gepeti\gepeti\gepeti\Views\_ViewImports.cshtml"
using gepeti.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\gepeti\gepeti\gepeti\Views\_ViewImports.cshtml"
using gepeti.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11cf2e21ed0be075a1d7f7fed8ba32442c509609", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ffc3c9147fd8c4389320d0a38e46f983f27b9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gepeti.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\developer\gepeti\gepeti\gepeti\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem vindo!</h1>\r\n\r\n    <h3>\r\n        ");
#nullable restore
#line 10 "C:\developer\gepeti\gepeti\gepeti\Views\Home\Index.cshtml"
   Write(Model.Empresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n\r\n    <h5>\r\n        ");
#nullable restore
#line 14 "C:\developer\gepeti\gepeti\gepeti\Views\Home\Index.cshtml"
   Write(Model.DadosContato);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n    </h5>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gepeti.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591