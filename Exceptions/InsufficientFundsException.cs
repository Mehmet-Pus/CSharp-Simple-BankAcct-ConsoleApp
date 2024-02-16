namespace SimpleBankAcctConsoleApp.Exceptions;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
        : base("Insufficient funds for withdrawal.")
    {
        
    }

    public InsufficientFundsException(string message)
    : base(message)
    {
        
    }
}