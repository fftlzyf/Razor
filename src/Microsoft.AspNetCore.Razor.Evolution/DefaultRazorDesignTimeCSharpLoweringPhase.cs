// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.Evolution.Intermediate;

namespace Microsoft.AspNetCore.Razor.Evolution
{
    internal class DefaultRazorDesignTimeCSharpLoweringPhase : RazorCSharpLoweringPhaseBase
    {
        protected override void ExecuteCore(RazorCodeDocument codeDocument)
        {
            var irDocument = codeDocument.GetIRDocument();
            ThrowForMissingDependency(irDocument);

            var syntaxTree = codeDocument.GetSyntaxTree();
            ThrowForMissingDependency(syntaxTree);

            // Render design time CSharp
        }

        private class CSharpRenderer : PageStructureCSharpRenderer
        {
            public CSharpRenderer(CSharpRenderingContext context) : base(context)
            {
            }

            public override void VisitCSharpToken(CSharpTokenIRNode node)
            {
                Context.Writer.Write(node.Content);
            }

            public override void VisitCSharpExpression(CSharpExpressionIRNode node)
            {
                if (node.Children.Count == 0)
                {
                    return;
                }

                if (node.SourceRange != null)
                {
                    using (new LinePragmaWriter(Context.Writer, node.SourceRange))
                    {
                        var padding = BuildOffsetPadding(RazorDesignTimeIRPass.DesignTimeVariable.Length, node.SourceRange, Context);

                        Context.Writer
                            .Write(padding)
                            .WriteStartAssignment(RazorDesignTimeIRPass.DesignTimeVariable);

                        using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                        {
                            VisitDefault(node);
                        }

                        Context.Writer.WriteLine(";");
                    }
                }
                else
                {
                    Context.Writer.WriteStartAssignment(RazorDesignTimeIRPass.DesignTimeVariable);
                    VisitDefault(node);
                    Context.Writer.WriteLine(";");
                }
            }

            public override void VisitUsingStatement(UsingStatementIRNode node)
            {
                Context.Writer.WriteUsing(node.Content);
            }

            public override void VisitCSharpStatement(CSharpStatementIRNode node)
            {
                if (node.SourceRange != null)
                {
                    using (new LinePragmaWriter(Context.Writer, node.SourceRange))
                    {
                        var padding = BuildOffsetPadding(0, node.SourceRange, Context);
                        Context.Writer.Write(padding);

                        using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                        {
                            Context.Writer.Write(node.Content);
                        }
                    }
                }
                else
                {
                    Context.Writer.WriteLine(node.Content);
                }
            }

            public override void VisitDirectiveToken(DirectiveTokenIRNode node)
            {
                const string TypeHelper = "__typeHelper";

                var tokenKind = node.Descriptor.Kind;
                if (node.SourceRange == null || node.Descriptor.Kind == DirectiveTokenKind.Literal)
                {
                    return;
                }

                // Wrap the directive token in a lambda to isolate variable names.
                Context.Writer
                    .Write("((")
                    .Write(typeof(Action).FullName)
                    .Write(")(");
                using (Context.Writer.BuildLambda(endLine: true))
                {
                    switch (tokenKind)
                    {
                        case DirectiveTokenKind.Type:
                            using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                            {
                                Context.Writer.Write(node.Content);
                            }

                            Context.Writer
                                .Write(" ")
                                .WriteStartAssignment(TypeHelper)
                                .WriteLine("null;");
                            break;
                        case DirectiveTokenKind.Member:
                            Context.Writer
                                .Write(typeof(object).FullName)
                                .Write(" ");

                            using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                            {
                                Context.Writer.Write(node.Content);
                            }
                            Context.Writer.WriteLine(" = null;");
                            break;
                        case DirectiveTokenKind.String:
                            Context.Writer
                                .Write(typeof(object).FullName)
                                .Write(" ")
                                .WriteStartAssignment(TypeHelper);

                            if (node.Content.StartsWith("\"", StringComparison.Ordinal))
                            {
                                using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                                {
                                    Context.Writer.Write(node.Content);
                                }
                            }
                            else
                            {
                                Context.Writer.Write("\"");
                                using (new LineMappingBuilder(Context.Writer, node.SourceRange))
                                {
                                    Context.Writer.Write(node.Content);
                                }
                                Context.Writer.Write("\"");
                            }

                            Context.Writer.WriteLine(";");
                            break;
                    }
                }
                Context.Writer.WriteLine("))();");
            }

            public override void VisitTemplate(TemplateIRNode node)
            {
                const string ItemParameterName = "item";
                const string TemplateWriterName = "__razor_template_writer";

                Context.Writer
                    .Write(ItemParameterName).Write(" => ")
                    .WriteStartNewObject("HelperResult" /* ORIGINAL: TemplateTypeName */);

                var initialRenderingConventions = Context.RenderingConventions;
                var redirectConventions = new CSharpRedirectRenderingConventions(TemplateWriterName, Context.Writer);
                Context.RenderingConventions = redirectConventions;
                using (Context.Writer.BuildAsyncLambda(endLine: false, parameterNames: TemplateWriterName))
                {
                    VisitDefault(node);
                }
                Context.RenderingConventions = initialRenderingConventions;

                Context.Writer.WriteEndMethodInvocation(endLine: false);
            }
        }
    }
}
