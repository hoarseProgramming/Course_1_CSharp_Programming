
internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Start of Main");
        //Start
        Task<int> task = Download();

        Console.WriteLine("Main continues ...");

        //Waits for downloads result.
        int result = await task;

        Console.WriteLine($"Main prints result: {result}");
        Console.WriteLine("End of main");  
    }
    private static async Task<int> Download()
    {
        HttpClient client = new HttpClient();

        //Asynchronous method starts
        Task<string> download = client.GetStringAsync("https://www.google.com");

        Console.WriteLine("Download started...");

        //await waits for task to finish, won't run lines under it, but won't lock thread.
        //returns Task to main
        string data = await download;

        Console.WriteLine("Download complete!");
        
        Console.WriteLine( $"Got {data.Length} chars of data");

        return data.Length;
    }
}