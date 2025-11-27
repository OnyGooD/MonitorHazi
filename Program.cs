namespace monitorok
{
    internal class Program
    {
        class Monitorok
        {
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public string Size { get; set; }
            public string LCDType { get; set; }
            public string Resolution { get; set; }
            public string Range { get; set; }
            public string Interface { get; set; }
            public string LFC { get; set; }
            public string Freesync { get; set; }
            public string HDR { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
