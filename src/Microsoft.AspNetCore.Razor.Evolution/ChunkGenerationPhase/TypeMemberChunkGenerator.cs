// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.Evolution.SyntaxTreePhase;

namespace Microsoft.AspNetCore.Razor.Evolution.ChunkGenerationPhase
{
    public class TypeMemberChunkGenerator : SpanChunkGenerator
    {
        public override void GenerateChunk(Span target, ChunkGeneratorContext context)
        {
            //context.ChunkTreeBuilder.AddTypeMemberChunk(target.Content, target);
        }

        public override string ToString()
        {
            return "TypeMember";
        }
    }
}
