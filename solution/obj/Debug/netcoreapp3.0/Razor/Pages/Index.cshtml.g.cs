#pragma checksum "C:\Users\vinicius.ribeiro\source\repos\esp32_webclient\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977e7ff7bb57ef499ab99edae7b0a7d7df7403af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(esp32_webclient.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace esp32_webclient.Pages
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
#line 1 "C:\Users\vinicius.ribeiro\source\repos\esp32_webclient\Pages\_ViewImports.cshtml"
using esp32_webclient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977e7ff7bb57ef499ab99edae7b0a7d7df7403af", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30f2a5b8124f7ab81a28847d4baa644b110c4d3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\vinicius.ribeiro\source\repos\esp32_webclient\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977e7ff7bb57ef499ab99edae7b0a7d7df7403af3249", async() => {
                WriteLiteral(@"
    <title>ESP Web Server</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""icon"" href=""data:,"">
    <style>
        html {
            font-family: Arial;
            display: inline-block;
            text-align: center;
        }

        h2 {
            font-size: 3.0rem;
        }

        p {
            font-size: 3.0rem;
        }

        body {
            max-width: 600px;
            margin: 0px auto;
            padding-bottom: 25px;
        }

        .switch {
            position: relative;
            display: inline-block;
            width: 120px;
            height: 68px
        }

            .switch input {
                display: none
            }

        .slider {
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: #ccc;
            border-radius: 6px
        }

            .slider:before {
    ");
                WriteLiteral(@"            position: absolute;
                content: """";
                height: 52px;
                width: 52px;
                left: 8px;
                bottom: 8px;
                background-color: #fff;
                -webkit-transition: .4s;
                transition: .4s;
                border-radius: 3px
            }

        input:checked + .slider {
            background-color: #b30000
        }

            input:checked + .slider:before {
                -webkit-transform: translateX(52px);
                -ms-transform: translateX(52px);
                transform: translateX(52px)
            }
    </style>

    <script src=""http://192.168.1.200"" crossorigin=""anonymous""></script>

    <script>
        function toggleCheckbox(element) {
            var xhr = new XMLHttpRequest();

            if (element.checked) {
                xhr.open(""GET"", ""http://192.168.1.200/update?output="" + element.id + ""&state=1"", true);
            }
            else {
  ");
                WriteLiteral(@"              xhr.open(""GET"", ""http://192.168.1.200/update?output="" + element.id + ""&state=0"", true);
            }
            xhr.send();
          }
    </script>

    <script>
        function toggleInput(element,device) {
            var xhr = new XMLHttpRequest();
           

            if (element.value == 1) {
                  
                    xhr.open(""GET"", ""http://192.168.1.200/update?output="" + device.value + ""&state=1"", true);

            }
            else {
               
                xhr.open(""GET"", ""http://192.168.1.200/update?output="" + device.value + ""&state=0"", true);
            }
           
            xhr.send();
            
          }
    </script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977e7ff7bb57ef499ab99edae7b0a7d7df7403af7091", async() => {
                WriteLiteral(@"
    <h2>ESP Web Server</h2>
    <h4>Output - GPIO 2</h4>
    <label class=""switch"">
        <input type=""checkbox"" onchange=""toggleCheckbox(this)"" id=""2"" "" + outputState(2) + "">
        <span class=""slider""></span>
    </label>

    <h4>Output - GPIO 2</h4>

    <label class=""switch"">
        <input type=""checkbox"" onchange=""toggleCheckbox(this)"" id=""2"" "" + outputState(2) + "">
        <span class=""slider""></span>
    </label>


    <h4> Envior por Valor de Input </h4>
    <input hidden id=""led"" value=""2""></input>
    <input id=""texto""> </input> </br></br>
    <button onclick=""toggleInput(texto,led)"" id=""3"">ENVIAR</button>
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591