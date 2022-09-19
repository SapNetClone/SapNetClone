using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetClone.Entities.Classes.UsersClasses;

public class User : BaseObject
{
    public string Name { get; set; }

    public string Password { get; set; }
}