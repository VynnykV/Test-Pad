namespace TestPad.BLL.Exceptions;

public sealed class UserWithSuchPropertyAlreadyExists : Exception
{
    public UserWithSuchPropertyAlreadyExists(string name) 
        : base($"User with such {name} already exists.") { }
}