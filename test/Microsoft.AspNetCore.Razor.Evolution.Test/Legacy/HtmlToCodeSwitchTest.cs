// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using Xunit;

namespace Microsoft.AspNetCore.Razor.Evolution.Legacy
{
    public class HtmlToCodeSwitchTest : CsHtmlMarkupParserTestBase
    {
        [Fact]
        public void ParseBlockSwitchesWhenCharacterBeforeSwapIsNonAlphanumeric()
        {
            ParseBlockTest("<p>foo#@i</p>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<p>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("foo#"),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("i").AsImplicitExpression(CSharpCodeParser.DefaultKeywords).Accepts(AcceptedCharacters.NonWhiteSpace)),
                    new MarkupTagBlock(
                        Factory.Markup("</p>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSwitchesToCodeWhenSwapCharacterEncounteredMidTag()
        {
            ParseBlockTest("<foo @bar />",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo "),
                        new ExpressionBlock(
                            Factory.CodeTransition(),
                            Factory.Code("bar")
                                   .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                   .Accepts(AcceptedCharacters.NonWhiteSpace)),
                        Factory.Markup(" />").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSwitchesToCodeWhenSwapCharacterEncounteredInAttributeValue()
        {
            ParseBlockTest("<foo bar=\"@baz\" />",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo"),
                        new MarkupBlock(new AttributeBlockChunkGenerator("bar", new LocationTagged<string>(" bar=\"", 4, 0, 4), new LocationTagged<string>("\"", 14, 0, 14)),
                            Factory.Markup(" bar=\"").With(SpanChunkGenerator.Null),
                            new MarkupBlock(new DynamicAttributeBlockChunkGenerator(new LocationTagged<string>(string.Empty, 10, 0, 10), 10, 0, 10),
                                new ExpressionBlock(
                                    Factory.CodeTransition(),
                                    Factory.Code("baz")
                                           .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                           .Accepts(AcceptedCharacters.NonWhiteSpace))),
                            Factory.Markup("\"").With(SpanChunkGenerator.Null)),
                        Factory.Markup(" />").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSwitchesToCodeWhenSwapCharacterEncounteredInTagContent()
        {
            ParseBlockTest("<foo>@bar<baz>@boz</baz></foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml(),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("bar")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    new MarkupTagBlock(
                        Factory.Markup("<baz>").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml(),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("boz")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    new MarkupTagBlock(
                        Factory.Markup("</baz>").Accepts(AcceptedCharacters.None)),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockParsesCodeWithinSingleLineMarkup()
        {
            // TODO: Fix at a later date, HTML should be a tag block: https://github.com/aspnet/Razor/issues/101
            ParseBlockTest("@:<li>Foo @Bar Baz" + Environment.NewLine
                         + "bork",
                new MarkupBlock(
                    Factory.MarkupTransition(),
                    Factory.MetaMarkup(":", HtmlSymbolType.Colon),
                    Factory.Markup("<li>Foo ").With(new SpanEditHandler(CSharpLanguageCharacteristics.Instance.TokenizeString)),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("Bar")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup(" Baz" + Environment.NewLine)
                        .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockSupportsCodeWithinComment()
        {
            ParseBlockTest("<foo><!-- @foo --></foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("<!-- "),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("foo")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup(" -->").Accepts(AcceptedCharacters.None),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSupportsCodeWithinSGMLDeclaration()
        {
            ParseBlockTest("<foo><!DOCTYPE foo @bar baz></foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("<!DOCTYPE foo "),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("bar")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup(" baz>").Accepts(AcceptedCharacters.None),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSupportsCodeWithinCDataDeclaration()
        {
            ParseBlockTest("<foo><![CDATA[ foo @bar baz]]></foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("<![CDATA[ foo "),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("bar")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup(" baz]]>").Accepts(AcceptedCharacters.None),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockSupportsCodeWithinXMLProcessingInstruction()
        {
            ParseBlockTest("<foo><?xml foo @bar baz?></foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("<?xml foo "),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("bar")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup(" baz?>").Accepts(AcceptedCharacters.None),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockDoesNotSwitchToCodeOnEmailAddressInText()
        {
            ParseBlockTest("<foo>anurse@microsoft.com</foo>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<foo>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("anurse@microsoft.com"),
                    new MarkupTagBlock(
                        Factory.Markup("</foo>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockDoesNotSwitchToCodeOnEmailAddressInAttribute()
        {
            ParseBlockTest("<a href=\"mailto:anurse@microsoft.com\">Email me</a>",
                new MarkupBlock(
                    new MarkupTagBlock(
                        Factory.Markup("<a"),
                        new MarkupBlock(new AttributeBlockChunkGenerator("href", new LocationTagged<string>(" href=\"", 2, 0, 2), new LocationTagged<string>("\"", 36, 0, 36)),
                            Factory.Markup(" href=\"").With(SpanChunkGenerator.Null),
                            Factory.Markup("mailto:anurse@microsoft.com")
                                   .With(new LiteralAttributeChunkGenerator(new LocationTagged<string>(string.Empty, 9, 0, 9), new LocationTagged<string>("mailto:anurse@microsoft.com", 9, 0, 9))),
                            Factory.Markup("\"").With(SpanChunkGenerator.Null)),
                        Factory.Markup(">").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("Email me"),
                    new MarkupTagBlock(
                        Factory.Markup("</a>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseBlockGivesWhitespacePreceedingAtToCodeIfThereIsNoMarkupOnThatLine()
        {
            ParseBlockTest("   <ul>" + Environment.NewLine
                         + "    @foreach(var p in Products) {" + Environment.NewLine
                         + "        <li>Product: @p.Name</li>" + Environment.NewLine
                         + "    }" + Environment.NewLine
                         + "    </ul>",
                new MarkupBlock(
                    Factory.Markup("   "),
                    new MarkupTagBlock(
                        Factory.Markup("<ul>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup(Environment.NewLine),
                    new StatementBlock(
                        Factory.Code("    ").AsStatement(),
                        Factory.CodeTransition(),
                        Factory.Code("foreach(var p in Products) {" + Environment.NewLine).AsStatement(),
                        new MarkupBlock(
                            Factory.Markup("        "),
                            new MarkupTagBlock(
                                Factory.Markup("<li>").Accepts(AcceptedCharacters.None)),
                            Factory.Markup("Product: "),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.Code("p.Name")
                                       .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                       .Accepts(AcceptedCharacters.NonWhiteSpace)),
                            new MarkupTagBlock(
                                Factory.Markup("</li>").Accepts(AcceptedCharacters.None)),
                            Factory.Markup(Environment.NewLine).Accepts(AcceptedCharacters.None)),
                        Factory.Code("    }" + Environment.NewLine).AsStatement().Accepts(AcceptedCharacters.None)),
                    Factory.Markup("    "),
                    new MarkupTagBlock(
                        Factory.Markup("</ul>").Accepts(AcceptedCharacters.None))));
        }

        [Fact]
        public void ParseDocumentGivesWhitespacePreceedingAtToCodeIfThereIsNoMarkupOnThatLine()
        {
            ParseDocumentTest("   <ul>" + Environment.NewLine
                            + "    @foreach(var p in Products) {" + Environment.NewLine
                            + "        <li>Product: @p.Name</li>" + Environment.NewLine
                            + "    }" + Environment.NewLine
                            + "    </ul>",
                new MarkupBlock(
                    Factory.Markup("   "),
                    new MarkupTagBlock(
                        Factory.Markup("<ul>")),
                    Factory.Markup(Environment.NewLine),
                    new StatementBlock(
                        Factory.Code("    ").AsStatement(),
                        Factory.CodeTransition(),
                        Factory.Code("foreach(var p in Products) {" + Environment.NewLine).AsStatement(),
                        new MarkupBlock(
                            Factory.Markup("        "),
                            new MarkupTagBlock(
                                Factory.Markup("<li>").Accepts(AcceptedCharacters.None)),
                            Factory.Markup("Product: "),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.Code("p.Name")
                                       .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                       .Accepts(AcceptedCharacters.NonWhiteSpace)),
                            new MarkupTagBlock(
                                Factory.Markup("</li>").Accepts(AcceptedCharacters.None)),
                            Factory.Markup(Environment.NewLine).Accepts(AcceptedCharacters.None)),
                        Factory.Code("    }" + Environment.NewLine).AsStatement().Accepts(AcceptedCharacters.None)),
                    Factory.Markup("    "),
                    new MarkupTagBlock(
                        Factory.Markup("</ul>"))));
        }

        [Fact]
        public void SectionContextGivesWhitespacePreceedingAtToCodeIfThereIsNoMarkupOnThatLine()
        {
            var sectionDescriptor = CSharpCodeParser.SectionDirectiveDescriptor;
            ParseDocumentTest("@section foo {" + Environment.NewLine
                            + "    <ul>" + Environment.NewLine
                            + "        @foreach(var p in Products) {" + Environment.NewLine
                            + "            <li>Product: @p.Name</li>" + Environment.NewLine
                            + "        }" + Environment.NewLine
                            + "    </ul>" + Environment.NewLine
                            + "}",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new DirectiveBlock(new DirectiveChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor),
                        Factory.CodeTransition(),
                        Factory.MetaCode("section").Accepts(AcceptedCharacters.None),
                        Factory.Span(SpanKind.Code, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.WhiteSpace),
                        Factory.Span(SpanKind.Code, "foo", CSharpSymbolType.Identifier)
                            .Accepts(AcceptedCharacters.NonWhiteSpace)
                            .With(new DirectiveTokenChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor.Tokens.First())),
                        Factory.Span(SpanKind.Markup, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.AllWhiteSpace),
                        Factory.MetaCode("{").AutoCompleteWith(null, atEndOfSpan: true).Accepts(AcceptedCharacters.None),
                        new MarkupBlock(
                            Factory.Markup(Environment.NewLine + "    "),
                            new MarkupTagBlock(
                                Factory.Markup("<ul>")),
                            Factory.Markup(Environment.NewLine),
                            new StatementBlock(
                                Factory.Code("        ").AsStatement(),
                                Factory.CodeTransition(),
                                Factory.Code("foreach(var p in Products) {" + Environment.NewLine).AsStatement(),
                                new MarkupBlock(
                                    Factory.Markup("            "),
                                    new MarkupTagBlock(
                                        Factory.Markup("<li>").Accepts(AcceptedCharacters.None)),
                                    Factory.Markup("Product: "),
                                    new ExpressionBlock(
                                        Factory.CodeTransition(),
                                        Factory.Code("p.Name")
                                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                                    new MarkupTagBlock(
                                        Factory.Markup("</li>").Accepts(AcceptedCharacters.None)),
                                    Factory.Markup(Environment.NewLine).Accepts(AcceptedCharacters.None)),
                                Factory.Code("        }" + Environment.NewLine).AsStatement().Accepts(AcceptedCharacters.None)),
                            Factory.Markup("    "),
                            new MarkupTagBlock(
                                Factory.Markup("</ul>")),
                            Factory.Markup(Environment.NewLine)),
                        Factory.MetaCode("}").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        [Fact]
        public void CSharpCodeParserDoesNotAcceptLeadingOrTrailingWhitespaceInDesignMode()
        {
            ParseBlockTest("   <ul>" + Environment.NewLine
                         + "    @foreach(var p in Products) {" + Environment.NewLine
                         + "        <li>Product: @p.Name</li>" + Environment.NewLine
                         + "    }" + Environment.NewLine
                         + "    </ul>",
                new MarkupBlock(
                    Factory.Markup("   "),
                    new MarkupTagBlock(
                        Factory.Markup("<ul>").Accepts(AcceptedCharacters.None)),
                    Factory.Markup(Environment.NewLine + "    "),
                    new StatementBlock(
                        Factory.CodeTransition(),
                        Factory.Code($"foreach(var p in Products) {{{Environment.NewLine}        ").AsStatement(),
                        new MarkupBlock(
                            new MarkupTagBlock(
                                Factory.Markup("<li>").Accepts(AcceptedCharacters.None)),
                            Factory.Markup("Product: "),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.Code("p.Name").AsImplicitExpression(CSharpCodeParser.DefaultKeywords).Accepts(AcceptedCharacters.NonWhiteSpace)),
                            new MarkupTagBlock(
                                Factory.Markup("</li>").Accepts(AcceptedCharacters.None))),
                        Factory.Code(Environment.NewLine + "    }").AsStatement().Accepts(AcceptedCharacters.None)),
                    Factory.Markup(Environment.NewLine + "    "),
                    new MarkupTagBlock(
                        Factory.Markup("</ul>").Accepts(AcceptedCharacters.None))),
                designTime: true);
        }

        // Tests for "@@" escape sequence:
        [Fact]
        public void ParseBlockTreatsTwoAtSignsAsEscapeSequence()
        {
            HtmlParserTestUtils.RunSingleAtEscapeTest(ParseBlockTest);
        }

        [Fact]
        public void ParseBlockTreatsPairsOfAtSignsAsEscapeSequence()
        {
            HtmlParserTestUtils.RunMultiAtEscapeTest(ParseBlockTest);
        }

        [Fact]
        public void ParseDocumentTreatsTwoAtSignsAsEscapeSequence()
        {
            HtmlParserTestUtils.RunSingleAtEscapeTest(ParseDocumentTest, lastSpanAcceptedCharacters: AcceptedCharacters.Any);
        }

        [Fact]
        public void ParseDocumentTreatsPairsOfAtSignsAsEscapeSequence()
        {
            HtmlParserTestUtils.RunMultiAtEscapeTest(ParseDocumentTest, lastSpanAcceptedCharacters: AcceptedCharacters.Any);
        }

        [Fact]
        public void SectionBodyTreatsTwoAtSignsAsEscapeSequence()
        {
            ParseDocumentTest("@section Foo { <foo>@@bar</foo> }",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new DirectiveBlock(new DirectiveChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor),
                        Factory.CodeTransition(),
                        Factory.MetaCode("section").Accepts(AcceptedCharacters.None),
                        Factory.Span(SpanKind.Code, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.WhiteSpace),
                        Factory.Span(SpanKind.Code, "Foo", CSharpSymbolType.Identifier)
                            .Accepts(AcceptedCharacters.NonWhiteSpace)
                            .With(new DirectiveTokenChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor.Tokens.First())),
                        Factory.Span(SpanKind.Markup, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.AllWhiteSpace),
                        Factory.MetaCode("{").AutoCompleteWith(null, atEndOfSpan: true).Accepts(AcceptedCharacters.None),
                        new MarkupBlock(
                            Factory.Markup(" "),
                            new MarkupTagBlock(
                                Factory.Markup("<foo>")),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@bar"),
                            new MarkupTagBlock(
                                Factory.Markup("</foo>")),
                            Factory.Markup(" ")),
                        Factory.MetaCode("}").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        [Fact]
        public void SectionBodyTreatsPairsOfAtSignsAsEscapeSequence()
        {
            ParseDocumentTest("@section Foo { <foo>@@@@@bar</foo> }",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new DirectiveBlock(new DirectiveChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor),
                        Factory.CodeTransition(),
                        Factory.MetaCode("section").Accepts(AcceptedCharacters.None),
                        Factory.Span(SpanKind.Code, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.WhiteSpace),
                        Factory.Span(SpanKind.Code, "Foo", CSharpSymbolType.Identifier)
                            .Accepts(AcceptedCharacters.NonWhiteSpace)
                            .With(new DirectiveTokenChunkGenerator(CSharpCodeParser.SectionDirectiveDescriptor.Tokens.First())),
                        Factory.Span(SpanKind.Markup, " ", CSharpSymbolType.WhiteSpace).Accepts(AcceptedCharacters.AllWhiteSpace),
                        Factory.MetaCode("{").AutoCompleteWith(null, atEndOfSpan: true).Accepts(AcceptedCharacters.None),
                        new MarkupBlock(
                            Factory.Markup(" "),
                            new MarkupTagBlock(
                                Factory.Markup("<foo>")),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@"),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@"),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.Code("bar")
                                       .AsImplicitExpression(CSharpCodeParser.DefaultKeywords)
                                       .Accepts(AcceptedCharacters.NonWhiteSpace)),
                            new MarkupTagBlock(
                                Factory.Markup("</foo>")),
                            Factory.Markup(" ")),
                        Factory.MetaCode("}").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }
    }
}
