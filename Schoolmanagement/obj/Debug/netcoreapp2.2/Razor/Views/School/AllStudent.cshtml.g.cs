#pragma checksum "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cca59c788f23654adab184516aacc4f453f536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_AllStudent), @"mvc.1.0.view", @"/Views/School/AllStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/School/AllStudent.cshtml", typeof(AspNetCore.Views_School_AllStudent))]
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
#line 1 "D:\IIHT\Task-9\School\Schoolmanagement\Views\_ViewImports.cshtml"
using Schoolmanagement;

#line default
#line hidden
#line 2 "D:\IIHT\Task-9\School\Schoolmanagement\Views\_ViewImports.cshtml"
using Schoolmanagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cca59c788f23654adab184516aacc4f453f536", @"/Views/School/AllStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec79eed50c4d4bea28f2390b8cca61fb9f726b1", @"/Views/_ViewImports.cshtml")]
    public class Views_School_AllStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Schoolmanagement.BusinessLayer.ViewModels.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
  
    ViewData["Title"] = "All Student";

#line default
#line hidden
            BeginContext(114, 209, true);
            WriteLiteral("\r\n<div class=\"card\" style=\"width:100%; margin-top:0px;\">\r\n    <div class=\"card-header bg-warning text-white\">\r\n        <h3 class=\"text-center text-uppercase\">Student Information</h3>\r\n    </div>\r\n</div>\r\n<p>\r\n");
            EndContext();
#line 12 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
     using (Html.BeginForm("School", "AllStudent", FormMethod.Get))
    {

#line default
#line hidden
            BeginContext(399, 27, true);
            WriteLiteral("        <b>Search By:</b>\r\n");
            EndContext();
            BeginContext(440, 19, true);
            WriteLiteral("Student By Name  : ");
            EndContext();
            BeginContext(468, 22, false);
#line 15 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                                    Write(Html.TextBox("search"));

#line default
#line hidden
            EndContext();
            BeginContext(490, 55, true);
            WriteLiteral(" <input type=\"submit\" name=\"submit\" value=\"Search\" />\r\n");
            EndContext();
            BeginContext(554, 89, false);
#line 16 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
   Write(Html.ActionLink(" | Back to full List", "AllStudent", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
#line 16 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                                                                                                  
    }

#line default
#line hidden
            BeginContext(652, 86, true);
            WriteLiteral("</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(739, 32, false);
#line 22 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(771, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(795, 31, false);
#line 23 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(826, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(850, 37, false);
#line 24 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.classList));

#line default
#line hidden
            EndContext();
            BeginContext(887, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(911, 35, false);
#line 25 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.Section));

#line default
#line hidden
            EndContext();
            BeginContext(946, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(970, 33, false);
#line 26 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1027, 38, false);
#line 27 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
           Write(Html.DisplayNameFor(m => m.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 49, true);
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
         if (Model.PageCount() == 0)
        {

#line default
#line hidden
            BeginContext(1163, 133, true);
            WriteLiteral("            <tr>\r\n                <td style=\"color:red;\" colspan=\"12\">\r\n                    Records not found |\r\n                    ");
            EndContext();
            BeginContext(1297, 86, false);
#line 36 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
               Write(Html.ActionLink("Go to all Student", "AllStudent", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 39 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 42 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
             foreach (var notice in Model.PaginatedStudent())
            {

#line default
#line hidden
            BeginContext(1541, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1588, 11, false);
#line 45 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1631, 30, false);
#line 46 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.DOB.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1661, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1693, 16, false);
#line 47 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.classList);

#line default
#line hidden
            EndContext();
            BeginContext(1709, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1741, 14, false);
#line 48 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.Section);

#line default
#line hidden
            EndContext();
            BeginContext(1755, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1787, 12, false);
#line 49 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1831, 17, false);
#line 50 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
                   Write(notice.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(1848, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 52 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
            }

#line default
#line hidden
#line 52 "D:\IIHT\Task-9\School\Schoolmanagement\Views\School\AllStudent.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1904, 30, true);
            WriteLiteral("        </tbody>\r\n</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schoolmanagement.BusinessLayer.ViewModels.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
