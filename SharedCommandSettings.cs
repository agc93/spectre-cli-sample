using Spectre.CommandLine;

namespace spectretest
{
    public class ProxySettings {}
    public class SharedCommandSettings : ProxySettings
    {
        // Given the 1 here, we expect this command to come after any 0-position arguments
        [CommandArgument(1, "<PATH>")]
        public string FilePath { get; set; }
    }
}
