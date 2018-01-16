using Spectre.CommandLine;

namespace spectretest
{
    public class SharedCommandSettings
    {
        // this type however serves as a container of shared arguments and options
        // these options might be shared by most but not all commands, for example
        // this argument *does not* show up in help
        [CommandArgument(0, "<PATH>")]
        public string FilePath { get; set; }
    }
}
