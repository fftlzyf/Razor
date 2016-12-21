// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.AspNetCore.Razor.Evolution.Legacy
{
    public class CSharpTokenizerTest : CSharpTokenizerTestBase
    {
        private new CSharpSymbol IgnoreRemaining => (CSharpSymbol)base.IgnoreRemaining;

        [Fact]
        public void Next_Returns_Null_When_EOF_Reached()
        {
            TestTokenizer("");
        }

        [Fact]
        public void Next_Returns_Newline_Token_For_Single_CR()
        {
            TestTokenizer(
                "\r\ra",
                new CSharpSymbol("\r", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\r", CSharpSymbolType.NewLine) { Offset = 1 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Newline_Token_For_Single_LF()
        {
            TestTokenizer(
                "\n\na",
                new CSharpSymbol("\n", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\n", CSharpSymbolType.NewLine) { Offset = 1 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Newline_Token_For_Single_NEL()
        {
            // NEL: Unicode "Next Line" U+0085
            TestTokenizer(
                "\u0085\u0085a",
                new CSharpSymbol("\u0085", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\u0085", CSharpSymbolType.NewLine) { Offset = 1 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Newline_Token_For_Single_Line_Separator()
        {
            // Unicode "Line Separator" U+2028
            TestTokenizer(
                "\u2028\u2028a",
                new CSharpSymbol("\u2028", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\u2028", CSharpSymbolType.NewLine) { Offset = 1 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Newline_Token_For_Single_Paragraph_Separator()
        {
            // Unicode "Paragraph Separator" U+2029
            TestTokenizer(
                "\u2029\u2029a",
                new CSharpSymbol("\u2029", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\u2029", CSharpSymbolType.NewLine) { Offset = 1 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Single_Newline_Token_For_CRLF()
        {
            TestTokenizer(
                "\r\n\r\na",
                new CSharpSymbol("\r\n", CSharpSymbolType.NewLine) { Offset = 0 },
                new CSharpSymbol("\r\n", CSharpSymbolType.NewLine) { Offset = 2 },
                IgnoreRemaining);
        }

        [Fact]
        public void Next_Returns_Token_For_Whitespace_Characters()
        {
            TestTokenizer(
                " \f\t\u000B \n ",
                new CSharpSymbol(" \f\t\u000B ", CSharpSymbolType.WhiteSpace) { Offset = 0 },
                new CSharpSymbol("\n", CSharpSymbolType.NewLine) { Offset = 5 },
                new CSharpSymbol(" ", CSharpSymbolType.WhiteSpace) { Offset = 6 });
        }

        [Fact]
        public void Transition_Is_Recognized()
        {
            TestSingleToken("@", CSharpSymbolType.Transition);
        }

        [Fact]
        public void Transition_Is_Recognized_As_SingleCharacter()
        {
            TestTokenizer(
                "@(",
                new CSharpSymbol("@", CSharpSymbolType.Transition),
                new CSharpSymbol("(", CSharpSymbolType.LeftParenthesis));
        }
    }
}
