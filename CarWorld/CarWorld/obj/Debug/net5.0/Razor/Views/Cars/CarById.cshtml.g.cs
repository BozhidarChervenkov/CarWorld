#pragma checksum "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b3ea3164dd26604930b7279bab22f5a8ddd884"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b3ea3164dd26604930b7279bab22f5a8ddd884", @"/Views/Cars/CarById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a8757b38d52904ef507625fda7c7c681ee78c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_CarById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWorld.ViewModels.CarViewModels.CarViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
  
    this.ViewData["Title"] = $"{Model.Make.Name} {Model.Model.Name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b3ea3164dd26604930b7279bab22f5a8ddd8847256", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b3ea3164dd26604930b7279bab22f5a8ddd8848635", async() => {
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
#line 26 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                   Write(Model.Make.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 26 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                    Write(Model.Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <div class=\"text-center\">\r\n");
#nullable restore
#line 30 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
             if (this.User.IsInRole("Admin") || (Model.CurrentUserId == Model.AddedByUser.Id))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b3ea3164dd26604930b7279bab22f5a8ddd88410675", async() => {
                    WriteLiteral("Edit car");
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
#line 32 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b3ea3164dd26604930b7279bab22f5a8ddd88413361", async() => {
                    WriteLiteral("Delete car");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <hr>\r\n\r\n        <div class=\"row text-center offset-2 col-md-8\">\r\n            <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\" data-pause=\"hover\" data-interval=\"3700\">\r\n\r\n");
#nullable restore
#line 42 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                 foreach (var picture in Model.Pictures)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 2232, "\"", 2306, 2);
                WriteAttributeValue("", 2240, "carousel-item", 2240, 13, true);
#nullable restore
#line 44 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue(" ", 2253, picture == Model.Pictures.First() ? "active" : "", 2254, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <img class=\"center-block img-responsive rounded\" width=\"680\" height=\"400\"");
                BeginWriteAttribute("src", " src=\"", 2407, "\"", 2436, 1);
#nullable restore
#line 45 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue("", 2413, picture.Url.ToString(), 2413, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2437, "\"", 2443, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <hr>\r\n\r\n        <div class=\"text-justify\">\r\n            <h4 class=\"text-center my-2 font-weight-bold\">Description:</h4> ");
#nullable restore
#line 54 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group mt-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h4 class=\"font-weight-bold my-2\"><i class=\"fas fa-truck-pickup\"></i> Body type:</h4> ");
#nullable restore
#line 60 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                     Write(Model.BodyType.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <h4 class=\"font-weight-bold my-2\"><i class=\"fas fa-tachometer-alt\"></i> Year:</h4> ");
#nullable restore
#line 61 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                  Write(Model.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col align-content-end\">\r\n                    <h4 class=\"font-weight-bold offset-5 my-2\"><i class=\"fas fa-dollar-sign\"></i> Price:</h4>\r\n                    <p class=\"offset-5 my-2my-2\">");
#nullable restore
#line 65 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <h4 class=\"font-weight-bold offset-5 my-2my-2\"><i class=\"fas fa-calendar-alt\"></i> Created on:</h4>\r\n                    <p class=\"offset-5 my-2my-2\">");
#nullable restore
#line 67 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                            Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"p-1\" style=\"margin-left: 500px\">\r\n                <h4 class=\"font-weight-bold\">Rating:</h4>\r\n\r\n                <div class=\"row\">\r\n\r\n                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3727, "\"", 3762, 4);
                WriteAttributeValue("", 3737, "sendVote(", 3737, 9, true);
#nullable restore
#line 76 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue("", 3746, Model.Id, 3746, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3755, ",", 3755, 1, true);
                WriteAttributeValue(" ", 3756, "true)", 3757, 6, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fas fa-thumbs-up\" style=\"margin-right: 5px; margin-left: 20px;\"></i>\r\n                    </a>\r\n\r\n                    <div style=\"margin-right: 5px\" ; id=\"votesCount\">");
#nullable restore
#line 80 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                Write(Model.VotesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4025, "\"", 4061, 4);
                WriteAttributeValue("", 4035, "sendVote(", 4035, 9, true);
#nullable restore
#line 82 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
WriteAttributeValue("", 4044, Model.Id, 4044, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4053, ",", 4053, 1, true);
                WriteAttributeValue(" ", 4054, "false)", 4055, 7, true);
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""fas fa-thumbs-down""></i>
                    </a>

                </div>
            </div>

            <div class=""offset-4 col-md-7"">
                <h4 class=""font-weight-bold my-2 ""><i class=""fas fa-user""></i> Added by: ");
#nullable restore
#line 90 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                    Write(Model.AddedByUser.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 90 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                                                                                                 Write(Model.AddedByUser.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            </div>\r\n\r\n            <br>\r\n\r\n            <h5 class=\"font-weight-bold\"><i class=\"fas fa-comments\" style=\"margin-right:10px\"></i>Comments:</h5>\r\n");
#nullable restore
#line 96 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
              
                await Html.RenderPartialAsync("_MainCommentPartial", new CarCommentViewModel { CarId = Model.Id, UserId = Model.AddedByUser.Id, MainCommentId = 0 });
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
             foreach (var mc in Model.MainComments)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 101 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
              Write(mc.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral(" --- ");
#nullable restore
#line 101 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                              Write(mc.CreatedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <div style=\"margin-left: 120px\">\r\n                    <h5 class=\"font-weight-bold\"><i class=\"fas fa-reply\" style=\"margin-right:10px\"></i>Replies:</h5>\r\n");
#nullable restore
#line 104 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                      
                        await Html.RenderPartialAsync("_MainCommentPartial", new CarCommentViewModel { CarId = Model.Id, UserId = Model.AddedByUser.Id, MainCommentId = mc.Id });
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                     foreach (var sc in mc.SubComments)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>");
#nullable restore
#line 109 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                      Write(sc.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral(" --- ");
#nullable restore
#line 109 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                                      Write(sc.CreatedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 110 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 112 "D:\Web Projects\CarWorld\CarWorld\.vs\CarWorld\CarWorld\CarWorld\Views\Cars\CarById.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWorld.ViewModels.CarViewModels.CarViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
