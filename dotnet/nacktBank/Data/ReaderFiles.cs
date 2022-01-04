namespace nacktBank.Data
{
    public class ReaderFiles : IDisposable
    {
        public string File { get; }
        public ReaderFiles(string file)
        {
            File = file;
            if (File != "accounts.txt") throw new FileNotFoundException();
            System.Console.WriteLine($"Open File: {File}");
        }
        public string ReadNextLine() {
            System.Console.WriteLine("Reading Line...");
            throw new IOException();
            return "Line from File";
        }
        public void Dispose()
        {
            System.Console.WriteLine("Closing file.");
        }
    }
}