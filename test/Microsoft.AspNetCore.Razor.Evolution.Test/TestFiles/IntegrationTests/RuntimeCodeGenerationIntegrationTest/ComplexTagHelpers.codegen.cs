#pragma checksum "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cc5f5ed458e4e33874c4242798b195a31ab065c"
namespace Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestFiles
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    public class TestFiles_IntegrationTests_RuntimeCodeGenerationIntegrationTest_ComplexTagHelpers
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
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper = null;
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper = null;
        private global::TestNamespace.InputTagHelper2 __TestNamespace_InputTagHelper2 = null;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
 if (true)
{
    var checkbox = "checkbox";



#line default
#line hidden
            WriteLiteral("    <div class=\"randomNonTagHelperAttribute\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n            <h1>Set Time:</h1>\r\n");
#line 10 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
             if (false)
            {


#line default
#line hidden
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                    WriteLiteral("New Time: ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
                    }
                    );
                    __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                    __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                    __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                    BeginWriteTagHelperAttribute();
                    WriteLiteral("text");
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __TestNamespace_InputTagHelper.Type = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __TestNamespace_InputTagHelper.Type, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                    __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    WriteLiteral("Enter in a new time...");
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("placeholder", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#line 13 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
            }
            else
            {


#line default
#line hidden
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                    WriteLiteral("Current Time: ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
                    }
                    );
                    __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                    __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                    __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                    BeginWriteTagHelperAttribute();
#line 16 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
                                 WriteLiteral(checkbox);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __TestNamespace_InputTagHelper.Type = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __TestNamespace_InputTagHelper.Type, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                    __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
#line 16 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                BeginWriteTagHelperAttribute();
#line 17 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
                  WriteLiteral(true ? "checkbox" : "anything");

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __TestNamespace_InputTagHelper.Type = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("tYPe", __TestNamespace_InputTagHelper.Type, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.SingleQuotes);
                __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagOnly, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                BeginWriteTagHelperAttribute();
#line 18 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
                              if(true) {

#line default
#line hidden
                WriteLiteral("checkbox");
#line 18 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
                                                               } else {

#line default
#line hidden
                WriteLiteral("anything");
#line 18 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
                                                                                              }

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __TestNamespace_InputTagHelper.Type = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __TestNamespace_InputTagHelper.Type, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.SingleQuotes);
                __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#line 19 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
            }


#line default
#line hidden
                WriteLiteral("        ");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "time", 3, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 146, "Current", 146, 7, true);
            AddHtmlAttributeValue(" ", 153, "Time:", 154, 6, true);
#line 8 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 159, DateTime.Now, 160, 13, false);

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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n");
#line 22 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
               var @object = false;

#line default
#line hidden
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagOnly, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
#line 23 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = (@object);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("ChecKED", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("first value");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("unbound", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_PTagHelper.Age = DateTimeOffset.Now.Year - 1970;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __TestNamespace_PTagHelper.Age, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("second value");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("unbound", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                BeginWriteTagHelperAttribute();
                WriteLiteral("hello");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("unbound", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                WriteLiteral("world");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("unbound", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = (DateTimeOffset.Now.Year > 2014);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
#line 25 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_PTagHelper.Age = -1970 + @DateTimeOffset.Now.Year;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __TestNamespace_PTagHelper.Age, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagOnly, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
#line 29 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = DateTimeOffset.Now.Year > 2014;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
#line 28 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_PTagHelper.Age = DateTimeOffset.Now.Year - 1970;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __TestNamespace_PTagHelper.Age, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
#line 32 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked =    @(  DateTimeOffset.Now.Year  ) > 2014   ;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
#line 31 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_PTagHelper.Age = ("My age is this long.".Length);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __TestNamespace_PTagHelper.Age, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#line 34 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
   Write(someMethod(item => new HelperResult(async(__razor_template_writer) => {
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.StartTagAndEndTag, "test", async() => {
        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.Evolution.Legacy.TagMode.SelfClosing, "test", async() => {
        }
        );
        __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
        __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
        __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
        __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
#line 34 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = checked;

#line default
#line hidden
        __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
        if (!__tagHelperExecutionContext.Output.IsContentModified)
        {
            await __tagHelperExecutionContext.SetOutputContentAsync();
        }
        Write(__tagHelperExecutionContext.Output);
        __tagHelperExecutionContext = __tagHelperScopeManager.End();
    }
    );
    __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
    __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
#line 34 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
__TestNamespace_PTagHelper.Age = 123;

#line default
#line hidden
    __tagHelperExecutionContext.AddTagHelperAttribute("age", __TestNamespace_PTagHelper.Age, global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
    BeginWriteTagHelperAttribute();
    WriteLiteral("hello");
    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
    __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.Evolution.Legacy.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    WriteTo(__razor_template_writer, __tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
}
)));

#line default
#line hidden
            WriteLiteral("\r\n    </div>\r\n");
#line 36 "TestFiles/IntegrationTests/RuntimeCodeGenerationIntegrationTest/ComplexTagHelpers.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
