namespace AdPlatformsService.Bll.Interfaces;

public interface IPlatformService
{
    void LoadFromFile(string filePath);
    IEnumerable<string> Search(string location);
}
