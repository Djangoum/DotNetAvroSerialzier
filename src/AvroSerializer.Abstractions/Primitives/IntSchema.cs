﻿using System.IO;

namespace AvroSerializer.Primitives
{
    public static class IntSchema
    {
        public static void Write(Stream outputStream, int value)
        {
            ulong n = (ulong)((value << 1) ^ (value >> 63));
            while ((n & ~0x7FUL) != 0)
            {
                outputStream.WriteByte((byte)((n & 0x7f) | 0x80));
                n >>= 7;
            }
            outputStream.WriteByte((byte)n);
        }
    }
}
