#pragma checksum "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abecc8a6a1c0ce72688caf1c608a918ec7f8c258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Edit), @"mvc.1.0.view", @"/Views/Department/Edit.cshtml")]
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
#line 1 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\_ViewImports.cshtml"
using CompanyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\_ViewImports.cshtml"
using CompanyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abecc8a6a1c0ce72688caf1c608a918ec7f8c258", @"/Views/Department/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e28a52eafbd6246e99701f4ce91c6a8c86f461", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyApp.Models.Department>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"" style=""margin-bottom:70px;"">
    <h1 class=""display-4"">Edit department</h1>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
");
#nullable restore
#line 12 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                ");
#nullable restore
#line 17 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 18 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 20 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.LabelFor(model => model.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 21 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.EditorFor(model => model.DepName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 22 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.DepName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 28 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.LabelFor(model => model.DepManagerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.EditorFor(model => model.DepManagerName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 30 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.DepManagerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 36 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.LabelFor(model => model.DepManagerSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 37 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.EditorFor(model => model.DepManagerSurname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 38 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.DepManagerSurname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                </div>
                            </div>


                        </div>
                        <div class=""card-body text-center"">
                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                                    <input type=""submit"" value=""Save"" class=""btn btn-outline-primary"" />

                                </li>
                                <li class=""list-inline-item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abecc8a6a1c0ce72688caf1c608a918ec7f8c2589432", async() => {
                WriteLiteral("Go to index ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </li>\r\n\r\n                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 58 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Department\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyApp.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
