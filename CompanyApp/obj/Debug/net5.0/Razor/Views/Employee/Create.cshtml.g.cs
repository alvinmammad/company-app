#pragma checksum "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2670bef613e1b1d0838774cc10f10faf119be925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2670bef613e1b1d0838774cc10f10faf119be925", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e28a52eafbd6246e99701f4ce91c6a8c86f461", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyApp.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"" style=""margin-bottom:70px;"">
    <h1 class=""display-4"">Create department</h1>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
");
#nullable restore
#line 12 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 18 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 19 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 20 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 26 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 27 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Surname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 28 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 33 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 34 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 35 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Age, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 40 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 41 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Country, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 42 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Country, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 47 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 48 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 49 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.City, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 54 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 55 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.BirthDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 56 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.BirthDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 61 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 62 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Salary, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 63 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Salary, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 68 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 69 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 70 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 75 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 76 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 77 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>  <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 82 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.LabelFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 83 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.EditorFor(model => model.Position, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 84 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Position, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 106 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
                       Write(Html.LabelFor(model => model.DepartmentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2670bef613e1b1d0838774cc10f10faf119be92516736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 107 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DepartmentID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 107 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DepartmentID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("\r\n\r\n                    </div>\r\n                        <div class=\"card-body text-center\">\r\n                            <input type=\"submit\" value=\"Save\" id=\"createDep\" class=\"btn btn-outline-primary\" />\r\n                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\Elvin\source\repos\CompanyApp\CompanyApp\Views\Employee\Create.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        <button id=\"btnn\">click</button>\r\n                    </div>\r\n\r\n");
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyApp.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
