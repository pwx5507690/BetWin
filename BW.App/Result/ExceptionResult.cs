using BW.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BW.App.Result
{
    public class BWException : Exception
    {
        public BWException(string message, bool isWriteLog = false) : base(message)
        {
            WriteLog = isWriteLog;
        }
        public bool WriteLog { get; }
    }

    public class ExceptionResult : JsonNetResult
    {
        public ExceptionResult(string message, bool isWriteLog = true, string controller = null, string stackTrace = null)
        {
            Data = new { exception = message };
            if (isWriteLog) Log.ErrorFormat(message + controller ?? string.Empty + stackTrace ?? string.Empty);
        }

    }
}