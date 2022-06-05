namespace Facade
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var scanFacade = new ScanFacade();

            scanFacade.Scan("http://github.com/somerepo");
        }
    }
}