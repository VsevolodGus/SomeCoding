namespace Store.DAL.Entities;
public class User
{
    public User() 
    {
        ID = Guid.NewGuid();
    }

    public Guid ID { get; init; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
