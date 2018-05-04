﻿namespace SnTraceAnalyzerTests.Analysis
{
    /// <summary>
    /// Contains available values of the Status column.
    /// </summary>
    public static class Status
    {
        /// <summary>Value is ""</summary>
        public static readonly string Empty = "";
        /// <summary>Value is "Start"</summary>
        public static readonly string Start = "Start";
        /// <summary>Value is "End"</summary>
        public static readonly string End = "End";
        /// <summary>Value is "UNSUCCESSFUL"</summary>
        public static readonly string Unterminated = "UNTERMINATED";
        /// <summary>Value is "ERROR"</summary>
        public static readonly string Error = "ERROR";
    }
}