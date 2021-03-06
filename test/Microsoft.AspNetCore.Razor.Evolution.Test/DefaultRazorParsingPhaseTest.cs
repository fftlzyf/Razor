﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.AspNetCore.Razor.Evolution
{
    public class DefaultRazorParsingPhaseTest
    {
        [Fact]
        public void Execute_AddsSyntaxTree()
        {
            // Arrange
            var phase = new DefaultRazorParsingPhase();
            var engine = RazorEngine.CreateEmpty(b => b.Phases.Add(phase));

            var codeDocument = TestRazorCodeDocument.CreateEmpty();

            // Act
            phase.Execute(codeDocument);

            // Assert
            Assert.NotNull(codeDocument.GetSyntaxTree());
        }

        [Fact]
        public void Execute_UsesConfigureParserFeatures()
        {
            // Arrange
            var phase = new DefaultRazorParsingPhase();
            var engine = RazorEngine.CreateEmpty((b) =>
            {
                b.Phases.Add(phase);
                b.Features.Add(new MyConfigureParserOptions());
            });

            var codeDocument = TestRazorCodeDocument.CreateEmpty();

            // Act
            phase.Execute(codeDocument);

            // Assert
            var syntaxTree = codeDocument.GetSyntaxTree();
            var directive = Assert.Single(syntaxTree.Options.Directives);
            Assert.Equal("test_directive", directive.Name);
        }

        private class MyConfigureParserOptions : IRazorConfigureParserFeature
        {
            public RazorEngine Engine { get; set; }

            public int Order { get; }

            public void Configure(RazorParserOptions options)
            {
                options.Directives.Add(DirectiveDescriptorBuilder.Create("test_directive").Build());
            }
        }
    }
}
