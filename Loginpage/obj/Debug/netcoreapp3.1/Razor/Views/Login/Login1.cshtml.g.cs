#pragma checksum "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\Login\Login1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0082df5aded09c8ea36e58d2981b62e36358ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login1), @"mvc.1.0.view", @"/Views/Login/Login1.cshtml")]
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
#line 1 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\_ViewImports.cshtml"
using Loginpage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\_ViewImports.cshtml"
using Loginpage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0082df5aded09c8ea36e58d2981b62e36358ebe", @"/Views/Login/Login1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cccb0ef929669fa7f4b5fed1b3452581736e345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loginpage.Models.UserModel>
    #nullable disable
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
#nullable restore
#line 2 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\Login\Login1.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0082df5aded09c8ea36e58d2981b62e36358ebe3571", async() => {
                WriteLiteral(@"
   
    <meta name=""abstract"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <style>
        body {
    background: #2962FF;
    font-family: Arial, Helvetica, sans-serif
}

.card {
    border-radius: 13px;
    border: none
}

.card-heading {
    font-weight: bold;
    font-family:
}

.form-control {
    border: none;
    border-radius: 10px;
    background: rgba(165, 147, 69, 0.075)
}

.btn {
    border: 1px solid #2979FF;
    border-radius: 10px;
    width: 120px
}

.forgot {
    font: #00ACC1;
    font-weight: bold;
    color: #26C6DA;
    font-size: 15px;
    padding-left: 35px
}

.form-control {
    background-color: #eee !important
}

.form-control:fo");
                WriteLiteral("cus {\r\n    color: #495057;\r\n    border-color: #fff !important;\r\n    outline: 0;\r\n    box-shadow: 0 0 0 0 rgba(0, 123, 255, .25) !important\r\n}\r\n\r\na {\r\n    text-decoration: none !important\r\n}\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0082df5aded09c8ea36e58d2981b62e36358ebe5832", async() => {
                WriteLiteral(@"

<div class=""container d-flex justify-content-center"">
    <div class=""card mx-5 my-5"">
        <div class=""card-body py-2 px-2"">
            <h2 class=""card-heading py-3 px-5"">Log In</h2>
            <div class=""row rone mx-3 my-3"">
                <div class=""col-md-6"">
                      <label for=""username"" class=""text-info"">Username:</label><br>
                       ");
#nullable restore
#line 76 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\Login\Login1.cshtml"
                  Write(Html.TextBoxFor(m => m.username, new { @class = "form-control", @placeholder = "Email", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                      <label for=\"password\" class=\"text-info\">Password:</label><br>\r\n                      ");
#nullable restore
#line 80 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\Login\Login1.cshtml"
                 Write(Html.PasswordFor(m => m.password, new { @class = "form-control", @placeholder = "Password", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row rtwo mx-3"">
                <div class=""col-md-6"">
                    <div>
                        <button type=""submit"" class=""btn btn-primary mb"" value=""submit"">log In</button>
                    </div>
                </div>

            </div>
            <div style=""color:red;"">");
#nullable restore
#line 91 "E:\ASP.NET CORE\testapp\DHLLoginPageDemo1\loginpage\Loginpage\Loginpage\Views\Login\Login1.cshtml"
                               Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loginpage.Models.UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
