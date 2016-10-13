﻿//// Copyright (c) .NET Foundation. All rights reserved.
//// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

//using System.Linq;

//namespace Microsoft.AspNetCore.Razor.Evolution.SyntaxTreePhase
//{
//    public class DefaultSyntaxTreePhase : ISyntaxTreePhase
//    {
//        public RazorEngine Engine { get; set; }

//        public void Execute(RazorCodeDocument document)
//        {
//            var syntaxTree = document.GetSyntaxTree();
//            if (syntaxTree == null)
//            {
//                var directiveDescriptors = document.GetDirectiveDescriptors();
//                syntaxTree = RazorSyntaxTreeParser.Parse(document.Source, directiveDescriptors);
//            }

//            var passes = Engine.Features.OfType<ISyntaxTreePass>().OrderBy(p => p.Order).ToArray();
//            foreach (var pass in passes)
//            {
//                syntaxTree = pass.Execute(document, syntaxTree);
//            }

//            document.SetSyntaxTree(syntaxTree);
//        }
//    }
//}
