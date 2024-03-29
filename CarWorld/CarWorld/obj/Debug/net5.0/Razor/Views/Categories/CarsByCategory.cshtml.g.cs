#pragma checksum "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4228075ef971bcd6711bcd585a8462e24d7e057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_CarsByCategory), @"mvc.1.0.view", @"/Views/Categories/CarsByCategory.cshtml")]
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
#line 1 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.HomePageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CarShowsViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CreateCarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.SearchCarViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.ViewModels.CategoriesViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4228075ef971bcd6711bcd585a8462e24d7e057", @"/Views/Categories/CarsByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a8757b38d52904ef507625fda7c7c681ee78c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categories_CarsByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CarById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PagingPartialCarCategories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
  
    this.ViewData["Title"] = $"Cars in {this.Model.BodyTypeName} category";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 7 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
                   Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h1>\r\n\r\n<hr>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
     foreach (var car in this.Model.Cars)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media col-md-4 p-2\">\r\n            <img class=\"mr-3\"");
            BeginWriteAttribute("src", " src=\"", 321, "\"", 342, 1);
#nullable restore
#line 16 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
WriteAttributeValue("", 327, car.PictureUrl, 327, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"170\" height=\"105\" alt=\"Generic placeholder image\">\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4228075ef971bcd6711bcd585a8462e24d7e0577297", async() => {
#nullable restore
#line 18 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
                                                                                                    Write(car.MakeName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 18 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
                                                                                                                  Write(car.ModelName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
                                                                                 WriteLiteral(car.CarId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                ");
#nullable restore
#line 19 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
           Write(car.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<hr>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4228075ef971bcd6711bcd585a8462e24d7e05710915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 27 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Categories\CarsByCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br>\r\n<br>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
