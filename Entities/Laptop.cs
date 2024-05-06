namespace MyFirstAPI.Entities;

public class Laptop: Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public string GetModal()
    {
        var isConnected = IsConnected();

        return isConnected ? "MacBook" : "Unknow";
    }
}
