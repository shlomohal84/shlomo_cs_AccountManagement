#nullable disable

public class CheckingAccount : BankAccount
{
    private double overdraftLimit;

    public CheckingAccount(double overdraftLimit, string accountNumber, double balance, Customer customerOwner) : base(accountNumber, balance, customerOwner)
    {
        this.overdraftLimit = overdraftLimit;
    }
    public CheckingAccount(double overdraftLimit, string accountNumber, Customer customerOwner) : base(accountNumber, customerOwner)
    {
        this.overdraftLimit = overdraftLimit;
    }
    public override void Withdraw(double amount)
    {
        if (overdraftLimit + balance - amount >= 0)
            balance -= amount;
        else
            Console.WriteLine("Insufficient funds");
    }

    public override void PrintBalance()
    {
        base.PrintBalance();
        Console.WriteLine($"Overdraft limit: {overdraftLimit}");
    }

    public override string ToString()
    {
        return $"Account No.{base.GetAccountNumber()} | balance: {base.balance} | Owner: {base.GetCustomerOwner().GetName()}";
    }

}