﻿using System;
namespace ExceptionHandling165
{
    public class AgeException : Exception
    {
        public AgeException()
        { }
        public AgeException(string message)
            : base(message) { }
    }
}
