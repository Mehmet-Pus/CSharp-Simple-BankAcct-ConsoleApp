using SimpleBankAcctConsoleApp.Exceptions;

namespace SimpleBankAcctConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BankInfo account = new BankInfo("Jade", "Pilgrim", "7373373", 0);

                Console.WriteLine("Bank Account Information: ");
                account.DisplayAccountInfo();

                // account.Debit(700.00m);
                // account.Withdrawal(333.33m);
                //
                // account.Debit(450.00m);
                // account.Withdrawal(333.33m);

                // account.Debit(450.00m);
                // account.Withdrawal(440.33m);
                //
                account.Debit(3500.00m);
                account.Withdrawal(333.33m);

                //throw new Exception("try");

                // account.Debit(10.00m);
                // account.Withdrawal(333.33m);

                // account.Debit(3500.00m);
                // account.Withdrawal(3000.33m);

                Console.WriteLine("Updated Account Information: ");
                account.DisplayAccountInfo();
            }
            catch (InvalidInputException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            catch (InsufficientFundsException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.Clear();
            }
        }
    }
}