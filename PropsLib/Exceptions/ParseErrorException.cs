﻿using System;

namespace PropsLib.Exceptions
{
    public abstract class ParseErrorException : Exception
    {
    }

    [Obsolete]
    public class DummyParseErrorException : ParseErrorException
    {
    }
}