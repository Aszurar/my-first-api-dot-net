namespace MyFirstAPI.Communication.Requests;

public class RequestUpdateUserProfileJson
{
    public string Nickname { get; set; } = string.Empty;
    public int Age { get; set; }
}
