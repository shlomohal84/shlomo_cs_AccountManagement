#nullable disable

public class BankAccount
{
    private string accountNumber;
    protected double balance = 1500;
    private Customer customerOwner;

    public BankAccount(string accountNumber, Customer customerOwner)
    {
        this.accountNumber = accountNumber;
        this.customerOwner = customerOwner;
    }
    public BankAccount(string accountNumber, double balance, Customer customerOwner)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.customerOwner = customerOwner;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
    public virtual void Withdraw(double amount)
    {
        if (balance - amount >= 0)
            balance -= amount;
        else
            Console.WriteLine("Insufficient funds");
    }
    public virtual void PrintBalance()
    {
        Console.WriteLine($"Current funds: {balance}");
    }

    public string GetAccountNumber() { return accountNumber; }
    public double GetBalance() { return balance; }
    public Customer GetCustomerOwner() { return customerOwner; }
    public void SetAccountNumber(string accountNumber) { this.accountNumber = accountNumber; }
    public void SetBalance(double amount) { balance = amount; }
    public void SetCustomerOwner(Customer customer) { customerOwner = customer; }
}