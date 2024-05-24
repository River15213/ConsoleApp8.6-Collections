namespace ConsoleAppWriteBookXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteXMLFile writeXMLFile = new WriteXMLFile();

            var infoUserXML = writeXMLFile.WriteInfoUserXML();

            Console.WriteLine(infoUserXML);
        }
    }
}
