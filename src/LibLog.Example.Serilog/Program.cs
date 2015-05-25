﻿namespace LibLog.Example.Serilog
{
    using System;
    using global::Serilog;
    using LibLog.Example.Library;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.ColoredConsole()
                .CreateLogger();
            Log.Logger = log;

            Foo.Bar();

            string json = @"{
    ""key"": ""value"",
    ""key2"": ""value2"",
}";
            Log.Logger.Information("{0}{1} {2}", "Result", Environment.NewLine, json);

            Console.ReadLine();
        }
    }
}