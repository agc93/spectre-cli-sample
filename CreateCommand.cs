using Spectre.CommandLine;
using Spectre.CommandLine.Annotations;

namespace spectretest
{
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
