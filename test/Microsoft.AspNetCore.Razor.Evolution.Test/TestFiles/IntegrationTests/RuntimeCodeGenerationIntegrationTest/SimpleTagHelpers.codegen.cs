#pragma checksum "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/SimpleTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248dc9c0c1ef35d3636cfb2fa7f5ac0f8a0b553a"
namespace Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestFiles
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    public class TestFiles_IntegrationTests_RuntimeCodeGenerationIntegrationTest_SimpleTagHelpers
    {
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::InputTagHelper __InputTagHelper = null;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Hola</p>\r\n<form>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __InputTagHelper = CreateTagHelper<global::InputTagHelper>();
            __tagHelperExecutionContext.Add(__InputTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Hello");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __InputTagHelper.FooProp = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __InputTagHelper.FooProp, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.SingleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("text");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("type", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</form>");
        }
        #pragma warning restore 1998
    }
}
