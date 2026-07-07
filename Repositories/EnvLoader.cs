namespace BromoAirlines.Repositories;

public static class EnvLoader
{
    public static void Load()
    {
        var envPath = FindEnvPath();
        if (envPath is null)
        {
            return;
        }

        foreach (var line in File.ReadAllLines(envPath))
        {
            LoadLine(line);
        }
    }

    private static void LoadLine(string line)
    {
        var trimmedLine = line.Trim();
        if (string.IsNullOrWhiteSpace(trimmedLine) || trimmedLine.StartsWith('#'))
        {
            return;
        }

        var separatorIndex = trimmedLine.IndexOf('=');
        if (separatorIndex <= 0)
        {
            return;
        }

        var key = trimmedLine[..separatorIndex].Trim();
        var value = trimmedLine[(separatorIndex + 1)..].Trim().Trim('"');
        Environment.SetEnvironmentVariable(key, value);
    }

    private static string? FindEnvPath()
    {
        var currentDirectoryPath = Path.Combine(Environment.CurrentDirectory, ".env");
        if (File.Exists(currentDirectoryPath))
        {
            return currentDirectoryPath;
        }

        var baseDirectoryPath = Path.Combine(AppContext.BaseDirectory, ".env");
        return File.Exists(baseDirectoryPath) ? baseDirectoryPath : null;
    }
}
