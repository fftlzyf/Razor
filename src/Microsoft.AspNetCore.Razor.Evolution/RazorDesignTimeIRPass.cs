// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.Evolution.Intermediate;

namespace Microsoft.AspNetCore.Razor.Evolution
{
    internal class RazorDesignTimeIRPass : RazorIRPassBase
    {
        internal const string DesignTimeVariable = "__o";

        public override int Order => 25;

        public override DocumentIRNode ExecuteCore(DocumentIRNode irDocument)
        {
            var walker = new DesignTimeHelperWalker();
            walker.VisitDocument(irDocument);

            return irDocument;
        }

        internal class DesignTimeHelperWalker : RazorIRNodeWalker
        {
            private MethodDeclarationIRNode _directiveTokenHelper;

            public override void VisitClass(ClassDeclarationIRNode node)
            {
                const string DirectiveTokenHelperMethodName = "__RazorDirectiveTokenHelpers__";

                var designTimeHelperDeclaration = new CSharpStatementIRNode()
                {
                    Content = $"private static {typeof(object).FullName} {DesignTimeVariable} = null;",
                };

                node.Children.Insert(0, designTimeHelperDeclaration);

                var restoreWarningPragma = new CSharpStatementIRNode()
                {
                    Content = "#pragma warning restore 219",
                };

                node.Children.Insert(0, restoreWarningPragma);

                _directiveTokenHelper = new MethodDeclarationIRNode()
                {
                    AccessModifier = "private",
                    ReturnType = "void",
                    Name = DirectiveTokenHelperMethodName,
                };

                node.Children.Insert(0, _directiveTokenHelper);

                var disableWarningPragma = new CSharpStatementIRNode()
                {
                    Content = "#pragma warning disable 219",
                };

                node.Children.Insert(0, disableWarningPragma);

                VisitDefault(node);
            }

            public override void VisitDirectiveToken(DirectiveTokenIRNode node)
            {
                _directiveTokenHelper.Children.Add(node);
            }
        }
    }
}
