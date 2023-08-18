﻿using Avro;
using Microsoft.CodeAnalysis;
using System;
using System.Text;

namespace AvroSerializer.Generators.SerializationGenerators
{
    public static class EnumGenerator
    {
        public static void GenerateSerializationSourceForEnum(EnumSchema schema, StringBuilder code, GeneratorExecutionContext context, ISymbol originTypeSymbol, string sourceAccesor)
        {
            var symbol = originTypeSymbol as ITypeSymbol;

            if (symbol.TypeKind != TypeKind.Enum)
                throw new Exception($"Required type was not satisfied to serialize {schema.Name}");

            code.AppendLine($@"var enumValues = new string[] {{ ""{string.Join(@""",""", schema.Symbols)}"" }};
var indexOfEnumValue = Array.IndexOf(enumValues, {sourceAccesor}.ToString());
if (indexOfEnumValue < 0) throw new AvroSerializationException($""Enum value provided {{{sourceAccesor}}} not found in symbols for enum {schema.Name}"");
IntSchema.Write(outputStream, indexOfEnumValue);");
        }
    }
}
