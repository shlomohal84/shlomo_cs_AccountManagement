#nullable disable

public interface IbankBranch
{
    void AddAccount(CheckingAccount acccount);
    void PrintAccounts();
    int GetBranchNumber();
    string GetAddress();
    BankAccount[] GetAccounts();
    void SetBranchNumber(int branchNumber);
    void SetAddress(string address);
}