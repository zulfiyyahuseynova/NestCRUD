#pragma checksum "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d72834aae17f3df2a078f32b363bf23a35acb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\_ViewImports.cshtml"
using NestTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\_ViewImports.cshtml"
using NestTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\_ViewImports.cshtml"
using NestTask.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\_ViewImports.cshtml"
using NestTask.ViewModels.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d72834aae17f3df2a078f32b363bf23a35acb6", @"/Areas/Manage/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4352c8c1c86d5686c62c16eab78f981779d2d85c", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm font-sm rounded btn-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        .card-product-grid .img-wrap {\r\n            height: 250px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteModalLabel"">Are you sure you want to delete?</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d72834aae17f3df2a078f32b363bf23a35acb67984", async() => {
                WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-brand\" data-bs-dismiss=\"modal\">Close</button>\r\n                <button type=\"submit\" class=\"btn btn-google\">Delete</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<header class=\"main-header navbar\">\r\n    <div class=\"col-search\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d72834aae17f3df2a078f32b363bf23a35acb610027", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input list=""search_terms"" type=""text"" class=""form-control"" placeholder=""Search term"" />
                <button class=""btn btn-light bg"" type=""button""><i class=""material-icons md-search""></i></button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-nav"">
        <button class=""btn btn-icon btn-mobile me-auto"" data-trigger=""#offcanvas_aside""><i class=""material-icons md-apps""></i></button>
        <ul class=""nav"">
            <li class=""nav-item"">
                <a class=""nav-link btn-icon"" href=""#"">
                    <i class=""material-icons md-notifications animation-shake""></i>
                    <span class=""badge rounded-pill"">3</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link btn-icon darkmode"" href=""#""> <i class=""material-icons md-nights_stay""></i> </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""requestfullscreen nav-link btn-icon""><i class=""material-icons md-cast""></i></a>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" id=""dropdownLanguage"" aria-expanded=""false""><i class=""material-icons md-public");
            WriteLiteral(@"""></i></a>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownLanguage"">
                    <a class=""dropdown-item text-brand"" href=""#""><img src=""assets/imgs/theme/flag-us.png"" alt=""English"" />English</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-fr.png"" alt=""Français"" />Français</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-jp.png"" alt=""Français"" />日本語</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-cn.png"" alt=""Français"" />中国人</a>
                </div>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" id=""dropdownAccount"" aria-expanded=""false""> <img class=""img-xs rounded-circle"" src=""assets/imgs/people/avatar-2.png"" alt=""User"" /></a>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownAccount"">
             ");
            WriteLiteral(@"       <a class=""dropdown-item"" href=""#""><i class=""material-icons md-perm_identity""></i>Edit Profile</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-settings""></i>Account Settings</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-account_balance_wallet""></i>Wallet</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-receipt""></i>Billing</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-help_outline""></i>Help center</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item text-danger"" href=""#""><i class=""material-icons md-exit_to_app""></i>Logout</a>
                </div>
            </li>
        </ul>
    </div>
</header>
<section class=""content-main"">
    <div class=""content-header"">
        <div>
            <h2 class=""content-title card-title"">Products grid</h2>
            <p>Lorem ipsum dolor sit amet");
            WriteLiteral(".</p>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d72834aae17f3df2a078f32b363bf23a35acb615016", async() => {
                WriteLiteral("Create new");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
    <div class=""card mb-4"">
        <header class=""card-header"">
            <div class=""row gx-3"">
                <div class=""col-lg-4 col-md-6 me-auto"">
                    <input type=""text"" placeholder=""Search..."" class=""form-control"" />
                </div>
            </div>
        </header>
        <!-- card-header end// -->
        <div class=""card-body"">
            <div class=""row gx-3 row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-xl-4 row-cols-xxl-5"">
");
#nullable restore
#line 96 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col\">\r\n                        <div class=\"card card-product-grid\">\r\n                            <a href=\"#\" class=\"img-wrap\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82d72834aae17f3df2a078f32b363bf23a35acb617231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5311, "~/assets/imgs/shop/", 5311, 19, true);
#nullable restore
#line 100 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 5330, item.Image, 5330, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </a>\r\n                            <div class=\"info-wrap\">\r\n                                <span class=\"d-flex justify-content-sm-between\">\r\n                                <a href=\"#\" class=\"title text-truncate\">");
#nullable restore
#line 103 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 103 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                                               Write(item.IsDeleted==false?Html.Raw("<i style='font-size:16px;vertical-align:middle' class='material-icons md-check_circle_outline text-success'></i>"): Html.Raw("<i style='font-size:16px;vertical-align:middle' class='material-icons md-do_not_disturb text-danger'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 104 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                     Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </span>\r\n                                    <div class=\"price mb-2\">$");
#nullable restore
#line 106 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <!-- price.// -->\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d72834aae17f3df2a078f32b363bf23a35acb620760", async() => {
                WriteLiteral(" <i class=\"material-icons md-edit\"></i> Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a data-bs-toggle=\"modal\" data-bs-target=\"#deleteModal\" data-id=\"");
#nullable restore
#line 109 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm font-sm btn-light rounded\"> <i class=\"material-icons md-delete_forever\"></i> Delete </a>\r\n</div>\r\n                        </div>\r\n                        <!-- card-product  end// -->\r\n                    </div>\r\n");
#nullable restore
#line 114 "C:\Users\Acer\Desktop\NestManyToMany\NestTask\NestTask\Areas\Manage\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- col.// -->
            </div>
            <!-- row.// -->
        </div>
        <!-- card-body end// -->
    </div>
    <!-- card end// -->
    <div class=""pagination-area mt-30 mb-50"">
        <nav aria-label=""Page navigation example"">
            <ul class=""pagination justify-content-start"">
                <li class=""page-item active""><a class=""page-link"" href=""#"">01</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">02</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">03</a></li>
                <li class=""page-item""><a class=""page-link dot"" href=""#"">...</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">16</a></li>
                <li class=""page-item"">
                    <a class=""page-link"" href=""#""><i class=""material-icons md-chevron_right""></i></a>
                </li>
            </ul>
        </nav>
    </div>
</section>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>
        let deleteUrl = $(""#deleteModal form"").attr(""action"")
        $(""a[data-bs-target='#deleteModal']"").click(function () {
            $(""#deleteModal form"").attr(""action"", deleteUrl + ""/"" + $(this).attr(""data-id""))
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
