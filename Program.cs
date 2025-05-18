#nullable disable
class Program
{
    static void Main(string[] args)
    {
        BankBranch branch1 = new BankBranch(732, "Shtampfer 22");
        Console.WriteLine(branch1.ToString());

        Customer c1 = new Customer("301919121", "Scrooge McDuck", "+9725454545");
        c1.PrintDetails();
        CheckingAccount ac1 = new CheckingAccount(500, "123456", 250, c1);
        CheckingAccount ac2 = new CheckingAccount(0, "00001", c1);

        ac1.PrintBalance();

        branch1.AddAccount(ac1);
        branch1.AddAccount(ac2);
        branch1.GetAccounts()[1].SetCustomerOwner(new Customer("001", "John Doe", "911"));
        branch1.PrintAccounts();

        branch1.GetAccounts()[0].Withdraw(1000);
        branch1.GetAccounts()[0].Withdraw(500);
        Console.WriteLine(branch1.GetAccounts()[0].ToString());

    }
}

