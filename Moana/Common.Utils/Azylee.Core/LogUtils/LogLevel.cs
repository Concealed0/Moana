﻿//############################################################
//      https://github.com/yuzhengyang
//      author:yuzhengyang
//############################################################
using System;

namespace Azylee.Core.LogUtils
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Verbose = 1,
        Debug = 2,
        Information = 4,
        Warning = 8,
        Error = 16,
        All = Verbose | Debug | Information | Warning | Error,
    }
}
