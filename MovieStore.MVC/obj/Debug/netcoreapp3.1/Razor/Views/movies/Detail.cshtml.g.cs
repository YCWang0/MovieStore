#pragma checksum "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537c7309f41837d8a68063bc6f70842b44399d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_movies_Detail), @"mvc.1.0.view", @"/Views/movies/Detail.cshtml")]
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
#line 1 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537c7309f41837d8a68063bc6f70842b44399d77", @"/Views/movies/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_movies_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Core.Entities.Detail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Favorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"container-fluid\" style=\"margin:0px;padding:0px;border:0px\">\r\n        <div class=\"row\" style=\"margin:0px;padding:0px;border:0px ; background-color:black;\">\r\n            <div class=\"col-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 269, "\"", 303, 1);
#nullable restore
#line 7 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 275, Model.DetailMovie.PosterUrl, 275, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 304, "\"", 351, 4);
            WriteAttributeValue("", 310, "Movie", 310, 5, true);
            WriteAttributeValue(" ", 315, "Poster", 316, 7, true);
            WriteAttributeValue(" ", 322, "for", 323, 4, true);
#nullable restore
#line 7 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue(" ", 326, Model.DetailMovie.Title, 327, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail \" style=\"border-radius:0px;margin:0px;border:0px;padding:0px\" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h2><p class=\"text-light\">");
#nullable restore
#line 10 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                     Write(Model.DetailMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h2>\r\n                <p class=\"text-light\">");
#nullable restore
#line 11 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                 Write(Model.DetailMovie.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"text-light\">\r\n");
#nullable restore
#line 13 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                     foreach (var g in Model.DetailGenre)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"badge badge-secondary\">");
#nullable restore
#line 15 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                             Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 16 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <p><a href=\"#\" class=\"badge badge-warning\">");
#nullable restore
#line 18 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                      Write(Model.DetailRating.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                <p class=\"text-light\">");
#nullable restore
#line 19 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                 Write(Model.DetailMovie.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-3\">\r\n                <ul class=\"list-group list-group-flush\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                     if (Model.IsFavorited)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\" style=\"background-color:black\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537c7309f41837d8a68063bc6f70842b44399d779278", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1477, "\"", 1511, 1);
#nullable restore
#line 28 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 1485, Model.DetailCurrentUserId, 1485, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1583, "\"", 1612, 1);
#nullable restore
#line 29 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 1591, Model.DetailMovie.Id, 1591, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n                                <button type=\"submit\">\r\n                                    <i class=\"fas fa-heart\"></i>\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 35 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\" style=\"background-color:black\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537c7309f41837d8a68063bc6f70842b44399d7712709", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2169, "\"", 2203, 1);
#nullable restore
#line 40 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 2177, Model.DetailCurrentUserId, 2177, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2275, "\"", 2304, 1);
#nullable restore
#line 41 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 2283, Model.DetailMovie.Id, 2283, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n                                <button type=\"submit\">\r\n                                    <i class=\"far fa-heart\"></i>\r\n                                </button>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 48 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <li class=\"list-group-item\" style=\"background-color:black\">\r\n");
#nullable restore
#line 53 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                         if (!Model.IsReviewed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""button"" class=""btn btn-light "" data-toggle=""modal"" data-target=""#WriteReviewModel"">
                                <i class=""far fa-edit mr-1""></i>
                                REVIEW
                            </button>
");
#nullable restore
#line 59 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-light\">you have reviewed this movie</p>\r\n");
#nullable restore
#line 63 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </li>
                    <li class=""list-group-item"" style=""background-color:black"">
                        <i class=""fas fa-play"" style=""color:white""><text class=""text-light"">TRAILER</text></i>
                    </li>

                    <li class=""list-group-item"" style=""background-color:black"">

");
#nullable restore
#line 73 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                         if (Model.isPurchased)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-success btn-lg btn-block btn-sm\">\r\n                                WATCH MOVIE\r\n                            </button>\r\n");
#nullable restore
#line 78 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-warning btn-lg \" data-toggle=\"modal\" data-target=\"#ConfirmPurchaseModel\">\r\n                                BUY ");
#nullable restore
#line 82 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                               Write(Model.DetailMovie.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 84 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </li>

                </ul>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <h3>MOVIE FACTS</h3>
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <i class=""far fa-calendar-alt"">
                            RelaceDate <span class=""badge badge-dark"">");
