#pragma checksum "C:\Users\benja\Documents\Website Portfolio\V1.0\WebsitePortfolio\Views\Shared\GoodReads.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17bd993c0917cccac77f7f724a419bf6d88803b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GoodReads), @"mvc.1.0.view", @"/Views/Shared/GoodReads.cshtml")]
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
#line 1 "C:\Users\benja\Documents\Website Portfolio\V1.0\WebsitePortfolio\Views\_ViewImports.cshtml"
using WebsitePortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\benja\Documents\Website Portfolio\V1.0\WebsitePortfolio\Views\_ViewImports.cshtml"
using WebsitePortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd993c0917cccac77f7f724a419bf6d88803b0", @"/Views/Shared/GoodReads.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f41e8ec9ea2354385235f3243a70710f6f9adfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GoodReads : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    #customize-list {
        float: left;
        margin-left: 20px;
        list-style: none;
    }

    #gr_updates_widget {
        float: left;
        border-radius: 5px;
        background-color: #fff;
        border: solid #683205 10px;
        -webkit-box-shadow: 0px 0px 4px 1px #595959, inset 0px 0px 0px 1px #7D730B;
        -moz-box-shadow: 0px 0px 4px 1px #595959, inset 0px 0px 0px 1px #7D730B;
        box-shadow: 0px 0px 4px 1px #595959, inset 0px 0px 0px 1px #7D730B;
        padding: 15px 0 0px 15px;
        width: 250px;
        height: 365px;
    }

    #gr_footer {
        margin-bottom: 0px;
        height: 30px;
    }

    #gr_updates_widget p {
        padding: 0px;
        margin: 0;
        font-size: 14px;
    }

    #gr_footer img {
        width: 100px;
        float: left;
    }
</style>
<div id=""gr_updates_widget"">
    <iframe id=""the_iframe"" src=""https://goodreads.com/widgets/user_update_widget?height=400&num_updates=3&user=108430336&wid");
            WriteLiteral(@"th=250"" width=""248"" height=""330"" frameborder=""0""></iframe>
    <div id=""gr_footer"">
        <a href=""https://www.goodreads.com/""><img alt=""Goodreads: Book reviews, recommendations, and discussion"" src=""https://www.goodreads.com/images/layout/goodreads_logo_140.png"" /></a>
    </div>
</div>
");
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
