#pragma checksum "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed9f2adc770c0f904d6665eaf25833381862127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_AdministrationCars_Delete), @"mvc.1.0.view", @"/Areas/Administration/Views/AdministrationCars/Delete.cshtml")]
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
#line 1 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.HomePageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CreateCarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.SearchCarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CategoriesViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\_ViewImports.cshtml"
using CarWorld.Areas.Administration.ViewModels.AdministrationMessages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed9f2adc770c0f904d6665eaf25833381862127", @"/Areas/Administration/Views/AdministrationCars/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a496ca497b02f93cb2ec41b618c292bc8004c343", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Views_AdministrationCars_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Car</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddedByUser.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Make.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BodyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BodyType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed9f2adc770c0f904d6665eaf2583338186212714090", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aed9f2adc770c0f904d6665eaf2583338186212714357", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 72 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Areas\Administration\Views\AdministrationCars\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed9f2adc770c0f904d6665eaf2583338186212716189", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
