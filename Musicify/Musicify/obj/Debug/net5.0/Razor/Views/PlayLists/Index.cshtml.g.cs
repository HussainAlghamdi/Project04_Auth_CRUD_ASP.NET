#pragma checksum "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fc0feecfd870ac6b87024b077d871a4f323e868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlayLists_Index), @"mvc.1.0.view", @"/Views/PlayLists/Index.cshtml")]
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
#line 1 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\_ViewImports.cshtml"
using Musicify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\_ViewImports.cshtml"
using Musicify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc0feecfd870ac6b87024b077d871a4f323e868", @"/Views/PlayLists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8336368d6a00c2c19e65a82a16d5c122839f62e", @"/Views/_ViewImports.cshtml")]
    public class Views_PlayLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
  
    var PlayLists = (List<PlayListModel>)ViewData["PlayLists"];
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div style=""backdrop-filter: blur(10px)"">
    <table class=""table table-hover table-danger mt-3 table-curved "" style=""opacity:0.7; "">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Name</th>
                <th scope=""col""></th>
                <th scope=""col""></th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
             foreach (var PlayList in PlayLists)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-dark\">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
                      count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
                   Write(PlayList.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td><button type=\"button\" class=\"btn btn-outline-danger\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 863, 2);
            WriteAttributeValue("", 832, "/PlayLists/details/", 832, 19, true);
#nullable restore
#line 29 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
WriteAttributeValue("", 851, PlayList.Id, 851, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> SHOW </a></button></td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fc0feecfd870ac6b87024b077d871a4f323e8686354", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Remove\" class=\"btn btn-danger\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
                                                    WriteLiteral(PlayList.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\hussa\Desktop\Project04_Auth_CRUD_ASP.NET\Musicify\Musicify\Views\PlayLists\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n");
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
