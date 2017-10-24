using Spectre.CommandLine.Annotations;

namespace spectretest
{
    public class SharedCommandSettings : ProxyCommandSettings
    {
        // this type however serves as a container of shared arguments and options
        // these options might be shared by most but not all commands, for example

        [Argument(0, "<PATH>")]
        public string FilePath { get; set; }
    }
}
