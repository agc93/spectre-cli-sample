using System.Linq;
using Spectre.CommandLine;

namespace spectretest
{
    public class CreateCommand : Command<CreateCommand.CreateCommandSettings>
    {
        public override int Execute(CreateCommandSettings settings, ILookup<string, string> remaining)
        {
            return 0;
        }

        public class CreateCommandSettings : SharedCommandSettings
        {

            [CommandOption("-n|--name")]
            public string Name { get; set; }
        }
    }
}
