using CommandLine;

namespace Capture.Item
{
    [Verb("capture", HelpText = "Capture things...")]
    public class ItemOptions
    {
        [Value(0, Required = true, MetaName = "Item type", HelpText = "The type of item you want to capture")]
        public required string ItemType { get; set; }
    }

    public class CaptureItem
    {
        public ItemOptions Options { get; set; }

        public CaptureItem(ItemOptions options)
        {
            Options = options;
        }

        public int Run()
        {
            Console.WriteLine(Options.ItemType);
            return 0;
        }
    }
}