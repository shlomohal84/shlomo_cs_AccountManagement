#nullable disable

public class Customer
{
    private string id;
    private string name;
    private string phoneNumber;

    public Customer(string id, string name, string phoneNumber)
    {
        this.id = id;
        this.name = name;
        this.phoneNumber = phoneNumber;
    }
    public void PrintDetails()
    {
        Console.WriteLine($"id: {id}, name: {name}, phone number: {phoneNumber}");
    }
    public string GetId() { return id; }
    public string GetName() { return name; }
    public string GetPhoneNumber() { return phoneNumber; }
    public void SetId(string id) { this.id = id; }
    public void SetName(string name) { this.name = name; }
    public void SetPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }

    public override string ToString()
    {
        return $"id: {id}, name: {name}, phone number: {phoneNumber}";
    }


}