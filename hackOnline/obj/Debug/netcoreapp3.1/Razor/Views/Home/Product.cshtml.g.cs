#pragma checksum "D:\hackOnline\hackOnline\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c0dc8b1e61d9989b7be02458e03fca204c9b46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c0dc8b1e61d9989b7be02458e03fca204c9b46", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0864411c43edf03d0d0743eefa3a2d940c70e492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Models.ViewModel.GetAllProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-profile rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/img/fut.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/demo/jquery-confirm.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <div class=""row"">

                <div class=""col-lg-6"">

                    <!-- Default Card Example -->
                    <div class=""card mb-4"">
                        <div class=""card-header"">
                            ?????????????????????? ????????????
                        </div>
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36c0dc8b1e61d9989b7be02458e03fca204c9b465323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <!-- Basic Card Example -->\r\n");
#nullable restore
#line 25 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                     if (Model.role != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                         if (Model.role.Equals("User"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card shadow mb-4\">\r\n                                <div class=\"card-body\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1092, "\"", 1131, 2);
            WriteAttributeValue("", 1099, "/Home/Favorites/", 1099, 16, true);
#nullable restore
#line 31 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue("", 1115, Model.productId, 1115, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" type=""button"" onclick=""getFavorites()"">
                                        <i class=""fa fa-heart""> ???????????????? ?? ??????????????????</i>
                                    </a>
                                    <br>
                                    <br>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1486, 2);
            WriteAttributeValue("", 1459, "/Home/Cart/", 1459, 11, true);
#nullable restore
#line 36 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue("", 1470, Model.productId, 1470, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" type=\"button\">\r\n                                        <i class=\"fa fa-cart-plus\"> ???????????????? ?? ??????????????</i>\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 41 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>

                <div class=""col-lg-6"">

                    <!-- Dropdown Card Example -->
                    <div class=""card shadow mb-4"">
                        <!-- Card Header - Dropdown -->
                        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                            <h6 class=""m-0 font-weight-bold text-primary"">???????????????? ????????????</h6>
                        </div>
                        <!-- Card Body -->
                        <div class=""card-body"">
                            <h5><b>");
#nullable restore
#line 57 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                              Write(Model.GetProduct.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                            <p>");
#nullable restore
#line 58 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                          Write(Model.GetProduct.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>

                    <!-- Collapsable Card Example -->
                    <div class=""card shadow mb-4"">
                        <!-- Card Header - Accordion -->
                        <a href=""#collapseCardExample"" class=""d-block card-header py-3"" data-toggle=""collapse""
                           role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                            <h6 class=""m-0 font-weight-bold text-primary"">????????????</h6>
                        </a>
                        <!-- Card Content - Collapse -->
                        <div class=""collapse show"" id=""collapseCardExample"">
                            <div class=""card-body"">
                                <div class=""font-weight-bold"" style=""position: sticky; overflow: scroll; height: 400px;"">
                                    <div id=""message"" style=""margin-right: 30px; padding: 20px;"">
");
#nullable restore
#line 74 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                         for (int i = 0; i < Model.CommentProducts.Count; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div");
            BeginWriteAttribute("id", " id=\"", 3645, "\"", 3682, 2);
            WriteAttributeValue("", 3650, "del-", 3650, 4, true);
#nullable restore
#line 76 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue("", 3654, Model.CommentProducts[i].id, 3654, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"text-truncate\" style=\"color: black;\">\r\n                                                    ");
#nullable restore
#line 78 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                               Write(Model.CommentProducts[i].username);

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                                                                       if (Model.role.Equals("Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-trash text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3964, "\"", 4017, 3);
            WriteAttributeValue("", 3974, "deleteComment(", 3974, 14, true);
#nullable restore
#line 78 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue("", 3988, Model.CommentProducts[i].id, 3988, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4016, ")", 4016, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"??????????????\"></i>");
#nullable restore
#line 78 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                                                                                                                                                                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                                <div>\r\n                                                    <p>");
#nullable restore
#line 81 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                                  Write(Model.CommentProducts[i].description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"font-size: 9px; float: right;\">");
#nullable restore
#line 81 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                                                                                                                Write(Model.CommentProducts[i].record_time_stamp.ToString("dd/MM/yyyy hh:m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 84 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 90 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                             if (Model.userId > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input style=\"width: 90%; margin: 5px;\" id=\"sms\" /> <i class=\"fa fa-paper-plane\" aria-hidden=\"true\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4881, "\"", 4931, 5);
            WriteAttributeValue("", 4891, "sendsms(", 4891, 8, true);
#nullable restore
#line 92 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue("", 4899, Model.userId, 4899, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4912, ",", 4912, 1, true);
#nullable restore
#line 92 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
WriteAttributeValue(" ", 4913, Model.productId, 4914, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4930, ")", 4930, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 93 "D:\hackOnline\hackOnline\Views\Home\Product.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>

                </div>

            </div>
           
        </div>
    </div>
</div>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c0dc8b1e61d9989b7be02458e03fca204c9b4616648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    function sendsms(id, prId) {
        var sms = $('#sms').val();
        $(""#message"").html('');
        var url = ""/Home/saveComment?id="" + id + ""&prId="" + prId + ""&text="" + sms;
        $.get(url, function (data) {
            var sms = $('#sms').val('');
            $(""#message"").html(data);

        });
    }

    function deleteComment(id) {
        let text;
        if (confirm(""Press a button!"") == true) {
            $.ajax({
                type: 'POST',
                url: '/Home/DeleteComment/',
                data: { 'id': id },
                success: function (data) {
                    $('#del-' + id).remove();
                    $.alert('????????????!');
                }
            });
        } else {
            text = ""You canceled!"";
        }
      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Models.ViewModel.GetAllProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
