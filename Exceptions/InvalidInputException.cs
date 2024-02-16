namespace SimpleBankAcctConsoleApp.Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException() 
        : base("Amount must be more then '0'")
    {
        
    }
}