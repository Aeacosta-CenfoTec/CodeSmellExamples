public class CustomerService
{
    private string customerName;
    private int age;
    private bool isActive;


    public void UpdateCustomer(string name, int age, bool active)
    {
        UpdateProfile(name, age);
        this.isActive = active;
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
    public void UpdateProfile(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("name");
        if (age < 0)
            throw new ArgumentException("age");
        Name = name;
        Age = age;
    }
}

    public string Name
    {
        get => customerName;
        set => customerName = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public bool IsActive
    {
        get => isActive;
        set => isActive = value;
    }
