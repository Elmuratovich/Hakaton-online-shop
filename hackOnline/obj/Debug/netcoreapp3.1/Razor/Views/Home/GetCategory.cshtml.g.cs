#pragma checksum "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cff5fa71115d7861cd7580677be2cfc79478ac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCategory), @"mvc.1.0.view", @"/Views/Home/GetCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cff5fa71115d7861cd7580677be2cfc79478ac8", @"/Views/Home/GetCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0864411c43edf03d0d0743eefa3a2d940c70e492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Models.ViewModel.GetAllProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/img/fut.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCatecory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"" style=""margin: 10px;"">
    <div class=""col-lg-3"">
        <h1 class=""h3 mb-2 text-gray-800"">??????????????????</h1>
        <div class=""card shadow mb-4"" style=""position: static; overflow: scroll; height: 600px;"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">
                    ?????? ??????????????????
");
#nullable restore
#line 11 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                     if (Model.role.Equals("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-primary\" type=\"button\" onclick=\"addCategory()\" data-toggle=\"modal\" data-target=\"#forman\" style=\"float: right;\">\r\n                            <i class=\"fa fa-plus\"></i>\r\n                        </button>\r\n");
#nullable restore
#line 16 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </h6>\r\n            </div>\r\n");
#nullable restore
#line 19 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
             for (int i = 0; i < Model.Categories.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"hov\" style=\"background: #fff; margin: 5px; cursor: pointer;\"");
            BeginWriteAttribute("id", " id=\"", 993, "\"", 1028, 2);
            WriteAttributeValue("", 998, "delCat-", 998, 7, true);
#nullable restore
#line 21 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 1005, Model.Categories[i].id, 1005, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1074, "\"", 1120, 3);
            WriteAttributeValue("", 1084, "getProducts(", 1084, 12, true);
#nullable restore
#line 22 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 1096, Model.Categories[i].id, 1096, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1119, ")", 1119, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">

                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                                    10 ????????
                                </div>
                                <div class=""h5 mb-0 font-weight-bold text-gray-800""> ");
#nullable restore
#line 29 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                                                Write(Model.Categories[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"col-auto\">\r\n");
#nullable restore
#line 32 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                 if (Model.role.Equals("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"><i class=\"fa fa-trash text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1855, "\"", 1904, 3);
            WriteAttributeValue("", 1865, "deleteCategory(", 1865, 15, true);
#nullable restore
#line 34 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 1880, Model.Categories[i].id, 1880, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1903, ")", 1903, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 35 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

        <div class=""col-lg-9"">
            <div>
                <div class=""container-fluid"">

                    <!-- Page Heading -->
                    <h1 class=""h3 mb-2 text-gray-800"">????????????</h1>

                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-3"">
                            <h6 class=""m-0 font-weight-bold text-primary"">
                                ???????????? ???? ?????????????????? ");
#nullable restore
#line 55 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                     if (Model.role.Equals("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <button class=""btn btn-primary"" type=""button"" onclick=""addProduct()"" data-toggle=""modal"" data-target=""#forma"" style=""float: right;"">
                                    <i class=""fa fa-plus""></i>
                                </button>
");
#nullable restore
#line 60 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </h6>
                            
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered table-hover"" id=""dataTable"" width=""100%"" cellspacing=""0"" style=""cursor: pointer;"">
                                    <thead>
                                        <tr>
                                            <th class=""thImage"">id</th>
                                            <th>name</th>
                                            <th>price</th>
                                            <th>date</th>
");
#nullable restore
#line 73 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                             if (Model.role.Equals("Admin"))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td></td>\r\n");
#nullable restore
#line 76 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tr>\r\n                                    </thead>\r\n\r\n                                    <tbody id=\"product\">\r\n");
#nullable restore
#line 81 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                         for (int i = 0; i < Model.ProductImages.Count(); i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr");
            BeginWriteAttribute("id", " id=\"", 4258, "\"", 4294, 2);
            WriteAttributeValue("", 4263, "delp-", 4263, 5, true);
#nullable restore
#line 83 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 4268, Model.ProductImages[i].id, 4268, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <td>\r\n                                                    <div class=\"imgProduct\">\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4488, "\"", 4535, 2);
            WriteAttributeValue("", 4495, "/Home/Product/", 4495, 14, true);
#nullable restore
#line 86 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 4509, Model.ProductImages[i].id, 4509, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 87 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                             if (Model.ProductImages[i].isImage = true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cff5fa71115d7861cd7580677be2cfc79478ac815214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4781, "~/Uploads/", 4781, 10, true);
#nullable restore
#line 89 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
AddHtmlAttributeValue("", 4791, Model.ProductImages[i].file_name, 4791, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                             if (Model.ProductImages[i].isImage == false)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cff5fa71115d7861cd7580677be2cfc79478ac817376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </a>
                                                    </div>
                                                </td>
                                                <td>
                                                    <div>
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 5603, "\"", 5650, 2);
            WriteAttributeValue("", 5610, "/Home/Product/", 5610, 14, true);
