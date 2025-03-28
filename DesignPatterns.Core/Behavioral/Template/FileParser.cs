namespace _3._2;

public abstract class FileParser
{
    public Dictionary<string, string> ParseFile(string path)
    {
        LogOperation($"Validating {path}");
        ValidateFile(path);

        LogOperation("Loading the file");
        string content = File.ReadAllText(path);

        LogOperation("Parsing the file");
        Dictionary<string, string> data = ParseContent(content);

        LogOperation("Validating the file");
        EnrichData(data);

        LogOperation("Enriching the file");
        ValidateData(data);

        return data;
    }

    protected virtual void EnrichData(Dictionary<string, string> data)
    {
        data["parsedAt"] = DateTime.UtcNow.ToString();
    }

    protected virtual void ValidateData(Dictionary<string, string> data)
    {
    }

    private void ValidateFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new Exception("file does not exist");
        }

        if (new FileInfo(path).Length == 0)
        {
            throw new Exception("file is empty");
        }
    }

    public abstract Dictionary<string, string> ParseContent(string content);
    public virtual void LogOperation(string message)
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {message}");
    }
}