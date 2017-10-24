using System;
using Spectre.CommandLine;
using Spectre.CommandLine.Annotations;

namespace spectretest
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandApp();
            app.Configure(config =>
            {
                config.AddProxy<ProxyCommandSettings>("proxy", c =>
                {
                    c.AddCommand<EditCommand>("edit");
                    c.AddCommand<DeleteCommand>("delete");
                    c.AddCommand<CreateCommand>("create");
                });
            });
            app.Run(args);
        }
    }

    public class ProxyCommandSettings
    {
        // this proxy is just that: a container of commands, no settings
        // this could have shared settings (like the `--verbose` option in the samples)
        // but for the sakes of clarity we'll leave that out
    }

    public class SharedCommandSettings : ProxyCommandSettings
    {
        // this type however serves as a container of shared arguments and options
        // these options might be shared by most but not all commands, for example

        [Argument(0, "<PATH>")]
        public string FilePath { get; set; }
    }

    public class EditCommand : Command<EditCommand.EditCommandSettings>
    {
        public override int Run(EditCommandSettings settings)
        {
            return 0;
        }

        public class EditCommandSettings : SharedCommandSettings
        {
            //this should inherit the SharedCommandSettings.FilePath argument
            // it currently doesn't (i.e. it's not required and doesn't appear in help)
        }
    }

    public class DeleteCommand : Command<DeleteCommand.DeleteCommandSettings>
    {
        public override int Run(DeleteCommandSettings settings)
        {
            return 0;
        }

        public class DeleteCommandSettings : SharedCommandSettings
        {
            //this should inherit the SharedCommandSettings.FilePath argument
            // it currently doesn't (i.e. it's not required and doesn't appear in help)
        }
    }

    public class CreateCommand : Command<CreateCommand.CreateCommandSettings>
    {
        public override int Run(CreateCommandSettings settings)
        {
            return 0;
        }

        public class CreateCommandSettings : ProxyCommandSettings
        {
            // since this command inherits directly from ProxyCommandSettings
            // it currently works fine

            [Option("-n|--name")]
            public string Name { get; set; }
        }
    }
}
