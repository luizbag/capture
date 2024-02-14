using Capture.Configuration;
using Capture.Item;
using CommandLine;

namespace Capture
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ConfigOptions, ItemOptions>(args)
                .MapResult(
                    (ConfigOptions configOptions) =>
                    {
                        Parser.Default.ParseArguments<InitOptions, GetOptions>(args.Skip(1).ToArray())
                                            .MapResult(
                                                (InitOptions opts) => new InitConfig(configOptions, opts).Run(),
                                                (GetOptions opts) => new GetConfig(configOptions, opts).Run(),
                                                errs => 1
                                            );
                        return 0;
                    },
                    (ItemOptions opts) => RunCaptureItem(opts),
                    errs => 1
                );
        }

        public static int RunCaptureItem(ItemOptions opts)
        {
            return new CaptureItem(opts).Run();
        }
    }
}