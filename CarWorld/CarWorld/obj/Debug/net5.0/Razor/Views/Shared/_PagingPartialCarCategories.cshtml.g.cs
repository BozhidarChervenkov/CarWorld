#pragma checksum "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6978e06dde54cb91002e06738a041e02e7a1024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PagingPartialCarCategories), @"mvc.1.0.view", @"/Views/Shared/_PagingPartialCarCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6978e06dde54cb91002e06738a041e02e7a1024", @"/Views/Shared/_PagingPartialCarCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a8757b38d52904ef507625fda7c7c681ee78c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PagingPartialCarCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CarsByCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<nav aria-label=\"...\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 113, "\"", 183, 3);
            WriteAttributeValue("", 121, "page-item", 121, 9, true);
            WriteAttributeValue(" ", 130, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 5 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                              if(!Model.HasPreviousPage) {

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 5 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                               }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 131, 51, false);
            WriteAttributeValue(" ", 182, "", 183, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6978e06dde54cb91002e06738a041e02e7a10246965", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                               WriteLiteral(Model.PreviousPageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 8 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
         for (int i = Model.PageNumber - 4; i < Model.PageNumber; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
             if (i > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6978e06dde54cb91002e06738a041e02e7a102410138", async() => {
#nullable restore
#line 12 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                                                         WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item active\">\r\n            <span class=\"page-link\">\r\n                ");
#nullable restore
#line 17 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
           Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"sr-only\">(current)</span>\r\n            </span>\r\n        </li>\r\n");
#nullable restore
#line 21 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
         for (int i = Model.PageNumber + 1; i < Model.PageNumber + 4; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
             if (i <= Model.PagesCount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6978e06dde54cb91002e06738a041e02e7a102414546", async() => {
#nullable restore
#line 25 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                                                         WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\" ");
#nullable restore
#line 28 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                               if (!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" disabled");
#nullable restore
#line 28 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6978e06dde54cb91002e06738a041e02e7a102418520", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Shared\_PagingPartialCarCategories.cshtml"
                                                                                               WriteLiteral(Model.NextPageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
