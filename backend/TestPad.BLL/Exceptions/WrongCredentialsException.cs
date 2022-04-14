namespace TestPad.BLL.Exceptions;

public sealed class WrongCredentialsException : Exception
{
    public WrongCredentialsException()
        : base($"Email or password is incorrect")
    { }
}