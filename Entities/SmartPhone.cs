namespace MyFirstAPI.Entities;

public sealed class SmartPhone : Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public override string GetColor()
    {
        return "Green";

    }
}
