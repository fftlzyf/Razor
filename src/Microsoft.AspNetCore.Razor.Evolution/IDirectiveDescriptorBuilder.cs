﻿// Copyright(c) .NET Foundation.All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Razor.Evolution
{
    public interface IDirectiveDescriptorBuilder
    {
        IDirectiveDescriptorBuilder AddType();

        IDirectiveDescriptorBuilder AddMember();

        IDirectiveDescriptorBuilder AddString();

        IDirectiveDescriptorBuilder AddLiteral(string literal);

        DirectiveDescriptor Build();
    }
}
