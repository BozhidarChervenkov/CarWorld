#pragma checksum "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f56e4976af428ded743d62e3c0253ee25e381a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_CarById), @"mvc.1.0.view", @"/Views/Cars/CarById.cshtml")]
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
#line 1 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f56e4976af428ded743d62e3c0253ee25e381a6", @"/Views/Cars/CarById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadc35c08ac6a95bdbce36f63d4c09f65aa51392", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_CarById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWorld.ViewModels.CarViewModels.CarViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
  
    this.ViewData["Title"] = $"{Model.Make.Name} {Model.Model.Name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f56e4976af428ded743d62e3c0253ee25e381a63521", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f56e4976af428ded743d62e3c0253ee25e381a64900", async() => {
                WriteLiteral(@"
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

    <div class=""container"">
        <div class=""text-center"">
            <h1 class=""text-center p-2"">");
#nullable restore
#line 26 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                   Write(Model.Make.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 26 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                    Write(Model.Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <hr>\r\n\r\n        <div class=\"row text-center offset-2 col-md-8\">\r\n            <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\" data-pause=\"hover\" data-interval=\"3700\">\r\n\r\n");
#nullable restore
#line 34 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                 foreach (var picture in Model.Pictures)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 1766, "\"", 1840, 2);
                WriteAttributeValue("", 1774, "carousel-item", 1774, 13, true);
#nullable restore
#line 36 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue(" ", 1787, picture == Model.Pictures.First() ? "active" : "", 1788, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <img class=\"center-block img-responsive\" width=\"680\" height=\"400\"");
                BeginWriteAttribute("src", " src=\"", 1933, "\"", 1962, 1);
#nullable restore
#line 37 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue("", 1939, picture.Url.ToString(), 1939, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1963, "\"", 1969, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 39 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <hr>\r\n\r\n        <div class=\"text-justify\">\r\n            <h4 class=\"text-center my-2 font-weight-bold\">Description:</h4> ");
#nullable restore
#line 46 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h4 class=\"font-weight-bold my-2\"><i class=\"fas fa-truck-pickup\"></i> Body type:</h4> ");
#nullable restore
#line 52 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                     Write(Model.BodyType.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <h4 class=\"font-weight-bold my-2\"><i class=\"fas fa-tachometer-alt\"></i> Year:</h4> ");
#nullable restore
#line 53 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                  Write(Model.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col align-content-end\">\r\n                    <h4 class=\"font-weight-bold offset-5 my-2\"><i class=\"fas fa-dollar-sign\"></i> Price:</h4>\r\n                    <p class=\"offset-5 my-2my-2\">");
#nullable restore
#line 57 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <h4 class=\"font-weight-bold offset-5 my-2my-2\"><i class=\"fas fa-calendar-alt\"></i> Created on:</h4>\r\n                    <p class=\"offset-5 my-2my-2\">");
#nullable restore
#line 59 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                            Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
            </div>


            <div class=""text-justify"">
                <h4 class=""text-center my-2 font-weight-bold"">Rating:</h4>


            </div>

            

            <div class=""offset-4 col-md-7"">
                <h4 class=""font-weight-bold my-2 ""><i class=""fas fa-user""></i> Added by: ");
#nullable restore
#line 73 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                    Write(Model.AddedByUser.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 73 "D:\Web Projects\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                                 Write(Model.AddedByUser.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            </div>\r\n\r\n            <br>\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function sendVote(carId, isUpVote) {
            var json = { carId: carId, isUpVote: isUpVote };
            $.ajax({
                url: ""/api/votes"",
                type: ""POST"",
                data: JSON.stringify(json),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (data) {
                    $(""#votesCount"").html(data.votesCount);
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWorld.ViewModels.CarViewModels.CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
