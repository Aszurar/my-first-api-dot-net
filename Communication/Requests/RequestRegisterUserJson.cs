namespace MyFirstAPI.Communication.Requests;

public class RequestRegisterUserJson
{

    public string Nickname { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    public int Age { get; set; }

}
