using CommandLine;

namespace Capture.Configuration
{

    [Verb("get", HelpText = "Get configuration by bame")]
    public class GetOptions
    {
        [Value(0, Required = true, HelpText = "Name of the configuration")]
        public required string Name { get; set; }
    }

    public class GetConfig
    {
        public ConfigOptions _configOptions { get; set; }

        public GetOptions _getOptions { get; set; }

        public GetConfig(ConfigOptions configOptions, GetOptions getOptions)
        {
            _configOptions = configOptions;
            _getOptions = getOptions;
        }

        public int Run()
        {
            Console.WriteLine(_configOptions.ConfigFile);
            Console.WriteLine(_getOptions.Name);
            return 0;
        }
    }
}