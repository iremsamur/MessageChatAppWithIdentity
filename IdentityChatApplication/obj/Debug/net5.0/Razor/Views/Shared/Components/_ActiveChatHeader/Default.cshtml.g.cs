#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6c421959afeeedb0c63328aa9e141a2e97aed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ActiveChatHeader_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ActiveChatHeader/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6c421959afeeedb0c63328aa9e141a2e97aed3", @"/Views/Shared/Components/_ActiveChatHeader/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ada3db32fb69b20646fecdacd53a73f411bffa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ActiveChatHeader_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card-header msg_head\">\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml"
     if(Model!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""d-flex bd-highlight"">
			<div class=""img_cont"">
				<img src=""https://static.turbosquid.com/Preview/001292/481/WV/_D.jpg"" class=""rounded-circle user_img"">
				<span class=""online_icon""></span>
			</div>
			<div class=""user_info"">
				<!--Index'ten g??nderilen se??im yap??lan ki??inin bilgileri view componente gidiyor-->
				<span>Chat with ");
#nullable restore
#line 11 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml"
                                       Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t<p>1767 Messages</p>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"video_cam\">\r\n\t\t\t\t<span><i class=\"fas fa-video\"></i></span>\r\n\t\t\t\t<span><i class=\"fas fa-phone\"></i></span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 19 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml"
		

	}
	else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""d-flex bd-highlight"">
			<div class=""img_cont"">
				<img src=""https://static.turbosquid.com/Preview/001292/481/WV/_D.jpg"" class=""rounded-circle user_img"">
				<span class=""online_icon""></span>
			</div>
			<div class=""user_info"">
				<span>Chat with Kalid</span>
				<p>1767 Messages</p>
			</div>
			<div class=""video_cam"">
				<span><i class=""fas fa-video""></i></span>
				<span><i class=""fas fa-phone""></i></span>
			</div>
		</div>
");
#nullable restore
#line 37 "C:\Users\User\Desktop\UpSchoolBootcamp\IdentityChatApplication\IdentityChatApplication\Views\Shared\Components\_ActiveChatHeader\Default.cshtml"

	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

	<span id=""action_menu_btn""><i class=""fas fa-ellipsis-v""></i></span>
	<div class=""action_menu"">
		<ul>
			<li><i class=""fas fa-user-circle""></i> View profile</li>
			<li><i class=""fas fa-users""></i> Add to close friends</li>
			<li><i class=""fas fa-plus""></i> Add to group</li>
			<li><i class=""fas fa-ban""></i> Block</li>
		</ul>
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
