#pragma checksum "D:\movies\movies\movies\Views\Moves\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7ce91b3188735548a47210bbadacc72a60bb54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moves_Details), @"mvc.1.0.view", @"/Views/Moves/Details.cshtml")]
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
#line 1 "D:\movies\movies\movies\Views\_ViewImports.cshtml"
using Moves_List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\movies\movies\movies\Views\_ViewImports.cshtml"
using Moves_List.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\movies\movies\movies\Views\_ViewImports.cshtml"
using movies.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7ce91b3188735548a47210bbadacc72a60bb54", @"/Views/Moves/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ff622b6fe5661789494b7b305d48b7c059ac07", @"/Views/_ViewImports.cshtml")]
    public class Views_Moves_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Move>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("﻿\r\n");
#nullable restore
#line 3 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-between mt-60-px\">\r\n    <div class=\"col-md-3\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 155, "\"", 220, 2);
            WriteAttributeValue("", 161, "data:image/*;base64,", 161, 20, true);
#nullable restore
#line 9 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
WriteAttributeValue("", 181, Convert.ToBase64String(Model.Poster), 181, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 243, "\"", 261, 1);
#nullable restore
#line 9 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
WriteAttributeValue("", 249, Model.Title, 249, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        <div class=\"d-flex justify-content-between mb-3\">\r\n            <h3>");
#nullable restore
#line 13 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <span class=\"mt-2\">\r\n                <i class=\"bi bi-star-fill text-warning\"></i>\r\n                <span class=\"text-muted\">");
#nullable restore
#line 16 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
                                    Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </span>\r\n        </div>\r\n        <span class=\"text-muted mr-3\">\r\n            <i class=\"bi bi-calendar-week\"></i>\r\n            ");
#nullable restore
#line 21 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
       Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"text-muted\">\r\n            <i class=\"bi bi-film\"></i>\r\n            ");
#nullable restore
#line 25 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
       Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <p class=\"text-justify mt-3\">");
#nullable restore
#line 27 "D:\movies\movies\movies\Views\Moves\Details.cshtml"
                                Write(Model.StoryLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Move> Html { get; private set; }
    }
}
#pragma warning restore 1591
