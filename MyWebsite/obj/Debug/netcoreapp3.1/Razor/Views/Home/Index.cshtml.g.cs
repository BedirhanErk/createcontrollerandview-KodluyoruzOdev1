#pragma checksum "C:\Users\Bedirhan\source\repos\MyWebsite\MyWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Bedirhan\source\repos\MyWebsite\MyWebsite\Views\_ViewImports.cshtml"
using MyWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bedirhan\source\repos\MyWebsite\MyWebsite\Views\_ViewImports.cshtml"
using MyWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f475a34e109fa4ecd4f54fbc085f99ea094629a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/assets/css/style-starter.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/assets/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Bedirhan\source\repos\MyWebsite\MyWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f14770", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""//fonts.googleapis.com/css?family=Nunito:400,600,700,800,900&display=swap"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Hind&display=swap"" rel=""stylesheet"">
    <!-- //web fonts -->
    <!-- Template CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f15451", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f17334", async() => {
                WriteLiteral(@"
    <section class=""w3l-about "">
        <div class=""skills-bars py-5"">
            <div class=""container py-md-3"">
                <div class=""heading text-center mx-auto"">
                    <h3 class=""head"">Welcome To My Site</h3>
                    <p class=""my-3 head"">
                        I am a 4th grade student at Aksaray University Industrial Engineering. I'm interested in the software. I want to improve myself in the field of software and work in this field in the future.

                        I am interested in ASP.Net Mvc, Sql, Ms Office Ms Excel Vba, C #, Node.js, Matlab, Arduino, PostgreSql, Wordpress programs. I am currently developing Web Projects with Mvc, in addition to working with PostgreSql.
                    </p>

                </div>
                <div class=""row mt-5 pt-3"">
                    <div class=""col-lg-4 col-md-4 col-sm-6 skills-bar-grids mb-4 pb-2"">
                        <h4>Matlab</h4>
                        <div class=""progress"">
        ");
                WriteLiteral(@"                    <div class=""progress-bar progress-bar-striped bg-color"" role=""progressbar"" style=""width: 50% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-4 col-sm-6 skills-bar-grids mb-4 pb-2"">
                        <h4>Wordpress</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-color"" role=""progressbar"" style=""width: 80% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-6 skills-bar-grids mb-4 pb-2"">
                        <h4>C#</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-color"" role=""progre");
                WriteLiteral(@"ssbar"" style=""width: 60% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-6 skills-bar-grids mb-4 pb-2"">
                        <h4>PostgreSQL</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-color"" role=""progressbar"" style=""width: 70% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-6 skills-bar-grids mb-4 pb-2"">
                        <h4>MsSQL</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-color"" role=""progressbar"" style=""width: 90% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-va");
                WriteLiteral(@"luemax=""100"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-4 col-sm-6 skills-bar-grids "">
                        <h4>ASP.NET MVC5</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-color"" role=""progressbar"" style=""width: 80% ;height:4px;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    
    
    <script src=""assets/js/jquery-3.3.1.min.js""></script>
    <script src=""assets/js/lightbox-plus-jquery.min.js""></script>
    <section class=""services-12"" id=""experience"">
        <div class=""form-12-content"">
            <div class=""container"">
                <div class=""grid grid-column-2 "">

                    <div class=""column1"">
         ");
                WriteLiteral(@"               <h3 class=""mb-5"">Experiences</h3>
                        <div class=""experience-top"">
                            <h5>Tem 2020 -Ağu 2020</h5>
                            <h4>Intern</h4>
                            <p class=""my-3 text-white"">Konto Sayım</p>
                        </div>
                        <div class=""experience-top"">
                            <h5>Ağu 2019 - Eki 2019</h5>
                            <h4>Intern</h4>
                            <p class=""my-3 text-white"">Casselli</p>
                        </div>

                    </div>
                    <div class=""column2"">
                        <h3 class=""mb-5"">Education</h3>
                        <div class=""experience-top"">
                            <h5>2017 - 2020</h5>
                            <h4>Aksaray University</h4>
                            <p class=""my-3 text-white"">Industrial Engineering 4th Year Student.</p>
                        </div>
                    </div>
    ");
                WriteLiteral("            </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    \r\n\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98bf8d9b9dd9adc16aff0f5b4eea34ec4d3d59f113135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
    $(function () {
      $('.navbar-toggler').click(function () {
        $('body').toggleClass('noscroll');
      })
    });
    </script>
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
            integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous"">
    </script>

    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""
            integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous"">
    </script>

    <!-- Smooth scrolling -->



");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
