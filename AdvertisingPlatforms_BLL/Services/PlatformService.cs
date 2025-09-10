using AdPlatformsService.Bll.Interfaces;

namespace AdPlatformsService.Bll.Services;

public class PlatformService : IPlatformService
{
    private readonly Dictionary<string, List<string>> _locationMap = new();

    public void LoadFromFile(string filePath)
    {
        _locationMap.Clear();

        foreach (var line in File.ReadLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var parts = line.Split(':', 2);
            if (parts.Length != 2) continue;

            var platform = parts[0].Trim();
            var locations = parts[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

            foreach (var loc in locations)
            {
                var location = loc.Trim();
                if (!_locationMap.ContainsKey(location))
                    _locationMap[location] = new List<string>();

                _locationMap[location].Add(platform);
            }
        }
    }

    public IEnumerable<string> Search(string location)
    {
        var result = new List<string>();
        var segments = location.Split('/', StringSplitOptions.RemoveEmptyEntries);

        for (int i = segments.Length; i >= 1; i--)
        {
            var prefix = "/" + string.Join("/", segments.Take(i));
            if (_locationMap.TryGetValue(prefix, out var platforms))
                result.AddRange(platforms);
        }

        return result.Distinct();
    }
}
