using System;
using Spectre.CommandLine;

namespace spectretest
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandApp();
            app.Configure(config =>
            {
                config.AddCommand<SharedCommandSettings>("proxy", c =>
                {
                    c.AddCommand<EditCommand>("edit");
                    c.AddCommand<DeleteCommand>("delete");
                    c.AddCommand<CreateCommand>("create");
                });
            });
            app.Run(args);
        }
    }
}
