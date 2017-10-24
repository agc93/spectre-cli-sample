using Spectre.CommandLine;

namespace spectretest
{
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
}
