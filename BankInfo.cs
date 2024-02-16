using SimpleBankAcctConsoleApp.Exceptions;

namespace SimpleBankAcctConsoleApp;

public sealed class BankInfo
{
    private readonly string _name;
    private readonly string _surname;
    private readonly string _accountNumber;
    private decimal _balance;
    
    private decimal HoldAmount
    {
        get
        {
            decimal holdAmount = 0;
          
            if( _balance < 500)
                holdAmount = _balance / 3;
            else if(_balance > 500 && _balance < 5000)
                holdAmount = _balance / 5;
            else if(_balance > 5000)
                holdAmount = _balance - 100;
            return holdAmount;
        }
    }

    
    public BankInfo(
        string name,
        string surname,
        string accountNumber,
        decimal initialAmount)
    {
        _name = name;
        _surname = surname;
        _accountNumber = accountNumber;
        _balance = initialAmount;
    }
    

    public void Debit(decimal amount)
    {
        
        if (amount <= 0)
           throw new InvalidInputException();
        
        _balance += amount;
        Console.WriteLine($"{amount} has been added successfully! Balance is: {_balance}");
    }

    public void Withdrawal(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidInputException();
        
        if (amount > _balance - HoldAmount)
            throw new InsufficientFundsException();
        
        _balance -= amount;
        Console.WriteLine($"{amount} has been  withdrawn! Balance is: {_balance}");
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {_accountNumber}");
        Console.WriteLine($"Account Holder: {_name} {_surname}");
        Console.WriteLine($"Account Balance: {_balance}");
    }
}