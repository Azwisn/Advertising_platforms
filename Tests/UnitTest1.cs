using AdPlatformsService.Bll.Services;

public class PlatformServiceTests
{
    [Fact]
    public void Search_Returns_AllNestedPlatforms()
    {
        var service = new PlatformService();

        var filePath = Path.GetTempFileName();
        File.WriteAllText(filePath,
            "Yandex:/ru\nLocal:/ru/msk\nRegional:/ru/msk/center");

        service.LoadFromFile(filePath);

        var result = service.Search("/ru/msk/center");

        Assert.Contains("Yandex", result);
        Assert.Contains("Local", result);
        Assert.Contains("Regional", result);
    }
}
