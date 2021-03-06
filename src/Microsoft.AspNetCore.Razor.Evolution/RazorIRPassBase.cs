﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.Evolution.Intermediate;

namespace Microsoft.AspNetCore.Razor.Evolution
{
    internal abstract class RazorIRPassBase : IRazorIRPass
    {
        public RazorEngine Engine { get; set; }

        public virtual int Order => 0;

        protected void ThrowForMissingDocumentDependency<TDocumentDependency>(TDocumentDependency value)
        {
            if (value == null)
            {
                throw new InvalidOperationException(
                    Resources.FormatFeatureDependencyMissing(
                        GetType().Name,
                        typeof(TDocumentDependency).Name,
                        typeof(RazorEngine).Name));
            }
        }

        protected void ThrowForMissingEngineDependency<TEngineDependency>(TEngineDependency value)
        {
            if (value == null)
            {
                throw new InvalidOperationException(
                    Resources.FormatFeatureDependencyMissing(
                        GetType().Name,
                        typeof(TEngineDependency).Name,
                        typeof(RazorCodeDocument).Name));
            }
        }

        protected virtual void OnIntialized(RazorCodeDocument codeDocument)
        {
        }

        public DocumentIRNode Execute(RazorCodeDocument codeDocument, DocumentIRNode irDocument)
        {
            if (codeDocument == null)
            {
                throw new ArgumentNullException(nameof(codeDocument));
            }

            if (irDocument == null)
            {
                throw new ArgumentNullException(nameof(irDocument));
            }

            if (Engine == null)
            {
                throw new InvalidOperationException(Resources.FormatPhaseMustBeInitialized(nameof(Engine)));
            }

            OnIntialized(codeDocument);

            return ExecuteCore(irDocument);
        }

        public abstract DocumentIRNode ExecuteCore(DocumentIRNode irDocument);
    }
}
