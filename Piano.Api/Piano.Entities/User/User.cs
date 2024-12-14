namespace Piano.Entities.User;

public abstract class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public List<SocialLink> SocialLinks { get; set; }

    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public Guid? ApprovedBy { get; set; }
}