#pragma checksum "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee913846f5762a47943e12e3a3c99a2bf9ecc2a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_saveComment), @"mvc.1.0.view", @"/Views/Home/saveComment.cshtml")]
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
#line 1 "D:\hackOnline\hackOnline\Views\_ViewImports.cshtml"
using hackOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hackOnline\hackOnline\Views\_ViewImports.cshtml"
using hackOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee913846f5762a47943e12e3a3c99a2bf9ecc2a8", @"/Views/Home/saveComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0864411c43edf03d0d0743eefa3a2d940c70e492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_saveComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Models.ViewModel.GetAllProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
 for (int i = 0; i < Model.CommentProducts.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 153, "\"", 190, 2);
            WriteAttributeValue("", 158, "del-", 158, 4, true);
#nullable restore
#line 8 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
WriteAttributeValue("", 162, Model.CommentProducts[i].id, 162, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"text-truncate\" style=\"color: black;\">\r\n            ");
#nullable restore
#line 10 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
       Write(Model.CommentProducts[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
                                                if (Model.role.Equals("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-trash text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 406, "\"", 459, 3);
            WriteAttributeValue("", 416, "deleteComment(", 416, 14, true);
#nullable restore
#line 11 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
WriteAttributeValue("", 430, Model.CommentProducts[i].id, 430, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 458, ")", 458, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"??????????????\"></i>");
#nullable restore
#line 11 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
                                                                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <p>");
#nullable restore
#line 14 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
          Write(Model.CommentProducts[i].description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"font-size: 9px; float: right;\">");
#nullable restore
#line 14 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
                                                                                        Write(Model.CommentProducts[i].record_time_stamp.ToString("dd/MM/yyyy hh:m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "D:\hackOnline\hackOnline\Views\Home\saveComment.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Models.ViewModel.GetAllProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
