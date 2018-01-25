using System.Linq;
using Spectre.CommandLine;

namespace spectretest
{
    public class EditCommand : Command<EditCommand.EditCommandSettings>
    {
        public override int Execute(EditCommandSettings settings, ILookup<string, string> remaining)
        {
            return 0;
        }

        public class EditCommandSettings : SharedCommandSettings
        {
            // given the explicit 0 here, I would have expected it to appear BEFORE the <PATH> argument
            [CommandArgument(0, "<NAME>")]
            public string Name { get; set; }
        }
    }
}