#nullable restore
#line 99 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                                 Write(Model.DetailMovie.ReleaseDate.Value.ToString("MM:dd:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </i>\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <i class=\"fas fa-hourglass-half\">\r\n                            Run Time <span class=\"badge badge-dark\">");
#nullable restore
#line 104 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                               Write(Model.DetailMovie.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span>\r\n                        </i>\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <i class=\"far fa-money-bill-alt\">\r\n                            Box Office <span class=\"badge badge-dark\"> ");
#nullable restore
#line 109 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                                  Write(string.Format("{0:C}", @Model.DetailMovie.Revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</span>\r\n                        </i>\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <i class=\"fas fa-dollar-sign\">\r\n                            Budget  <span class=\"badge badge-dark\">");
#nullable restore
#line 114 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                              Write(string.Format("{0:C}", @Model.DetailMovie.Revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </i>
                    </li>
                    <li class=""list-group-item""><i class=""fab fa-imdb""></i><i class=""fas fa-share-square""></i></li>
                </ul>
            </div>
            <div class=""col-8"">
                <h3>CAST</h3>
                <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 123 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                     foreach (var c in Model.DetailCast)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6021, "\"", 6041, 1);
#nullable restore
#line 126 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 6027, c.ProfilePath, 6027, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" class=\"rounded-circle\" style=\"width:30px;height:30px\" />\r\n\r\n                            ");
#nullable restore
#line 128 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                       Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <p>   </p>\r\n                        </li>\r\n");
#nullable restore
#line 131 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"col\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537c7309f41837d8a68063bc6f70842b44399d7723585", async() => {
                WriteLiteral(@"
        <div class=""modal fade"" id=""ConfirmPurchaseModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""buyMovieModal"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <p>Are you sure you wanna buy</p>

                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 153 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                                  Write(Model.DetailMovie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" which is $");
#nullable restore
#line 153 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                                                                                                     Write(Model.DetailMovie.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n                    </div>\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7272, "\"", 7301, 1);
#nullable restore
#line 155 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 7280, Model.DetailMovie.Id, 7280, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n\r\n");
#nullable restore
#line 157 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7448, "\"", 7482, 1);
#nullable restore
#line 159 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 7456, Model.DetailCurrentUserId, 7456, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" />\r\n");
#nullable restore
#line 160 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <div class=""modal-footer"">
                        <input type=""submit"" value=""YES"" class=""btn btn-primary"" />
                        <input type=""button"" class=""btn btn-outline-dark"" data-dismiss=""modal"" value=""NO"" />
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537c7309f41837d8a68063bc6f70842b44399d7728679", async() => {
                WriteLiteral(@"
        <div class=""modal fade"" id=""WriteReviewModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""WriteReviewModel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <p>what do you think of this movie?</p>

                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>

                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-10"">
                                <input type=""text"" class=""form-control"" placeholder=""Review text"" name=""ReviewText"">
                            </div>
                            <div class=""col-2"">
                                <input type=""number"" class=""form-control"" placeholder=""Rating"" min=""1"" max");
                WriteLiteral("=\"10\" name=\"Rating\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 9121, "\"", 9150, 1);
#nullable restore
#line 193 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 9129, Model.DetailMovie.Id, 9129, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n");
#nullable restore
#line 194 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 9295, "\"", 9329, 1);
#nullable restore
#line 196 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
WriteAttributeValue("", 9303, Model.DetailCurrentUserId, 9303, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" />\r\n");
#nullable restore
#line 197 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\movies\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <div class=""modal-footer"">
                        <input type=""submit"" value=""YES"" class=""btn btn-primary"" />
                        <input type=""button"" class=""btn btn-outline-dark"" data-dismiss=""modal"" value=""NO"" />
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Core.Entities.Detail> Html { get; private set; }
    }
}
#pragma warning restore 1591
