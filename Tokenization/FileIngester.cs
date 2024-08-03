namespace intlab.Tokenization;

public static class FileIngester
{
    public static List<string> IngestFile(string relativePath)
    {
        List<string> lines = new();

        string? curLine;

        try
        {
            StreamReader streamReader = new StreamReader(relativePath);

            curLine = streamReader.ReadLine();

            while (curLine != null)
            {
                lines.Add(curLine);

                curLine = streamReader.ReadLine();
            }

            streamReader.Close();
        }

        catch (Exception e)
        {
            Console.WriteLine($"Error reading file \"{relativePath}\": {e}");
        }

        return lines;
    }
}