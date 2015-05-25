namespace LibLog.Example.Library
{
    using System;
    using LibLog.Example.Library.Logging;

    public static class Foo
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public static void Bar()
        {
            string json = @"{
    ""key"": ""value"",
    ""key2"": ""value2"",
}";
            Logger.InfoFormat("{0}{1} {2}", "Result", Environment.NewLine, json);
        }
    }
}