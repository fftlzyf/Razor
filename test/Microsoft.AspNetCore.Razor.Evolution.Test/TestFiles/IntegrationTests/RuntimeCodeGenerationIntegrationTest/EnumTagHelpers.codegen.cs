#pragma checksum "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9124dcd7da8c06ab193a971690c676c5e0adaac"
namespace Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestFiles
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    public class TestFiles_IntegrationTests_RuntimeCodeGenerationIntegrationTest_EnumTagHelpers
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
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper = null;
        private global::TestNamespace.CatchAllTagHelper __TestNamespace_CatchAllTagHelper = null;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
  
    var enumValue = MyEnum.MyValue;


#line default
#line hidden
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
#line 7 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = MyEnum.MyValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __TestNamespace_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
AddHtmlAttributeValue("", 128, MyEnum.MySecondValue, 128, 21, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
#line 9 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = global::Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestTagHelperDescriptors+MyEnum.MyValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __TestNamespace_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
#line 10 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = global::Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestTagHelperDescriptors+MyEnum.MySecondValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __TestNamespace_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_CatchAllTagHelper.CatchAll = global::Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestTagHelperDescriptors+MyEnum.MyValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("catch-all", __TestNamespace_CatchAllTagHelper.CatchAll, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
#line 11 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = enumValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __TestNamespace_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_CatchAllTagHelper.CatchAll = enumValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("catch-all", __TestNamespace_CatchAllTagHelper.CatchAll, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
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
    }
}
