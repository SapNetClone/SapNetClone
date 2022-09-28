using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetClone.Application.ViewModels.Users
{
    public class ListUserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SocialSecurityCode { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
