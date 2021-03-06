﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyConsole;

namespace SampleConsole
{
    /// <summary>
    /// As an example of ManyConsole usage, get-time is meant to show the simplest case possible usage.
    /// </summary>
    public class GetTime : ConsoleCommand
    {
        public GetTime()
        {
            Command = "get-text";
            OneLineDescription = "Returns the current system time.";
        }

        public override int Run()
        {
            Console.WriteLine(DateTime.UtcNow);

            return 0;
        }
    }
}
