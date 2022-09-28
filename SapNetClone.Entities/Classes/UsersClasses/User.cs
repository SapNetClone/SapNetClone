using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetClone.Entities.Classes.UsersClasses;

public class User : BaseObject
{
    public string? Name { get; set; }

    public string? Password { get; set; }
    public string Email { get; set; }
    public string SocialSecurityCode { get; set; }
    public string TelephoneNumber { get; set; }
}