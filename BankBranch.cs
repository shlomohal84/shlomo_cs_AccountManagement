#nullable disable
public class BankBranch : IbankBranch
{
    private int branchNumber;
    private string address;
    private CheckingAccount[] accounts = new CheckingAccount[20];

    public BankBranch(int branchNumber, string address)
    {
        this.branchNumber = branchNumber;
        this.address = address;
    }

    public BankBranch(int branchNumber)
    {
        this.branchNumber = branchNumber;
    }
    public void AddAccount(CheckingAccount account)
    {
        int counter = 0;
        for (int i = 0; i < accounts.Length; i++)
            if (accounts[i] != null)
                counter++;
        accounts[counter] = account;
    }

    public void PrintAccounts()
    {
        for (int i = 0; i < accounts.Length; i++)
            if (accounts[i] != null)
                Console.WriteLine($"#{i + 1} - {accounts[i].ToString()}");
    }
    public int GetBranchNumber()
    {
        return branchNumber;
    }
    public string GetAddress()
    {
        return address;
    }
    public BankAccount[] GetAccounts()
    {
        return accounts;
    }
    public void SetBranchNumber(int branchNumber)
    {
        this.branchNumber = branchNumber;
    }
    public void SetAddress(string address)
    {
        this.address = address;
    }

    public override string ToString()
    {
        return $"Branch #{branchNumber}, Address: {address}";
    }

}