// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license.
// See the license.txt file in the project root for more information.

using System;

namespace Markdig.Helpers
{
    /// <summary>
    /// Represents a character or set of characters that represent a separation
    /// between two lines of text
    /// </summary>
    public enum NewLine : byte
    {
        None,
        CarriageReturn,
        LineFeed,
        CarriageReturnLineFeed
    }

    public static class NewLineExtensions
    {
        public static string AsString(this NewLine newLine)
        {
            if (newLine == NewLine.CarriageReturnLineFeed)
            {
                return "\r\n";
            }
            if (newLine == NewLine.LineFeed)
            {
                return "\n";
            }
            if (newLine == NewLine.CarriageReturn)
            {
                return "\r";
            }
            return string.Empty;
        }

        public static int Length(this NewLine newLine) => newLine switch
        {
            NewLine.None => 0,
            NewLine.CarriageReturn => 1,
            NewLine.LineFeed => 1,
            NewLine.CarriageReturnLineFeed => 2,
            _ => throw new NotSupportedException(),
        };
    }
}

