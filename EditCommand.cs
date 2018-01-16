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
            //this should inherit the SharedCommandSettings.FilePath argument
            // it currently doesn't (i.e. it's not required and doesn't appear in help)
        }
    }
}
