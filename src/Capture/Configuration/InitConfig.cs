using CommandLine;

namespace Capture.Configuration
{

    [Verb("init", HelpText = "Initialize configuration file")]
    public class InitOptions
    { }

    public class InitConfig
    {
        public ConfigOptions _configOptions { get; set; }

        public InitOptions _initOptions { get; set; }

        public InitConfig(ConfigOptions configOptions, InitOptions initOptions)
        {
            _configOptions = configOptions;
            _initOptions = initOptions;
        }

        public int Run()
        {
            Console.WriteLine(_configOptions.ConfigFile);
            return 0;
        }
    }
}