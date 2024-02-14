using CommandLine;

namespace Capture.Configuration
{
    [Verb("config", HelpText = "Configurations")]
    public class ConfigOptions
    {
        [Option("config file")]
        public string ConfigFile { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "config.json");
    }
}