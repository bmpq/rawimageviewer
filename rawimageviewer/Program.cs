namespace rawimageviewer
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(args.Length == 0 ? new Form1(string.Empty) : new Form1(args[0]));
        }
    }
}