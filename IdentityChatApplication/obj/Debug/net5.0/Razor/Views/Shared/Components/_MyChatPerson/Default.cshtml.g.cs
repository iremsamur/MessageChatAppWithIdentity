#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1876d36e24bb7edea4773d54ed70f01340b6a50b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__MyChatPerson_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_MyChatPerson/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\_ViewImports.cshtml"
using IdentityChatApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\_ViewImports.cshtml"
using IdentityChatApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1876d36e24bb7edea4773d54ed70f01340b6a50b", @"/Views/Shared/Components/_MyChatPerson/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ada3db32fb69b20646fecdacd53a73f411bffa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__MyChatPerson_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Friendlist>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-4 col-xl-3 chat\">\r\n\t<div class=\"card mb-sm-3 mb-md-0 contacts_card\">\r\n\t\t");
#nullable restore
#line 5 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
   Write(await Component.InvokeAsync("_SearchPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<div class=\"card-body contacts_body\">\r\n\t\t\t<ui class=\"contacts\">\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
                 foreach(var item in Model){
					

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					<li class=""active"" >
						<div class=""d-flex bd-highlight"">
							<div class=""img_cont"">
								<img src=""https://static.turbosquid.com/Preview/001292/481/WV/_D.jpg"" class=""rounded-circle user_img"">
								<span class=""online_icon""></span>
							</div>
							<div class=""user_info"">

								<a");
            BeginWriteAttribute("href", " href=\"", 587, "\"", 653, 2);
            WriteAttributeValue("", 594, "/Message/GetSelectedPersonInformations/", 594, 39, true);
#nullable restore
#line 18 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
WriteAttributeValue("", 633, item.FriendPersonID, 633, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 18 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
                                                                                                       Write(item.FriendPerson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
                                                                                                                               Write(item.FriendPerson.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\t\t\t\t\t\t\t\t<p>Kalid is online</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_MyChatPerson\Default.cshtml"
						

				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\t\t\t\r\n\t\t\t\r\n\t\t\t</ui>\r\n\t\t</div>\r\n\t\t<div class=\"card-footer\"></div>\r\n\t</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Friendlist>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