#nullable restore
#line 100 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 5624, Model.ProductImages[i].id, 5624, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <b>");
#nullable restore
#line 101 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                          Write(Model.ProductImages[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br />\r\n                                                            ");
#nullable restore
#line 102 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                       Write(Model.ProductImages[i].description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </a>\r\n                                                    </div>\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 106 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                               Write(Model.ProductImages[i].price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 107 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                               Write(Model.ProductImages[i].created.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 108 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                 if (Model.role.Equals("Admin"))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <td>
                                                        <br />
                                                        <a href=""#"" data-toggle=""modal"" data-target=""#form""><i class=""fas fa-edit text-primary"" aria-hidden=""true""");
            BeginWriteAttribute("onclick", " onclick=\"", 6650, "\"", 6694, 3);
            WriteAttributeValue("", 6660, "editProduct(", 6660, 12, true);
#nullable restore
#line 112 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 6672, Model.Products[i].id, 6672, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6693, ")", 6693, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i></a><br /><br />\r\n                                                        <a href=\"#\"><i class=\"fa fa-trash text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6845, "\"", 6891, 3);
            WriteAttributeValue("", 6855, "deleteProduct(", 6855, 14, true);
#nullable restore
#line 113 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
WriteAttributeValue("", 6869, Model.Products[i].id, 6869, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6890, ")", 6890, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                                    </td>\r\n");
#nullable restore
#line 115 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </tr>\r\n");
#nullable restore
#line 118 "D:\hackOnline\hackOnline\Views\Home\GetCategory.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </tbody>
                                </table>
                                

                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

<div class=""modal fade"" id=""form"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">???????????????? ??????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cff5fa71115d7861cd7580677be2cfc79478ac824235", async() => {
                WriteLiteral(@"
                <div class=""modal-body"" id=""forms"">
                    
                </div>
                <div class=""modal-footer border-top-0 d-flex justify-content-center"">
                    <button type=""submit"" class=""btn btn-success"" style=""background: #4e73df;"">??????????????????</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""forma"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">???????????????? ??????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cff5fa71115d7861cd7580677be2cfc79478ac826750", async() => {
                WriteLiteral(@"
                <div class=""modal-body"" id=""formas"">

                </div>
                <div class=""modal-footer border-top-0 d-flex justify-content-center"">
                    <button type=""submit"" class=""btn btn-success"" style=""background: #4e73df;"">??????????????????</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>


<div class=""modal fade"" id=""forman"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">???????????????? ??????????????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cff5fa71115d7861cd7580677be2cfc79478ac829536", async() => {
                WriteLiteral(@"
                <div class=""modal-body"" id=""formans"">
                    <div class=""form-group"">
                        <label for=""password1"">????????????????</label>
                        <input name=""name"" class=""form-control"">
                    </div>
                </div>
                <div class=""modal-footer border-top-0 d-flex justify-content-center"">
                    <button type=""submit"" class=""btn btn-success"" style=""background: #4e73df;"">??????????????????</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<style>
    .imgProduct{
        height: 120px;
        width: 100px;
    }

    .thImage{
        width: 110px;
    }

    .img-css{
        height: 120px;
        width: 110px;
    }

    table, th, td {
        border: 1px solid black;
        border-radius: 10px;
    }

    .table-hover tbody tr:hover td {
        background: #f2f3f6;
    }

    tr{
        border: 1px solid white;
    }
    .hov:hover{
        background: #f2f3f6;
    }
</style>
<script>
    function getProducts(id) {
        $(""#product"").html('');
        var url = ""/Home/GetProducts/"" + id;
        $.get(url, function (data) {
            $(""#product"").html(data);

        });
    }

    function editProduct(id) {
        $(""#forms"").html('');
        var url = ""/Home/Edit/"" + id;
        $.get(url, function (data) {
            $(""#forms"").html(data);

        });
    }

    function deleteProduct(id) {
        let text;
        if (confirm(""Pre");
            WriteLiteral(@"ss a button!"") == true) {
            $.ajax({
                type: 'POST',
                url: '/Home/DeleteProduct/',
                data: { 'id': id },
                success: function (data) {
                    $('#delp-' + id).remove();
                    $.alert('????????????!');
                }
            });
        } else {
            text = ""You canceled!"";
        }
    }

    function deleteCategory(id) {
        let text;
        if (confirm(""Press a button!"") == true) {
            $.ajax({
                type: 'POST',
                url: '/Home/DeleteCategory/',
                data: { 'id': id },
                success: function (data) {
                    $('#delCat-' + id).remove();
                    $.alert('????????????!');
                }
            });
        } else {
            text = ""You canceled!"";
        }
    }

    function addProduct() {
        $(""#formas"").html('');
        var url = ""/Home/AddProduct/"";
        $.get(url, function ");
            WriteLiteral("(data) {\r\n            $(\"#formas\").html(data);\r\n\r\n        });\r\n    }\r\n\r\n \r\n \r\n</script>");
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
