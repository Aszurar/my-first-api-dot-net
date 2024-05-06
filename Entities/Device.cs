namespace MyFirstAPI.Entities;

public abstract class Device
{ 
    protected bool IsConnected() => true;

    public void Test()
    {
        var x = IsConnected();
    }

    public abstract string GetBrand();

    public virtual string GetColor()
    {
        return "Black";
    }
}
